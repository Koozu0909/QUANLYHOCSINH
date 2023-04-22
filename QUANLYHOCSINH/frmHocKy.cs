using BussinessLayer;
using DataLayer;
using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace QUANLYHOCSINH
{
    public partial class frmHocKy : DevExpress.XtraEditors.XtraForm
    {
        public frmHocKy()
        {
            InitializeComponent();
        }

        private bool _them;
        private HOCKY _hocky;
        private NAMHOC _namhoc;
        private int _id;

        private void frmHocKy_Load(object sender, EventArgs e)
        {
            showHide(true);
            _hocky = new HOCKY();
            _namhoc = new NAMHOC();
            loadNamHoc();
            loadData();
          
        }
        private void loadNamHoc()
        {
            cboNamHoc.DataSource = _namhoc.getList();
            cboNamHoc.DisplayMember = "TenNamHoc";
            cboNamHoc.ValueMember = "MaNamHoc";
        }
        private void loadData()
        {
            _hocky = new HOCKY();
            int maNamHoc;
            if (int.TryParse(cboNamHoc.SelectedValue.ToString(), out maNamHoc))
            {
                gcDanhSach.DataSource = _hocky.getList(maNamHoc);
                gvDanhSach.OptionsBehavior.Editable = false;
            }
            else
            {
                // Không làm gì nếu giá trị được chọn không phải là một chuỗi số hợp lệ
            }

        }
        private void cboNamHoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadData();
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
            txtHocKy.Enabled = !kt;
            spinHeSo.Enabled = !kt;
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
                _hocky.Delete(_id, All_Func.UserStatic.UID);
            }
            loadData();
        }

        private void btnLuu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (txtHocKy.Text != " " && int.Parse(spinHeSo.Text) != 0)
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
                tb_HocKy hk = new tb_HocKy();
                hk.TenHocKy = txtHocKy.Text;
                hk.HeSo = int.Parse(spinHeSo.Text);
                hk.MaNamHoc = int.Parse(cboNamHoc.SelectedValue.ToString());
                hk.CreateBy = All_Func.UserStatic.UID;
                hk.CreateDate = DateTime.Now;
                _hocky.Add(hk);
            }
            else
            {
                tb_HocKy hk = _hocky.getItem(_id);
                hk.TenHocKy = txtHocKy.Text;
                hk.HeSo = int.Parse(spinHeSo.Text);
                hk.MaNamHoc = int.Parse(cboNamHoc.SelectedValue.ToString());
                hk.CreateBy = All_Func.UserStatic.UID;
                hk.CreateDate = DateTime.Now;
                _hocky.Update(hk);
            }
        }

        private void gvDanhSach_Click(object sender, EventArgs e)
        {
            if (gvDanhSach.RowCount > 0)
            {
                _id = int.Parse(gvDanhSach.GetFocusedRowCellValue("MaHocKy").ToString());
                var hk = _hocky.getItem(_id);
                txtHocKy.Text = gvDanhSach.GetFocusedRowCellValue("TenHocKy").ToString();
                spinHeSo.Text = gvDanhSach.GetFocusedRowCellValue("HeSo").ToString();
                cboNamHoc.SelectedValue = hk.MaNamHoc;
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

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {
        }

        private void txtHocKy_EditValueChanged(object sender, EventArgs e)
        {
        }

        private void labelControl6_Click(object sender, EventArgs e)
        {

        }
    }
}