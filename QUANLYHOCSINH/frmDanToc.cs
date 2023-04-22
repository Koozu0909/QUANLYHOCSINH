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
    public partial class frmDanToc : DevExpress.XtraEditors.XtraForm
    {
        public frmDanToc()
        {
            InitializeComponent();
        }
        private bool _them;
        private DANTOC _dantoc;
        private int _id;
        private void frmDanToc_Load(object sender, EventArgs e)
        {
            showHide(true);
            _dantoc = new DANTOC();
            loadData();
        }

        private void loadData()
        {
            _dantoc = new DANTOC();
            gcDanhSach.DataSource = _dantoc.getList();
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
            txtDanToc.Enabled = !kt;
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
                _dantoc.Delete(_id, All_Func.UserStatic.UID);
            }
            loadData();
        }

        private void btnLuu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (txtDanToc.Text != "")
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
                tb_DanToc dt = new tb_DanToc();
                dt.TenDanToc = txtDanToc.Text;
                _dantoc.Add(dt);
            }
            else
            {
                tb_DanToc dt = _dantoc.getItem(_id);
                dt.TenDanToc = txtDanToc.Text;
                _dantoc.Update(dt);
            }
        }
        private void gvDanhSach_Click(object sender, EventArgs e)
        {
            if (gvDanhSach.RowCount > 0)
            {
                _id = int.Parse(gvDanhSach.GetFocusedRowCellValue("MaDanToc").ToString());
                txtDanToc.Text = gvDanhSach.GetFocusedRowCellValue("TenDanToc").ToString();
            }
        }

        private void txtTimkiem_TextChanged(object sender, EventArgs e)
        {
            string searchText = txtTimkiem.Text;
            _dantoc = new DANTOC();
            gcDanhSach.DataSource = _dantoc.SearchByName(searchText);
            gvDanhSach.OptionsBehavior.Editable = false;
        }
    }
}