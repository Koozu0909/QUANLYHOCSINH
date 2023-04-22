using BussinessLayer;
using DataLayer;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace QUANLYHOCSINH
{
    public partial class frmNamHoc : DevExpress.XtraEditors.XtraForm
    {
        public frmNamHoc()
        {
            InitializeComponent();
        }

        private bool _them;
        private NAMHOC _namhoc;
        private int _id;

        private void frmNamHoc_Load(object sender, EventArgs e)
        {
            showHide(true);
            _namhoc = new NAMHOC();
            loadData();
        }

        private void loadData()
        {
            _namhoc = new NAMHOC();
            gcDanhSach.DataSource = _namhoc.getList();
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
            txtNamHoc.Enabled = !kt;
        }

        private void btnThem_ItemClick_1(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
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
                _namhoc.Delete(_id, All_Func.UserStatic.UID);
            }
            loadData();
        }

        private void btnLuu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (txtNamHoc.Text != "")
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
                tb_NamHoc nh = new tb_NamHoc();
                nh.TenNamHoc = txtNamHoc.Text;
                nh.CreateBy = All_Func.UserStatic.UID;
                nh.CreateDate = DateTime.Now;
                _namhoc.Add(nh);
            }
            else
            {
                tb_NamHoc nh = _namhoc.getItem(_id);
                nh.TenNamHoc = txtNamHoc.Text;
                nh.CreateBy = All_Func.UserStatic.UID;
                nh.CreateDate = DateTime.Now;
                _namhoc.Update(nh);
            }
        }

        private void gvDanhSach_Click(object sender, EventArgs e)
        {
            if (gvDanhSach.RowCount > 0)
            {
                _id = int.Parse(gvDanhSach.GetFocusedRowCellValue("MaNamHoc").ToString());
                txtNamHoc.Text = gvDanhSach.GetFocusedRowCellValue("TenNamHoc").ToString();
            }
        }

        private void gvDanhSach_CustomDrawCell(object sender, DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventArgs e)
        {
            if (e.Column.Name == "DeleteBy" && e.CellValue != null)
            {
                Image img = Properties.Resources.Cancel_32x32;
                e.Graphics.DrawImage(img, e.Bounds.X, e.Bounds.Y, 15, 15);
                e.Handled = true;
            }
        }
    }
}