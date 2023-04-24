using BussinessLayer;
using DataLayer;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace QUANLYHOCSINH
{
    public partial class frmPhanLop : DevExpress.XtraEditors.XtraForm
    {
        public frmPhanLop()
        {
            InitializeComponent();
        }

        private QUANLYHOCSINHEntities db = new QUANLYHOCSINHEntities();

        private NAMHOC _namhoc;
        private HOCSINH _hocsinh;
        private KHOILOP _khoilop;
        private LOPHOC _lophoc;
        private HOCSINH_LOP_NAMHOC _phanlop;
        private int _id;

        private void frmPhanLop_Load(object sender, EventArgs e)
        {
            _hocsinh = new HOCSINH();
            _namhoc = new NAMHOC();
            _khoilop = new KHOILOP();
            _lophoc = new LOPHOC();
            _phanlop = new HOCSINH_LOP_NAMHOC();
            loadKhoiLop();
            loadNamhoc();
            cboKhoiLop.SelectedIndexChanged += cboKhoiLop_SelectedIndexChanged;
            loadLop();
            loadHocSinh();
            loadPhanLop();
            showHide(true);
            btnXoaHS.Enabled = false;
        }

        private void loadNamhoc()
        {
            cboNamHoc.DataSource = _namhoc.getList();
            cboNamHoc.DisplayMember = "TenNamHoc";
            cboNamHoc.ValueMember = "MaNamHoc";
        }

        private void loadKhoiLop()
        {
            cboKhoiLop.DataSource = _khoilop.getList();
            cboKhoiLop.DisplayMember = "TenKhoiLop";
            cboKhoiLop.ValueMember = "MaKhoiLop";
        }

        private void loadLop()
        {
            _lophoc = new LOPHOC();
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

        private void loadPhanLop()
        {
            int namHoc;
            int lop;
            int khoilop;
            if (int.TryParse(cboNamHoc.SelectedValue.ToString(), out namHoc) && int.TryParse(cboLop.SelectedValue.ToString(), out lop) && int.TryParse(cboKhoiLop.SelectedValue.ToString(), out khoilop))
            {
                gcHocSinhLop.DataSource = _phanlop.getList(namHoc, lop, khoilop);
                gvHocSinhLop.OptionsBehavior.Editable = false;
            }
            else
            {
                // Handle the case where the parsing failed
            }
        }

        private void showHide(bool kt)
        {
            gcHocSinhLop.Enabled = kt;
            btnCapNhat.Enabled = kt;
            btnXoa.Enabled = kt;
            btnDong.Enabled = kt;
            btnHuy.Enabled = !kt;
            btnLuu.Enabled = !kt;
            //cboKhoiLop.Enabled = !kt;
            //cboLop.Enabled = !kt;
            //cboNamHoc.Enabled = !kt;
            gcHocSinh.Enabled = !kt;
        }

        private void cboLop_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadPhanLop();
        }

        private void cboKhoiLop_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadLop();
        }

        private void loadHocSinh()
        {
            var lstHocSinh = _hocsinh.getList().Where(hs => !db.tb_HocSinh_Lop_NamHoc.Any(pl => pl.MaHS == hs.MaHS));
            gcHocSinh.DataSource = lstHocSinh.ToList();
            gvHocSinh.OptionsBehavior.Editable = false;
        }

        private void btnCapNhat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            showHide(false);
            btnXoaHS.Enabled = false;
        }

        private void btnLuu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            showHide(true);
            for (int i = 0; i < gvHocSinh.RowCount; i++)
            {
                if (gvHocSinh.IsRowSelected(i))
                {
                    tb_HocSinh_Lop_NamHoc hs = new tb_HocSinh_Lop_NamHoc();
                    hs.MaNamHoc = int.Parse(cboNamHoc.SelectedValue.ToString());
                    hs.MaLop = int.Parse(cboLop.SelectedValue.ToString());
                    hs.MaKhoiLop = int.Parse(cboKhoiLop.SelectedValue.ToString());
                    hs.MaHS = int.Parse(gvHocSinh.GetRowCellValue(i, "MaHS").ToString());
                    _phanlop.Add(hs);
                }
            }
            loadPhanLop();
            loadHocSinh();
        }

        private void btnHuy_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            showHide(true);
            btnXoaHS.Enabled = false;
        }

        private void btnDong_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            showHide(true);
            if (btnXoaHS.Enabled == true)
            {
                btnXoaHS.Enabled = false;
            }
            else
            {
                btnXoaHS.Enabled = true;
            }
            if (gvHocSinhLop.RowCount > 0)
            {
                gvHocSinhLop.FocusedRowHandle = 0;
            }

            _id = int.Parse(gvHocSinhLop.GetFocusedRowCellValue("MaHS").ToString());
            Console.WriteLine(_id);
        }

        private void btnXoaHS_Click(object sender, EventArgs e)
        {
            if (gvHocSinhLop.RowCount > 0)
            {
                gvHocSinhLop.FocusedRowHandle = 0;
                _id = int.Parse(gvHocSinhLop.GetFocusedRowCellValue("MaHS").ToString());
                Console.WriteLine("ID" + _id);
                if (MessageBox.Show("Bạn Có Chắc Xóa ?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    _phanlop.Delete(_id);
                }
            }

            loadPhanLop();
            loadHocSinh();
        }

        private void gvHocSinhLop_Click(object sender, EventArgs e)
        {
            if (gvHocSinhLop.RowCount > 0)
            {
                _id = int.Parse(gvHocSinhLop.GetFocusedRowCellValue("MaHS").ToString());
                Console.WriteLine(_id);
            }
        }

        private void gvHocSinhLop_CustomDrawCell(object sender, DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventArgs e)
        {
            if (e.Column.Name == "GioiTinhLop")
            {
                if (int.Parse(e.CellValue.ToString()) == 0)
                {
                    e.DisplayText = "Nữ";
                }
                else
                {
                    e.DisplayText = "Nam";
                }
            }
        }

        private void gvHocSinh_CustomDrawCell(object sender, DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventArgs e)
        {
            if (e.Column.Name == "GioiTinh")
            {
                if (int.Parse(e.CellValue.ToString()) == 0)
                {
                    e.DisplayText = "Nữ";
                }
                else
                {
                    e.DisplayText = "Nam";
                }
            }
        }
    }
}