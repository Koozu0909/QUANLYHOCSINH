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
    public partial class frmPhanMon : DevExpress.XtraEditors.XtraForm
    {
        public frmPhanMon()
        {
            InitializeComponent();
        }
        private GIAOVIEN _giaovien;
        private GIAOVIEN_MONHOC _giaovien_mh;
        private NAMHOC _namhoc;
        private MONHOC _monhoc;
        private bool _them;
        private int _idGv;
        private int _idGv_Mh;

        private void frmPhanMon_Load(object sender, EventArgs e)
        {
            _giaovien = new GIAOVIEN();
            _giaovien_mh = new GIAOVIEN_MONHOC();
            _namhoc = new NAMHOC();
            _monhoc = new MONHOC();
            loadData();
            loadGV_MH();
            showHide(true);
            btnXoaGV.Enabled = false;
        }

        private void showHide(bool kt)
        {
            btnLuu.Enabled = !kt;
            btnHuy.Enabled = !kt;
            btnThem.Enabled = kt;
            btnChange.Enabled = kt;
            btnXoa.Enabled = kt;
            btnExit.Enabled = kt;
            txtGhiChu.Enabled = !kt;
            gcGiaoVien.Enabled = !kt;
            gcGiaoVienMH.Enabled = kt;


        }
        private void loadData()
        {
            cboNamHoc.DataSource = _namhoc.getList();
            cboNamHoc.DisplayMember = "TenNamHoc";
            cboNamHoc.ValueMember = "MaNamHoc";

            cboMonHoc.DataSource = _monhoc.getList();
            cboMonHoc.DisplayMember = "TenMH";
            cboMonHoc.ValueMember = "MaMH";

            var lstGV = _giaovien.getList();
            gcGiaoVien.DataSource = lstGV.ToList();
            gvGiaoVien.OptionsBehavior.Editable = false;
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

        private void loadGV_MH()
        {
            int namHoc;
            int monhoc;
            if (cboNamHoc.SelectedValue != null && cboMonHoc.SelectedValue != null)
            {
                if (int.TryParse(cboNamHoc.SelectedValue.ToString(), out namHoc) && int.TryParse(cboMonHoc.SelectedValue.ToString(), out monhoc))
                {
                    var lstGV = _giaovien_mh.getList(namHoc, monhoc);
                    gcGiaoVienMH.DataSource = lstGV.ToList();
                    gvGiaoVienMH.OptionsBehavior.Editable = false;
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
        private void txtGiaoVien_TextChanged(object sender, EventArgs e)
        {
            string searchText = txtGiaoVien.Text;
            _giaovien = new GIAOVIEN();
            gcGiaoVien.DataSource = _giaovien.SearchByName(searchText);
            gvGiaoVien.OptionsBehavior.Editable = false;
        }

        private void cboNamHoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadGV_MH();
        }

        private void cboMonHoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadGV_MH();

        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (gvGiaoVien.RowCount > 0)
            {
                _idGv = int.Parse(gvGiaoVien.GetFocusedRowCellValue("MaGV").ToString());
                Console.WriteLine(_idGv);
            }
            showHide(false);
            _them = true;
        }

        private void btnChange_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (gvGiaoVien.RowCount > 0)
            {
                _idGv = int.Parse(gvGiaoVien.GetFocusedRowCellValue("MaGV").ToString());
                Console.WriteLine(_idGv);
            }
            if (gvGiaoVienMH.RowCount > 0)
            {
                _idGv_Mh = int.Parse(gvGiaoVienMH.GetFocusedRowCellValue("MaGV_MH").ToString());
                Console.WriteLine(_idGv_Mh);
            }
            showHide(false);
            gcGiaoVien.Enabled = true;
            gcGiaoVienMH.Enabled = true;
            _them = false;
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
            if (gvGiaoVienMH.RowCount > 0)
            {
                gvGiaoVienMH.FocusedRowHandle = 0;
            }

            _idGv_Mh = int.Parse(gvGiaoVienMH.GetFocusedRowCellValue("MaGV_MH").ToString());
            Console.WriteLine(_idGv_Mh);
        }
        private void btnXoaGV_Click(object sender, EventArgs e)
        {
            if (gvGiaoVienMH.RowCount > 0)
            {
                gvGiaoVienMH.FocusedRowHandle = 0;
                _idGv_Mh = int.Parse(gvGiaoVienMH.GetFocusedRowCellValue("MaGV_MH").ToString());
                Console.WriteLine("ID" + MaGV_MH);
                if (MessageBox.Show("Bạn Có Chắc Xóa ?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    _giaovien_mh.Delete(_idGv_Mh);
                }
            }

            loadGV_MH();
        }
        private void btnHuy_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            showHide(true);
            _them = false;
        }

        private void btnLuu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            showHide(true);
            saveData();
            loadGV_MH();
        }

        private void btnExit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();

        }
        private void saveData()
        {
            if (_them)
            {
                tb_GiaoVien_MonHoc gv = new tb_GiaoVien_MonHoc();
                gv.MaGV = _idGv;
                gv.MaMH = int.Parse(cboMonHoc.SelectedValue.ToString());
                gv.MaNamHoc = int.Parse(cboNamHoc.SelectedValue.ToString());
                gv.GhiChu = txtGhiChu.Text;
                _giaovien_mh.Add(gv);
            }
            else
            {
                tb_GiaoVien_MonHoc gv = _giaovien_mh.getItem(_idGv_Mh);
                gv.MaGV = _idGv;
                gv.MaMH = int.Parse(cboMonHoc.SelectedValue.ToString());
                gv.MaNamHoc = int.Parse(cboNamHoc.SelectedValue.ToString());
                gv.GhiChu = txtGhiChu.Text;
                _giaovien_mh.Update(gv);
            }
        }

        private void gvGiaoVien_Click(object sender, EventArgs e)
        {
            if (gvGiaoVien.RowCount > 0)
            {
                _idGv = int.Parse(gvGiaoVien.GetFocusedRowCellValue("MaGV").ToString());
                Console.WriteLine(_idGv);
            }
        }

        private void gvGiaoVienMH_Click(object sender, EventArgs e)
        {
            if (gvGiaoVienMH.RowCount > 0)
            {
                _idGv_Mh = int.Parse(gvGiaoVienMH.GetFocusedRowCellValue("MaGV_MH").ToString());
                Console.WriteLine(_idGv_Mh);
            }
        }

       
    }
}