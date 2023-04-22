using BussinessLayer;
using DataLayer;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace QUANLYHOCSINH
{
    public partial class frmMonHoc : DevExpress.XtraEditors.XtraForm
    {
        public frmMonHoc()
        {
            InitializeComponent();
        }

        private bool _them;
        private MONHOC _monhoc;
        private int _id;

        private void frmMonHoc_Load(object sender, EventArgs e)
        {
            showHide(true);
            _monhoc = new MONHOC();
            loadData();
        }

        private void loadData()
        {
            _monhoc = new MONHOC();
            gcDanhSach.DataSource = _monhoc.getList();
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
            txtTenMonHoc.Enabled = !kt;
            spinHeSo.Enabled = !kt;
            spinSoTiet.Enabled = !kt;
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
                _monhoc.Delete(_id, All_Func.UserStatic.UID);
            }
            loadData();
        }

        private void btnLuu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (txtTenMonHoc.Text != " " && int.Parse(spinSoTiet.Text) != 0 && int.Parse(spinHeSo.Text) != 0)
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
                tb_MonHoc mh = new tb_MonHoc();
                mh.TenMH = txtTenMonHoc.Text;
                mh.SoTiet = int.Parse(spinSoTiet.Text);
                mh.HeSo = int.Parse(spinHeSo.Text);
                mh.CreateBy = All_Func.UserStatic.UID;
                mh.CreateDate = DateTime.Now;
                _monhoc.Add(mh);
            }
            else
            {
                tb_MonHoc mh = _monhoc.getItem(_id);
                mh.TenMH = txtTenMonHoc.Text;
                mh.SoTiet = int.Parse(spinSoTiet.Text);
                mh.HeSo = int.Parse(spinHeSo.Text);
                mh.UpdateBy = All_Func.UserStatic.UID;
                mh.UpdateDate = DateTime.Now;
                _monhoc.Update(mh);
            }
        }

        private void gvDanhSach_Click(object sender, EventArgs e)
        {
            if (gvDanhSach.RowCount > 0)
            {
                _id = int.Parse(gvDanhSach.GetFocusedRowCellValue("MaMH").ToString());
                txtTenMonHoc.Text = gvDanhSach.GetFocusedRowCellValue("TenMH").ToString();
                spinSoTiet.Text = gvDanhSach.GetFocusedRowCellValue("SoTiet").ToString();
                spinHeSo.Text = gvDanhSach.GetFocusedRowCellValue("HeSo").ToString();
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

        private void gcDanhSach_Click(object sender, EventArgs e)
        {
        }

        private void barDockControlTop_Click(object sender, EventArgs e)
        {
        }

        private void barDockControlBottom_Click(object sender, EventArgs e)
        {
        }

        private void barDockControlLeft_Click(object sender, EventArgs e)
        {
        }

        private void barDockControlRight_Click(object sender, EventArgs e)
        {
        }

        private void splitContainer1_SplitterMoved(object sender, SplitterEventArgs e)
        {
        }

        private void spinHeSo_EditValueChanged(object sender, EventArgs e)
        {
        }

        private void labelControl3_Click(object sender, EventArgs e)
        {
        }

        private void spinSoTiet_EditValueChanged(object sender, EventArgs e)
        {
        }

        private void labelControl2_Click(object sender, EventArgs e)
        {
        }

        private void txtTenMonHoc_EditValueChanged(object sender, EventArgs e)
        {
        }

        private void labelControl1_Click(object sender, EventArgs e)
        {
        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}