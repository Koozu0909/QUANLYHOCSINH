using BussinessLayer;
using DataLayer;
using System;
using System.Linq;
using System.Windows.Forms;

namespace QUANLYHOCSINH
{
    public partial class frmQLDiem : DevExpress.XtraEditors.XtraForm
    {
        public frmQLDiem()
        {
            InitializeComponent();
        }

        private HOCSINH _hocsinh;
        private LOPHOC _lophoc;
        private NAMHOC _namhoc;
        private HOCKY _hocky;
        private KHOILOP _khoilop;
        private DIEM _diem;
        private MONHOC _monhoc;
        private bool _them;
        private int _id = 0;
        private int _diemid = 0;

        private void frmQLDiem_Load(object sender, EventArgs e)
        {
            showHide(true);
            _namhoc = new NAMHOC();
            _lophoc = new LOPHOC();
            _hocky = new HOCKY();
            _khoilop = new KHOILOP();
            _hocsinh = new HOCSINH();
            _diem = new DIEM();
            _monhoc = new MONHOC();
            loadData();
            getListHS();
            if (gvHocSinh.RowCount > 0)
            {
                gvHocSinh.FocusedRowHandle = 0;
                _id = int.Parse(gvHocSinh.GetFocusedRowCellValue("MaHS").ToString());
                Console.WriteLine(_id);
            }
        }

        private void loadData()
        {
            cboNamHoc.DataSource = _namhoc.getList();
            cboNamHoc.DisplayMember = "TenNamHoc";
            cboNamHoc.ValueMember = "MaNamHoc";

            cboKhoiLop.DataSource = _khoilop.getList();
            cboKhoiLop.DisplayMember = "TenKhoiLop";
            cboKhoiLop.ValueMember = "MaKhoiLop";

            cboMonHoc.DataSource = _monhoc.getList();
            cboMonHoc.DisplayMember = "TenMH";
            cboMonHoc.ValueMember = "MaMH";

            int maNamHoc;
            if (int.TryParse(cboNamHoc.SelectedValue.ToString(), out maNamHoc))
            {
                cboHocKy.DataSource = _hocky.getList(maNamHoc);
                cboHocKy.DisplayMember = "TenHocKy";
                cboHocKy.ValueMember = "MaHocKy";
            }
            else
            {
                // Không làm gì nếu giá trị được chọn không phải là một chuỗi số hợp lệ
            }

            int maKhoiLop;
            if (int.TryParse(cboKhoiLop.SelectedValue.ToString(), out maKhoiLop))
            {
                cboLop.DataSource = _lophoc.getList(maKhoiLop);
                cboLop.DisplayMember = "TenLop";
                cboLop.ValueMember = "MaLop";
            }
            else
            {
                // Không làm gì nếu giá trị được chọn không phải là một chuỗi số hợp lệ
            }
        }

        private void cboHocKy_SelectedIndexChanged(object sender, EventArgs e)
        {
            getDiem();
        }

        private void cboMonHoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            getDiem();
        }

        private void cboLop_SelectedIndexChanged(object sender, EventArgs e)
        {
            getListHS();
            getDiem();
        }

        private void cboKhoiLop_SelectedIndexChanged(object sender, EventArgs e)
        {
            int maKhoiLop;
            if (int.TryParse(cboKhoiLop.SelectedValue.ToString(), out maKhoiLop))
            {
                cboLop.DataSource = _lophoc.getList(maKhoiLop);
                cboLop.DisplayMember = "TenLop";
                cboLop.ValueMember = "MaLop";
                getListHS();
                getDiem();
            }
            else
            {
                // Không làm gì nếu giá trị được chọn không phải là một chuỗi số hợp lệ
            }
        }

