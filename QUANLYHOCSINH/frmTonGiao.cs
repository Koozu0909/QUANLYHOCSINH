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
    public partial class frmTonGiao : DevExpress.XtraEditors.XtraForm
    {
        public frmTonGiao()
        {
            InitializeComponent();
        }
        private bool _them;
        private TONGIAO _tongiao;
        private int _id;


        private void frmTonGiao_Load(object sender, EventArgs e)
        {
            showHide(true);
            _tongiao = new TONGIAO();
            loadData();

        }
        private void loadData()
        {
            _tongiao = new TONGIAO();
            gcDanhSach.DataSource = _tongiao.getList();
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
            txtTonGiao.Enabled = !kt;
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
                _tongiao.Delete(_id, All_Func.UserStatic.UID);
            }
            loadData();
        }

        private void btnLuu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (txtTonGiao.Text != "")
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
                tb_TonGiao tg = new tb_TonGiao();
                tg.TenTonGiao = txtTonGiao.Text;
                _tongiao.Add(tg);
            }
            else
            {
                tb_TonGiao tg = _tongiao.getItem(_id);
                tg.TenTonGiao = txtTonGiao.Text;
                _tongiao.Update(tg);
            }
        }
        private void gvDanhSach_Click(object sender, EventArgs e)
        {

            if (gvDanhSach.RowCount > 0)
            {
                _id = int.Parse(gvDanhSach.GetFocusedRowCellValue("MaTonGiao").ToString());
                txtTonGiao.Text = gvDanhSach.GetFocusedRowCellValue("TenTonGiao").ToString();
            }
        }
    }
}