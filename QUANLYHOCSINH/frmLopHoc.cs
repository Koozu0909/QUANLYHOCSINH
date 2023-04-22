using BussinessLayer;
using DataLayer;
using System;
using System.Linq;
using System.Windows.Forms;

namespace QUANLYHOCSINH
{
    public partial class frmLopHoc : DevExpress.XtraEditors.XtraForm
    {
        public frmLopHoc()
        {
            InitializeComponent();
        }

        private bool _them;
        private LOPHOC _lophoc;
        private KHOILOP _khoilop;
        private int _id;

        private void frmLopHoc_Load(object sender, EventArgs e)
        {
            showHide(true);
            _lophoc = new LOPHOC();
            _khoilop = new KHOILOP();
            loadKhoiLop();
            loadData();
        }
        private void loadKhoiLop()
        {
            var khoiLopList = _khoilop.getList();
                cboKhoiLop.DataSource = khoiLopList;
                cboKhoiLop.DisplayMember = "TenKhoiLop";
                cboKhoiLop.ValueMember = "MaKhoiLop";

        }
        private void loadData()
        {
            int maKhoiLop;
            if (int.TryParse(cboKhoiLop.SelectedValue.ToString(), out maKhoiLop))
            {
                gcDanhSach.DataSource = _lophoc.getList(maKhoiLop);
                gvDanhSach.OptionsBehavior.Editable = false;
            }
            else
            {
                // Không làm gì nếu giá trị được chọn không phải là một chuỗi số hợp lệ
            }
        }
        private void cboKhoiLop_SelectedIndexChanged(object sender, EventArgs e)
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
            txtGhiChu.Enabled = !kt;
            txtLopHoc.Enabled = !kt;
        }

        private void reset()
        {
            txtGhiChu.Text = "";
            txtLopHoc.Text = "";
        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            loadData();
            showHide(false);
            _them = true;
            reset();
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
                _lophoc.Delete(_id, All_Func.UserStatic.UID);
            }
            loadData();
        }

        private void btnLuu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            checkInput();
            showHide(true);
            loadData();
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

        private void checkInput()
        {
            int maKhoiLop;
            if (int.TryParse(cboKhoiLop.SelectedValue.ToString(), out maKhoiLop))
            {
                var lstLop = _lophoc.getList(maKhoiLop);
                if (lstLop.Any(x => x.TenLop.Equals(txtLopHoc.Text, StringComparison.OrdinalIgnoreCase)))
                {
                    MessageBox.Show("Tên lớp đã tồn tại trong khối lớp này!", "Thông báo");
                    return;
                }
                else
                {
                    saveData();

                }
            }
        }

        private void saveData()
        {
            if (_them)
            {
                tb_Lop lh = new tb_Lop();
                lh.TenLop = txtLopHoc.Text.ToUpper();
                lh.GhiChu = txtGhiChu.Text;
                lh.MaKhoiLop = int.Parse(cboKhoiLop.SelectedValue.ToString());
                lh.CreateBy = All_Func.UserStatic.UID;
                lh.CreateDate = DateTime.Now;
                _lophoc.Add(lh);
            }
            else
            {
                tb_Lop lh = _lophoc.getItem(_id);
                lh.TenLop = txtLopHoc.Text.ToUpper();
                lh.GhiChu = txtGhiChu.Text;
                lh.MaKhoiLop = int.Parse(cboKhoiLop.SelectedValue.ToString());
                lh.UpdateBy = All_Func.UserStatic.UID;
                lh.UpdateDate = DateTime.Now;
                _lophoc.Update(lh);
            }
        }

        private void gvDanhSach_Click(object sender, EventArgs e)
        {
            if (gvDanhSach.RowCount > 0)
            {
                _id = int.Parse(gvDanhSach.GetFocusedRowCellValue("MaLop").ToString());
                var lop = _lophoc.getItem(_id);
                txtLopHoc.Text = gvDanhSach.GetFocusedRowCellValue("TenLop").ToString();
                txtGhiChu.Text = gvDanhSach.GetFocusedRowCellValue("GhiChu").ToString();
                cboKhoiLop.SelectedValue = lop.MaKhoiLop;
            }
        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {
        }

        private void gcDanhSach_Click(object sender, EventArgs e)
        {
        }

        private void cboNamHoc_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void labelControl3_Click(object sender, EventArgs e)
        {
        }

        
    }
}