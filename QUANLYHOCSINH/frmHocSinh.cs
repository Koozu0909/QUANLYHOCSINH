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
using QUANLYHOCSINH.Reports;
using DevExpress.XtraPrinting.Preview;
using DevExpress.XtraReports.UI;

namespace QUANLYHOCSINH
{
    public partial class frmHocSinh : DevExpress.XtraEditors.XtraForm
    {
        public frmHocSinh()
        {
            InitializeComponent();
        }
        private bool _them;
        private HOCSINH _hocsinh;
        private DANTOC _dantoc;
        private TONGIAO _tongiao;
        private int _id;
        private int gioitinh = 0;
        private bool sreach = false;
        private void frmHocSinh_Load(object sender, EventArgs e)
        {
            showHide(true);
            _hocsinh = new HOCSINH();
            _dantoc = new DANTOC();
            _tongiao = new TONGIAO();
            loadDanToc();
            loadTonGiao();
            loadData();
            txtTimkiem.Enabled = sreach;
        }
        private void loadData()
        {
            _hocsinh = new HOCSINH();
            gcDanhSach.DataSource = _hocsinh.getList();
            gvDanhSach.OptionsBehavior.Editable = false;
        }
        private void txtTimkiem_TextChanged(object sender, EventArgs e)
        {
            string searchText = txtTimkiem.Text;
            _hocsinh = new HOCSINH();
            gcDanhSach.DataSource = _hocsinh.SearchByName(searchText);
            gvDanhSach.OptionsBehavior.Editable = false;
        }
        private void loadDanToc()
        {
            cboDanToc.DataSource = _dantoc.getList();
            cboDanToc.DisplayMember = "TenDanToc";
            cboDanToc.ValueMember = "MaDanToc";
        }
        private void loadTonGiao()
        {
            cboTonGiao.DataSource = _tongiao.getList();
            cboTonGiao.DisplayMember = "TentonGiao";
            cboTonGiao.ValueMember = "MaTonGiao";
        }

        private void reset()
        {
            txtDiaChi.Text = "";
            txtDienThoai.Text = "";
            txtGhichu.Text = "";
            txtHoTen.Text = "";
            cbGioiTinh.Checked = true;
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
            txtDiaChi.Enabled = !kt;
            txtHoTen.Enabled = !kt;
            txtDienThoai.Enabled = !kt;
            txtGhichu.Enabled = !kt;
            cbGioiTinh.Enabled = !kt;
            cboDanToc.Enabled = !kt;
            cboTonGiao.Enabled = !kt;
            dtNgaySinh.Enabled = !kt;
        }
        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            reset();
            showHide(false);
            _them = true;
        }
        private void btnSreach_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (!sreach)
            { 
                sreach = true;
                txtTimkiem.Enabled = sreach;
            }
            else
            {
                sreach = false;
                txtTimkiem.Enabled = sreach;
            }

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
                _hocsinh.Delete(_id, All_Func.UserStatic.UID);
            }
            loadData();
        }

        private void btnLuu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            saveData();
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
            HocSinh_rep report = new HocSinh_rep();
            DocumentViewer documentViewer = new DocumentViewer();
            report.InitData(_hocsinh.getList());
            documentViewer.DocumentSource = report;
            report.ShowPreviewDialog();
        }

        private void btnDong_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void saveData()
        {
            if (_them)
            {
                tb_HocSinh hs = new tb_HocSinh();
                hs.HoTen = txtHoTen.Text;
                hs.GioiTinh = gioitinh;
                int index = hs.HoTen.LastIndexOf(" ");
                hs.Ten = hs.HoTen.Substring(index + 1);
                hs.NgaySinh = dtNgaySinh.Value;
                hs.GhiChu = txtGhichu.Text;
                hs.DienThoai = txtDienThoai.Text;
                hs.DiaChi = txtDiaChi.Text;
                hs.MaDanToc = int.Parse(cboDanToc.SelectedValue.ToString());
                hs.MaTonGiao = int.Parse(cboTonGiao.SelectedValue.ToString());
                hs.CreateBy = All_Func.UserStatic.UID;
                hs.CreateDate = DateTime.Now;
                _hocsinh.Add(hs);
            }
            else
            {
                tb_HocSinh hs = _hocsinh.getItem(_id);
                hs.HoTen = txtHoTen.Text;
                int index = hs.HoTen.LastIndexOf(" ");
                hs.Ten = hs.HoTen.Substring(index + 1);
                hs.GioiTinh = gioitinh;
                hs.NgaySinh = dtNgaySinh.Value;
                hs.GhiChu = txtGhichu.Text;
                hs.DienThoai = txtDienThoai.Text;
                hs.DiaChi = txtDiaChi.Text;
                hs.MaDanToc = int.Parse(cboDanToc.SelectedValue.ToString());
                hs.MaTonGiao = int.Parse(cboTonGiao.SelectedValue.ToString());
                hs.UpdateBy = All_Func.UserStatic.UID;
                hs.UpdateDate = DateTime.Now;
                _hocsinh.Update(hs);
            }
        }

            private void cbGioiTinh_CheckedChanged(object sender, EventArgs e)
            {
                if (cbGioiTinh.Checked)
                {
                    gioitinh = 1;
                Console.WriteLine(gioitinh);
                }
                else
                {
                    gioitinh = 0;
                Console.WriteLine(gioitinh);

            }
        }
        

        private void gvDanhSach_Click(object sender, EventArgs e)
        {
            if (gvDanhSach.RowCount > 0)
            {
                _id = int.Parse(gvDanhSach.GetFocusedRowCellValue("MaHS").ToString());
                var hs = _hocsinh.getItem(_id);
                txtHoTen.Text = hs.HoTen;
                txtDienThoai.Text = hs.DienThoai;
                txtDiaChi.Text = hs.DiaChi;
                txtGhichu.Text = hs.GhiChu;
                dtNgaySinh.Value = hs.NgaySinh.Value;
                cboTonGiao.SelectedValue = hs.MaTonGiao;
                cboDanToc.SelectedValue = hs.MaDanToc;
                if (hs.GioiTinh == 1)
                {
                    cbGioiTinh.Checked = true;

                }
                else
                {
                    cbGioiTinh.Checked = false;

                }
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

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}