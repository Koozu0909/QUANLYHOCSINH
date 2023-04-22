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
using DevExpress.DataAccess.Excel;

namespace QUANLYHOCSINH
{
    public partial class frmDanhMucLoi : DevExpress.XtraEditors.XtraForm
    {
        public frmDanhMucLoi()
        {
            InitializeComponent();
        }
        private bool _them;
        private DANHMUCLOI _danhmucloi;
        private int _id;
        private bool _import = false;
        private void frmDanhMucLoi_Load(object sender, EventArgs e)
        {
            showHide(true);
            _danhmucloi = new DANHMUCLOI();
            loadData();
        }
        private void loadData()
        {
            _danhmucloi = new DANHMUCLOI();
            gcDanhSach.DataSource = _danhmucloi.getList();
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
            txtGhiChu.Enabled = !kt;
            spinDiem.Enabled = !kt;
            txtTenLoi.Enabled = !kt;
            cbNghiemTrong.Enabled = !kt;
            btnImport.Enabled = false;
        }
        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            showHide(false);
            _them = true;
            btnImport.Enabled = true;

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
                _danhmucloi.Delete(_id, All_Func.UserStatic.UID);
            }
            loadData();
        }

        private void btnLuu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if(_import)
            {
                saveExcel();
            }
            else
            {
                saveData();
            }
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

        private void saveExcel()
        {
            for(int i = 0; i< gvDanhSach.RowCount; i++)
            {
                tb_DanhMucLoi loi = new tb_DanhMucLoi();
                loi.TenLoi = gvDanhSach.GetRowCellValue(i,"TenLoi").ToString();
                loi.Diem = int.Parse(gvDanhSach.GetRowCellValue(i, "Diem").ToString());
                if(gvDanhSach.GetRowCellValue(i, "GhiChu")== null)
                {
                    loi.GhiChu = " ";
                }
                else
                {
                    loi.GhiChu = gvDanhSach.GetRowCellValue(i, "GhiChu").ToString();
                }
                loi.NghiemTrong = bool.Parse(gvDanhSach.GetRowCellValue(i, "NghiemTrong").ToString());
                loi.CreateBy = All_Func.UserStatic.UID;
                loi.CreateDate = DateTime.Now;
                _danhmucloi.Add(loi);
            }
            _import = false;
        }
        private void saveData()
        {
            if (_them)
            {
                tb_DanhMucLoi loi = new tb_DanhMucLoi();
                loi.TenLoi = txtTenLoi.Text;
                loi.Diem = int.Parse(spinDiem.Text);
                loi.GhiChu = txtGhiChu.Text;
                loi.NghiemTrong = cbNghiemTrong.Checked;
                loi.CreateBy = All_Func.UserStatic.UID;
                loi.CreateDate = DateTime.Now;
                _danhmucloi.Add(loi);
            }
            else
            {
                tb_DanhMucLoi loi = _danhmucloi.getItem(_id);
                loi.TenLoi = txtTenLoi.Text;
                loi.Diem = int.Parse(spinDiem.Text);
                loi.GhiChu = txtGhiChu.Text;
                loi.NghiemTrong = cbNghiemTrong.Checked;
                loi.UpdateBy = All_Func.UserStatic.UID;
                loi.UpdateDate = DateTime.Now;
                _danhmucloi.Update(loi);
            }
        }
        private void gvDanhSach_Click(object sender, EventArgs e)
        {
            if (gvDanhSach.RowCount > 0)
            {
                _id = int.Parse(gvDanhSach.GetFocusedRowCellValue("MaLoi").ToString());
                txtTenLoi.Text = gvDanhSach.GetFocusedRowCellValue("TenLoi").ToString();
                spinDiem.Text = gvDanhSach.GetFocusedRowCellValue("Diem").ToString();
                txtGhiChu.Text = gvDanhSach.GetFocusedRowCellValue("GhiChu").ToString();
                cbNghiemTrong.Checked = bool.Parse(gvDanhSach.GetFocusedRowCellValue("NghiemTrong").ToString());
            }
        }

        private void btnImport_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
          
            OpenFileDialog fd = new OpenFileDialog();
            fd.Title = "Chọn File Import";
            fd.Filter = "Excel (*.xls ) | *.xls  | ( *.xlsx ) |*.xlsx";
            if(fd.ShowDialog() == DialogResult.OK)
            {
                ExcelDataSource excel = new ExcelDataSource();
                excel.FileName = fd.FileName;
                ExcelWorksheetSettings excelWorksheet = new ExcelWorksheetSettings("Sheet1", "A1:E100");
                excel.SourceOptions = new ExcelSourceOptions(excelWorksheet);
                excel.SourceOptions = new CsvSourceOptions()
                {
                    CellRange = "A1:E100"
                };
                excel.SourceOptions.SkipEmptyRows = false;
                excel.SourceOptions.UseFirstRowAsHeader = true ;
                excel.Fill();
                gcDanhSach.DataSource = excel;
                _import = true;
            }
        }
    }
}