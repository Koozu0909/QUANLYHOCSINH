using DevExpress.XtraBars;
using DevExpress.XtraSplashScreen;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;  
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QUANLYHOCSINH
{
    public partial class MainForm : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public MainForm()
        {
            InitializeComponent();
        }

       
        private void MainForm_Load(object sender, EventArgs e)
        {
            frmLogin frm = new frmLogin();
            frm.ShowDialog();
        }
        void openForm(Type typeForm)
        {
            foreach(var frm in MdiChildren)
            {
                if(frm.GetType() == typeForm)
                {
                    frm.Activate();
                    return;
                }
            }
            Form f = (Form)Activator.CreateInstance(typeForm);
            f.MdiParent = this;
            f.Show();
        }
        private void mnMon_ItemClick(object sender, ItemClickEventArgs e)
        {
            openForm(typeof(frmMonHoc));
        }

        private void mnNamHoc_ItemClick(object sender, ItemClickEventArgs e)
        {
            openForm(typeof(frmNamHoc));
        }

        private void mnHocKy_ItemClick(object sender, ItemClickEventArgs e)
        {
            openForm(typeof(frmHocKy));
        }

        private void mnChucvu_ItemClick(object sender, ItemClickEventArgs e)
        {
            openForm(typeof(frmChucVu));
        }

        private void mnTrinhDo_ItemClick(object sender, ItemClickEventArgs e)
        {
            openForm(typeof(frmTrinhDo));
        }

        private void mnGiaoVien_ItemClick(object sender, ItemClickEventArgs e)
        {
            openForm(typeof(frmGiaoVien));
        }

        private void mnTonGiao_ItemClick(object sender, ItemClickEventArgs e)
        {
            openForm(typeof(frmTonGiao));
        }

        private void mnDanToc_ItemClick(object sender, ItemClickEventArgs e)
        {
            openForm(typeof(frmDanToc));
        }

        private void mnKhoi_ItemClick(object sender, ItemClickEventArgs e)
        {
            openForm(typeof(frmKhoiLop));

        }

        private void mnViPham_ItemClick(object sender, ItemClickEventArgs e)
        {
            openForm(typeof(frmDanhMucLoi));
        }

        private void mnHocSinh_ItemClick(object sender, ItemClickEventArgs e)
        {
            openForm(typeof(frmHocSinh));
        }

        private void mnLop_ItemClick(object sender, ItemClickEventArgs e)
        {
            openForm(typeof(frmLopHoc));

        }

        private void mnQLLoi_ItemClick(object sender, ItemClickEventArgs e)
        {
            openForm(typeof(frmDanhSachLoiViPham));
        }

        private void mnPhanLop_ItemClick(object sender, ItemClickEventArgs e)
        {
            openForm(typeof(frmPhanLop));
        }

        private void mnChuyenLop_ItemClick(object sender, ItemClickEventArgs e)
        {
            openForm(typeof(frmChuyenLop));

        }

        private void mnQLDiem_ItemClick(object sender, ItemClickEventArgs e)
        {
            openForm(typeof(frmQLDiem));
        }

        private void mnPhanLopGV_ItemClick(object sender, ItemClickEventArgs e)
        {
            openForm(typeof(PhanLop_GV));
        }

        private void mnHSLop_ItemClick(object sender, ItemClickEventArgs e)
        {
            openForm(typeof(frmThongKeHSLop));

        }

      

        private void mnPhanMon_ItemClick_1(object sender, ItemClickEventArgs e)
        {
            openForm(typeof(frmPhanMon));

        }
    }
}