using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataLayer;
using BussinessLayer;
using BussinessLayer.DTO;

namespace QUANLYHOCSINH
{
    public partial class PhanLop_GV : DevExpress.XtraEditors.XtraForm
    {
        public PhanLop_GV()
        {
            InitializeComponent();
        }
        private QUANLYHOCSINHEntities db = new QUANLYHOCSINHEntities();

        private NAMHOC _namhoc;
        private KHOILOP _khoilop;
        private LOPHOC _lophoc;
        private MONHOC _monhoc;
        private GIAOVIEN_LOP _giaovien_lop;
        private HOCKY _hocky;
        private GIAOVIEN _giaovien;
        private int _idGV;
        private int _idGV_Lop;
        private bool _them;
        private int chunhiem = 0;

        private void frmPhanLop_GV_Load(object sender, EventArgs e)
        {
            _namhoc = new NAMHOC();
            _khoilop = new KHOILOP();
            _lophoc = new LOPHOC();
            _monhoc = new MONHOC();
            _giaovien_lop = new GIAOVIEN_LOP();
            _hocky = new HOCKY();
            _giaovien = new GIAOVIEN();
            loadData();
            loadGV();
            showHide(true);
            btnXoaGV.Enabled = false;
            if (gvGiaoVienLop.RowCount > 0)
            {
                _idGV_Lop = int.Parse(gvGiaoVienLop.GetFocusedRowCellValue("MaGV_Lop").ToString());
                Console.WriteLine(_idGV_Lop);
                var gv = _giaovien_lop.getItem(_idGV_Lop);
            }
            if (gvGiaoVien.RowCount > 0)
            {
                _idGV = int.Parse(gvGiaoVien.GetFocusedRowCellValue("MaGV").ToString());
                Console.WriteLine(_idGV);
            }
        }
      
        private void showHide(bool kt)
        {
            btnLuu.Enabled = !kt;
            btnHuy.Enabled = !kt;
            btnThem.Enabled = kt;
            btnSua.Enabled = kt;
            btnXoa.Enabled = kt;
            btnDong.Enabled = kt;
            gcGiaoVien.Enabled = !kt;

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
            loadGV_Lop();
        }

        private void loadGV()
        {
            var lstGV = _giaovien.getList();
            gcGiaoVien.DataSource = lstGV.ToList();
            gvGiaoVien.OptionsBehavior.Editable = false;
        }
        private void loadGV_Lop()
        {
            int namHoc;
            int lop;
            int hocky;
            if (cboNamHoc.SelectedValue != null && cboLop.SelectedValue != null && cboHocKy.SelectedValue != null)
            {
                if (int.TryParse(cboNamHoc.SelectedValue.ToString(), out namHoc) && int.TryParse(cboLop.SelectedValue.ToString(), out lop) && int.TryParse(cboHocKy.SelectedValue.ToString(), out hocky))
                {
                    var lstGV = _giaovien_lop.getListBy(namHoc, lop, hocky);
                    bool hasChuNhiem = lstGV.Any(gv => gv.ChuNhiem == 1); // Kiểm tra xem có bản ghi nào có ChuNhiem = 1 không
                    gcGiaoVienLop.DataSource = lstGV.ToList();
                    gvGiaoVienLop.OptionsBehavior.Editable = false;
                    if (hasChuNhiem)
                    {
                        cbChuNhiem.Enabled = !hasChuNhiem;
                        cbChuNhiem.Checked = false;
                    }
                    else
                    {
                        cbChuNhiem.Enabled = hasChuNhiem;
                    }

                }
                else
                {
                    // Handle the case where the parsing failed
                }
            }
            else
            {
                // Handle the case where SelectedValue is null
            }

        }
        private void gvGiaoVien_CustomDrawCell(object sender, DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventArgs e)
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