        private void cboNamHoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            int maNamHoc;
            if (int.TryParse(cboNamHoc.SelectedValue.ToString(), out maNamHoc))
            {
                cboHocKy.DataSource = _hocky.getList(maNamHoc);
                cboHocKy.DisplayMember = "TenHocKy";
                cboHocKy.ValueMember = "MaHocKy";
                getListHS();
                getDiem();
            }
            else
            {
                // Không làm gì nếu giá trị được chọn không phải là một chuỗi số hợp lệ
            }
        }

        private void getListHS()
        {
            int manamhoc;
            int malop;
            if (int.TryParse(cboNamHoc.SelectedValue.ToString(), out manamhoc) && int.TryParse(cboLop.SelectedValue.ToString(), out malop))
            {
                var lstHocSinh = _hocsinh.getList(malop, manamhoc);
                gcHocSinh.DataSource = lstHocSinh.ToList();
                gvHocSinh.OptionsBehavior.Editable = false;
            }
            else
            {
                // Không làm gì nếu giá trị được chọn không phải là một chuỗi số hợp lệ
            }
        }

        private void getDiem()
        {
            int manamhoc;
            int malop;
            int mahk;
            int mamonhoc;
            if (cboNamHoc.SelectedValue != null && cboLop.SelectedValue != null && cboHocKy.SelectedValue != null && cboMonHoc.SelectedValue != null &&
                int.TryParse(cboNamHoc.SelectedValue.ToString(), out manamhoc) && int.TryParse(cboLop.SelectedValue.ToString(), out malop) &&
                int.TryParse(cboHocKy.SelectedValue.ToString(), out mahk) && int.TryParse(cboMonHoc.SelectedValue.ToString(), out mamonhoc))
            {
                var diem = _diem.getListBy(malop, mahk, mamonhoc, manamhoc, _id);
                gcDiem.DataSource = diem.ToList();
                gvDiem.OptionsBehavior.Editable = false;
                gvDiem.Columns["DiemTB"].DisplayFormat.FormatString = "0.##";
            }
            else
            {
                // Không làm gì nếu giá trị được chọn không phải là một chuỗi số hợp lệ hoặc giá trị
                // của thuộc tính SelectedValue là null
            }
        }

        private void showHide(bool kt)
        {
            btnLuu.Enabled = !kt;
            btnHuy.Enabled = !kt;
            btnThem.Enabled = kt;
            btnChange.Enabled = kt;
            btnXoa.Enabled = kt;
            btnDong.Enabled = kt;
            txtDiemLan1.Enabled = !kt;
            txtDiemLan2.Enabled = !kt;
            txtKiemTra.Enabled = !kt;
        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            showHide(false);
            _them = true;
            if (gvDiem.RowCount > 0)
            {
                gvDiem.FocusedRowHandle = 0;
                _diemid = int.Parse(gvDiem.GetFocusedRowCellValue("MaKQ").ToString());
            }
        }

        private void btnChange_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            showHide(false);
            _them = false;
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (MessageBox.Show("Bạn Có Chắc Xóa ?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                _diem.Delete(_diemid);
            }
            getListHS();
            loadData();
        }

        private void btnLuu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            saveData();
            showHide(true);
            getDiem();
        }

        private void btnHuy_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            showHide(true);
            _them = false;
        }

        private void btnDong_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void saveData()
        {
            if (_them)
            {
                tb_KetQua kq = new tb_KetQua();
                if (txtKiemTra.Text != "")
                {
                    kq.DiemKT = float.Parse(txtKiemTra.Text);
                }
                else
                {
                    kq.DiemKT = 0;
                }
                if (txtDiemLan1.Text != "")
                {
                    kq.DiemThiLan1 = float.Parse(txtDiemLan1.Text);
                }
                else
                {
                    kq.DiemThiLan1 = 0;
                }
                if (txtDiemLan2.Text != "")
                {
                    kq.DiemThiLan2 = float.Parse(txtDiemLan2.Text);
                }
                else
                {
                    kq.DiemThiLan2 = 0;
                }
                float diemLamTron = (float)((kq.DiemThiLan1.GetValueOrDefault() + kq.DiemKT.GetValueOrDefault() + kq.DiemThiLan2.GetValueOrDefault()) / 3);

                kq.DiemTB = (float)Math.Round(diemLamTron, 1, MidpointRounding.AwayFromZero); // sử dụng Math.Round() để làm tròn điểm trung bình
                if (kq.DiemTB <= 5)
                {
                    kq.XepLoai = " Dưới 5";
                }
                else
                {
                    kq.XepLoai = "Trên 5";
                }

                kq.MaHocKy = int.Parse(cboHocKy.SelectedValue.ToString());
                kq.MaHS = _id;
                kq.MaLop = int.Parse(cboLop.SelectedValue.ToString());
                kq.MaMH = int.Parse(cboMonHoc.SelectedValue.ToString());
                kq.MaNamHoc = int.Parse(cboNamHoc.SelectedValue.ToString());
                _diem.Add(kq);
            }
            else
            {
                tb_KetQua kq = _diem.getItem(_diemid);
                if (txtKiemTra != null && txtKiemTra.Text != "")
                {
                    kq.DiemKT = float.Parse(txtKiemTra.Text);
                }
                else
                {
                    kq.DiemKT = 0;
                }
                /////
                if (txtDiemLan1 != null && txtDiemLan1.Text != "")
                {
                    kq.DiemThiLan1 = float.Parse(txtDiemLan1.Text);
                }
                else
                {
                    kq.DiemThiLan1 = 0;
                }
                ///////
                if (txtDiemLan2 != null && txtDiemLan2.Text != "")
                {
                    kq.DiemThiLan2 = float.Parse(txtDiemLan2.Text);
                }
                else
                {
                    kq.DiemThiLan2 = 0;
                }
                float diemLamTron = (float)((kq.DiemThiLan1.GetValueOrDefault() + kq.DiemKT.GetValueOrDefault() + kq.DiemThiLan2.GetValueOrDefault()) / 3);
                Console.WriteLine(diemLamTron);
                kq.DiemTB = Math.Round(diemLamTron, 2, MidpointRounding.AwayFromZero); // sử dụng Math.Round() để làm tròn điểm trung bình
                Console.WriteLine(kq.DiemTB);
                if (kq.DiemTB <= 5)
                {
                    kq.XepLoai = " Dưới 5";
                }
                else
                {
                    kq.XepLoai = "Trên 5";
                }

                kq.MaHocKy = int.Parse(cboHocKy.SelectedValue.ToString());
                kq.MaHS = _id;
                kq.MaLop = int.Parse(cboLop.SelectedValue.ToString());
                kq.MaMH = int.Parse(cboMonHoc.SelectedValue.ToString());
                kq.MaNamHoc = int.Parse(cboNamHoc.SelectedValue.ToString());
                _diem.Update(kq);
            }
        }

        private void gvHocSinh_Click(object sender, EventArgs e)
        {
            if (gvHocSinh.RowCount > 0)
            {
                _id = int.Parse(gvHocSinh.GetFocusedRowCellValue("MaHS").ToString());
                getDiem();
                if (gvDiem.RowCount > 0)
                {
                    btnThem.Enabled = false;
                    gvDiem.FocusedRowHandle = 0;
                    _diemid = int.Parse(gvDiem.GetFocusedRowCellValue("MaKQ").ToString());
                    Console.WriteLine(_diemid);
                    var kq = _diem.getItem(_diemid);
                    txtKiemTra.Text = kq.DiemKT.ToString();
                    txtDiemLan2.Text = kq.DiemThiLan2.ToString();
                    txtDiemLan1.Text = kq.DiemThiLan1.ToString();
                }
                else
                {
                    btnThem.Enabled = true;
                }
            }
        }

        private void gvDiem_Click(object sender, EventArgs e)
        {
            if (gvDiem.RowCount > 0)
            {
                _diemid = int.Parse(gvDiem.GetFocusedRowCellValue("MaKQ").ToString());
                Console.WriteLine(_diemid);
                var kq = _diem.getItem(_diemid);
                txtKiemTra.Text = kq.DiemKT.ToString();
                txtDiemLan2.Text = kq.DiemThiLan2.ToString();
                txtDiemLan1.Text = kq.DiemThiLan1.ToString();
            }
        }
    }
}