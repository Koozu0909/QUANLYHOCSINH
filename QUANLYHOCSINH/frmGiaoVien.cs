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
using System.IO;
using QUANLYHOCSINH.Reports;
using DevExpress.XtraPrinting.Preview;
using DevExpress.XtraReports.UI;

namespace QUANLYHOCSINH
{
    public partial class frmGiaoVien : DevExpress.XtraEditors.XtraForm
    {
        public frmGiaoVien()
        {
            InitializeComponent();
        }
        private bool _them;
        private GIAOVIEN _giaovien;
        private TRINHDO _trinhdo;
        private CHUCVU _chucvu;
        private int _id;
        private int gioitinh = 0;
        private bool sreach = false;
        private void frmGiaoVien_Load(object sender, EventArgs e)
        {
            showHide(true);
            _giaovien = new GIAOVIEN();
            _trinhdo = new TRINHDO();
            _chucvu = new CHUCVU();
            loadChucVu();
            loadTrinhDo();
            loadData();
            txtTimkiem.Enabled = sreach;
        }
        private void txtTimkiem_TextChanged(object sender, EventArgs e)
        {
            string searchText = txtTimkiem.Text;
            _giaovien = new GIAOVIEN();
            gcDanhSach.DataSource = _giaovien.SearchByName(searchText);
            gvDanhSach.OptionsBehavior.Editable = false;
        }
        private void loadData()
        {
            _giaovien = new GIAOVIEN();
            gcDanhSach.DataSource = _giaovien.getList();
            gvDanhSach.OptionsBehavior.Editable = false;
        }

        private void loadTrinhDo()
        {
            cboTrinhDo.DataSource = _trinhdo.getList();
            cboTrinhDo.DisplayMember = "TenTrinhDo";
            cboTrinhDo.ValueMember = "MaTrinhDo";
        }
        private void loadChucVu()
        {
            cboChucVu.DataSource = _chucvu.getList();
            cboChucVu.DisplayMember = "TenChucVu";
            cboChucVu.ValueMember = "MaChucVu";
        }
        private void reset()
        {
            txtDiaChi.Text = "";
            txtDienThoai.Text = "";
            txtEmail.Text = "";
            txtHoTen.Text = "";
            pictureEdit1.Image = Properties.Resources.No_Image;
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
            txtEmail.Enabled = !kt;
            cbGioiTinh.Enabled = !kt;
            cboChucVu.Enabled = !kt;
            cboTrinhDo.Enabled = !kt;
            dtNgaySinh.Enabled = !kt;
            btnThemAnh.Enabled = !kt;
        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            reset();
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
                _giaovien.Delete(_id, All_Func.UserStatic.UID);
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
            GiaoVien_rep report = new GiaoVien_rep();
            DocumentViewer documentViewer = new DocumentViewer();
            report.InitData(_giaovien.getList());
            documentViewer.DocumentSource = report;
            report.ShowPreviewDialog();
        }

        private void btnDong_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }
        public byte[] ImageToBase64(Image image, System.Drawing.Imaging.ImageFormat format)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                image.Save(ms, format);
                byte[] imageBytes = ms.ToArray();
                return imageBytes;
            }
        }

        public Image Base64ToImage(byte[] imageBytes)
        {
            MemoryStream ms = new MemoryStream(imageBytes, 0, imageBytes.Length);
            ms.Write(imageBytes, 0, imageBytes.Length);
            Image image = Image.FromStream(ms, true);
            return image;
        }
      
        private void saveData()
        {
            if (_them)
            {
                tb_GiaoVien gv = new tb_GiaoVien();
                gv.HoTen = txtHoTen.Text;
                gv.GioiTinh = gioitinh;
                int index = gv.HoTen.LastIndexOf(" ");
                gv.Ten = gv.HoTen.Substring(index+1);
                gv.NgaySinh = dtNgaySinh.Value;
                gv.Email = txtEmail.Text;
                gv.DienThoai = txtDienThoai.Text;
                gv.DiaChi = txtDiaChi.Text;
                gv.MaChucVu = int.Parse(cboChucVu.SelectedValue.ToString());
                gv.MaTrinhDo = int.Parse(cboTrinhDo.SelectedValue.ToString());
                gv.HinhAnh = ImageToBase64(pictureEdit1.Image, pictureEdit1.Image.RawFormat);
                gv.CreateBy = All_Func.UserStatic.UID;
                gv.CreateDate = DateTime.Now;
                _giaovien.Add(gv);
            }
            else
            {
                tb_GiaoVien gv = _giaovien.getItem(_id);
                gv.HoTen = txtHoTen.Text;
                int index = gv.HoTen.LastIndexOf(" ");
                gv.Ten = gv.HoTen.Substring(index + 1);
                gv.GioiTinh = gioitinh;
                gv.NgaySinh = dtNgaySinh.Value;
                gv.Email = txtEmail.Text;   
                gv.DienThoai = txtDienThoai.Text;
                gv.DiaChi = txtDiaChi.Text;
                gv.MaChucVu = int.Parse(cboChucVu.SelectedValue.ToString());
                gv.MaTrinhDo = int.Parse(cboTrinhDo.SelectedValue.ToString());
                gv.HinhAnh = ImageToBase64(pictureEdit1.Image, pictureEdit1.Image.RawFormat);
                gv.UpdateBy = All_Func.UserStatic.UID;
                gv.UpdateDate = DateTime.Now;
                _giaovien.Update(gv);
            }
        }

        private void gvDanhSach_Click(object sender, EventArgs e)
        {
            if (gvDanhSach.RowCount > 0)
            {
                _id = int.Parse(gvDanhSach.GetFocusedRowCellValue("MaGV").ToString());
                var gv = _giaovien.getItem(_id);
                txtHoTen.Text = gv.HoTen;
                txtDienThoai.Text = gv.DienThoai;
                txtDiaChi.Text = gv.DiaChi;
                txtEmail.Text = gv.Email;
                dtNgaySinh.Value = gv.NgaySinh.Value;
                cboChucVu.SelectedValue = gv.MaChucVu;
                cboTrinhDo.SelectedValue = gv.MaTrinhDo;
                if(gv.GioiTinh == 1)
                {
                    cbGioiTinh.Checked = true;

                }
                else
                {
                    cbGioiTinh.Checked = false;

                }
                pictureEdit1.Image = Base64ToImage(gv.HinhAnh);
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
            if (e.Column.Name == "GioiTinh" )
            {
                if (int.Parse(e.CellValue.ToString())==0)
                {
                    e.DisplayText = "Nữ";
                }
                else
                {
                    e.DisplayText = "Nam";
                }
            }
        }

        private void cbGioiTinh_CheckedChanged(object sender, EventArgs e)
        {
            if (cbGioiTinh.Checked)
            {
                gioitinh = 1;
            }
            else
            {
                gioitinh = 0;
            }
        }

        private void btnThemAnh_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Filter = "Picture file (.png, .jpg)|*.png;*.jpg";
            openFile.Title = "Chọn hình ảnh";
            if (openFile.ShowDialog()== DialogResult.OK)
            {
                pictureEdit1.Image = Image.FromFile(openFile.FileName);
                pictureEdit1.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            }
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

      


    }
}