        private void txtGiaoVien_TextChanged(object sender, EventArgs e)
        {
           
                string searchText = txtGiaoVien.Text;
                _giaovien = new GIAOVIEN();
                gcGiaoVien.DataSource = _giaovien.SearchByName(searchText);
                gvGiaoVien.OptionsBehavior.Editable = false;
            
        }
        private void cboHocKy_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadGV_Lop();
        }
        private void cboLop_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadGV_Lop();
        }

        private void cboKhoiLop_SelectedIndexChanged(object sender, EventArgs e)
        {
            int maKhoiLop;
            if (int.TryParse(cboKhoiLop.SelectedValue.ToString(), out maKhoiLop))
            {
                cboLop.DataSource = _lophoc.getList(maKhoiLop);
                cboLop.DisplayMember = "TenLop";
                cboLop.ValueMember = "MaLop";
                loadGV_Lop();
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
                loadGV_Lop();
            }
            else
            {
                // Không làm gì nếu giá trị được chọn không phải là một chuỗi số hợp lệ
            }
        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (gvGiaoVienLop.RowCount > 0)
            {
                _idGV_Lop = int.Parse(gvGiaoVienLop.GetFocusedRowCellValue("MaGV_Lop").ToString());
                Console.WriteLine(_idGV_Lop);
                var gv = _giaovien_lop.getItem(_idGV_Lop);
            }
            if (gvGiaoVien.RowCount > 0)
            {
                _idGV = int.Parse(gvGiaoVien.GetFocusedRowCellValue("MaGV").ToString());
                Console.WriteLine(_idGV);
            }
            showHide(false);
            cbChuNhiem.Enabled = true;
            cbChuNhiem.Checked = false;
            _them = true;
        }

        private void btnSua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (gvGiaoVienLop.RowCount > 0)
            {
                _idGV_Lop = int.Parse(gvGiaoVienLop.GetFocusedRowCellValue("MaGV_Lop").ToString());
                Console.WriteLine(_idGV_Lop);
                var gv = _giaovien_lop.getItem(_idGV_Lop);
            }
            if (gvGiaoVien.RowCount > 0)
            {
                _idGV = int.Parse(gvGiaoVien.GetFocusedRowCellValue("MaGV").ToString());
                Console.WriteLine(_idGV);
            }
            showHide(false);
            _them = false;
            cbChuNhiem.Enabled = true;
            cbChuNhiem.Checked = false;
        }

        private void btnDong_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();

        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            showHide(true);
            if (btnXoaGV.Enabled == true)
            {
                btnXoaGV.Enabled = false;
            }
            else
            {
                btnXoaGV.Enabled = true;
            }
            if (gvGiaoVienLop.RowCount > 0)
            {
                gvGiaoVienLop.FocusedRowHandle = 0;
            }

            _idGV_Lop = int.Parse(gvGiaoVienLop.GetFocusedRowCellValue("MaGV_Lop").ToString());
            Console.WriteLine(_idGV_Lop);
        }

        private void btnHuy_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            showHide(true);
            _them = false;
            btnXoaGV.Enabled = false;
            cbChuNhiem.Enabled = false;
        }

        private void btnLuu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            showHide(true);
            saveData();
            loadGV_Lop();
            cbChuNhiem.Enabled = false;


        }
        private void saveData()
        {
            if (_them)
            {
                tb_GiaoVien_Lop gv = new tb_GiaoVien_Lop();
                gv.ChuNhiem = chunhiem;
                gv.MaGV = _idGV;
                gv.MaHocKy = int.Parse(cboHocKy.SelectedValue.ToString()); ;
                gv.MaLop = int.Parse(cboLop.SelectedValue.ToString());
                gv.MaMH = int.Parse(cboMonHoc.SelectedValue.ToString());
                gv.MaNamHoc = int.Parse(cboNamHoc.SelectedValue.ToString());
                _giaovien_lop.Add(gv);
            }
            else
            {
                tb_GiaoVien_Lop gv = _giaovien_lop.getItem(_idGV_Lop);
                gv.ChuNhiem = chunhiem;
                gv.MaGV = _idGV;
                gv.MaHocKy = int.Parse(cboHocKy.SelectedValue.ToString()); ;
                gv.MaLop = int.Parse(cboLop.SelectedValue.ToString());
                gv.MaMH = int.Parse(cboMonHoc.SelectedValue.ToString());
                gv.MaNamHoc = int.Parse(cboNamHoc.SelectedValue.ToString());
                _giaovien_lop.Update(gv);
            }
        }

        private void cbChuNhiem_CheckedChanged(object sender, EventArgs e)
        {
            if (cbChuNhiem.Checked)
            {
                chunhiem = 1;
            }
            else
            {
                chunhiem = 0;
            }
        }

        private void gvGiaoVien_Click(object sender, EventArgs e)
        {
            if (gvGiaoVien.RowCount > 0)
            {
                _idGV = int.Parse(gvGiaoVien.GetFocusedRowCellValue("MaGV").ToString());
                Console.WriteLine(_idGV);
            }
        }

        private void gvGiaoVienLop_Click(object sender, EventArgs e)
        {
            if (gvGiaoVienLop.RowCount > 0)
            {
                _idGV_Lop = int.Parse(gvGiaoVienLop.GetFocusedRowCellValue("MaGV_Lop").ToString());
                Console.WriteLine(_idGV_Lop);
                var gv = _giaovien_lop.getItem(_idGV_Lop);
            }
        }

        private void gvGiaoVienLop_CustomDrawCell(object sender, DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventArgs e)
        {
            if (e.Column.Name == "ChuNhiem")
            {
                if (int.Parse(e.CellValue.ToString()) == 1)
                {
                    e.DisplayText = "Chủ Nhiệm";
                }
                else
                {
                    e.DisplayText = " ";
                }
            }
        }

        private void btnXoaGV_Click(object sender, EventArgs e)
        {
            if (gvGiaoVienLop.RowCount > 0)
            {
                gvGiaoVienLop.FocusedRowHandle = 0;
                _idGV_Lop = int.Parse(gvGiaoVienLop.GetFocusedRowCellValue("MaGV_Lop").ToString());
                Console.WriteLine("ID" + _idGV_Lop);
                if (MessageBox.Show("Bạn Có Chắc Xóa ?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    _giaovien_lop.Delete(_idGV_Lop);
                }
            }

            loadGV_Lop();
        }
    }
}