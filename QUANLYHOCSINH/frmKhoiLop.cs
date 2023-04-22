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

namespace QUANLYHOCSINH
{
    public partial class frmKhoiLop : DevExpress.XtraEditors.XtraForm
    {
        public frmKhoiLop()
        {
            InitializeComponent();
        }
        private bool _them;
        private KHOILOP _khoilop;
        private int _id;
        private void frmKhoiLop_Load(object sender, EventArgs e)
        {
            showHide(true);
            _khoilop = new KHOILOP();
            loadData();
        }


        private void loadData()
        {
            _khoilop = new KHOILOP();
            gcDanhSach.DataSource = _khoilop.getList();
            gvDanhSach.OptionsBehavior.Editable = false;
        }

        private void showHide(bool kt)
        {
            btnLuu.Enabled = !kt;
            btnHuy.Enabled = !kt;
            btnThem.Enabled = kt;
            btnSua.Enabled = kt;
            btnXoa.Enabled = kt;
            btnDong.Enabled = kt;
            btnIn.Enabled = kt;
            txtKhoiLop.Enabled = !kt;
        }
        private void gvDanhSach_Click(object sender, EventArgs e)
        {
            if (gvDanhSach.RowCount > 0)
            {
                _id = int.Parse(gvDanhSach.GetFocusedRowCellValue("MaKhoiLop").ToString());
                txtKhoiLop.Text = gvDanhSach.GetFocusedRowCellValue("TenKhoiLop").ToString();
            }
        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            showHide(false);
            _them = true;
        }

        private void btnSua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            showHide(false);
            _them = false;
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (MessageBox.Show("Bạn Có Chắc Xóa ?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                _khoilop.Delete(_id, All_Func.UserStatic.UID);
            }
            loadData();
        }

        private void btnLuu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (txtKhoiLop.Text != "")
            {
                saveData();
                showHide(true);
                loadData();
            }
            else
            {
                MessageBox.Show("Nhập đầy đủ thông tin", "Thông Báo", MessageBoxButtons.OK);
            }
        }

        private void btnHuy_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            showHide(true);
            _them = false;
        }

        private void btnIn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void btnDong_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }
        private void saveData()
        {
            if (_them)
            {
                tb_KhoiLop cv = new tb_KhoiLop();
                cv.TenKhoiLop = txtKhoiLop.Text;
                _khoilop.Add(cv);
            }
            else
            {
                tb_KhoiLop cv = _khoilop.getItem(_id);
                cv.TenKhoiLop = txtKhoiLop.Text;
                _khoilop.Update(cv);
            }
        }
        private void gvDanhSach_CustomDrawCell(object sender, DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventArgs e)
        {

        }
    }
}