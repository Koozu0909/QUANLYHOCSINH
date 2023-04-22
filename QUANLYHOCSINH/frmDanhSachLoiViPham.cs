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
    public partial class frmDanhSachLoiViPham : DevExpress.XtraEditors.XtraForm
    {
        public frmDanhSachLoiViPham()
        {
            InitializeComponent();
        }

        private HOCSINH _hocsinh;
        private LOPHOC _lophoc;
        private NAMHOC _namhoc;
        private HOCKY _hocky;
        private KHOILOP _khoilop;
        private VIPHAM _vipham;
        private VIPHAM_CT _viphamct;
        private int _id = 0;
        private void frmDanhSachLoiViPham_Load(object sender, EventArgs e)
        {
            _namhoc = new NAMHOC();
            _lophoc = new LOPHOC();
            _hocky = new HOCKY();
            _khoilop = new KHOILOP();
            _vipham = new VIPHAM();
            _viphamct = new VIPHAM_CT();
            cboNamHoc.SelectedIndexChanged += cboNamHoc_SelectedIndexChanged;
            cboKhoiLop.SelectedIndexChanged += cboKhoiLop_SelectedIndexChanged;
            loadData();
            getList(int.Parse(cboNamHoc.SelectedValue.ToString()), int.Parse(cboHocKy.SelectedValue.ToString()), int.Parse(cboLop.SelectedValue.ToString()));
            showHide(true);
        }
        private void loadData()
        {
            cboNamHoc.DataSource = _namhoc.getList();
            cboNamHoc.DisplayMember = "TenNamHoc";
            cboNamHoc.ValueMember = "MaNamHoc";

            cboKhoiLop.DataSource = _khoilop.getList();
            cboKhoiLop.DisplayMember = "TenKhoiLop";
            cboKhoiLop.ValueMember = "MaKhoiLop";

            int maNamHoc;
            if (int.TryParse(cboNamHoc.SelectedValue.ToString(), out maNamHoc))
            {
                cboHocKy.DataSource = _hocky.getList(maNamHoc);
                cboHocKy.DisplayMember = "TenHocKy";
                cboHocKy.ValueMember = "MaHocKy";
            }
            else
            {
                // Không làm gì nếu giá trị được chọn không phải là một chuỗi số hợp lệ
            }

            int maKhoiLop;
            if (int.TryParse(cboKhoiLop.SelectedValue.ToString(), out maKhoiLop))
            {
                cboLop.DataSource = _lophoc.getList(maKhoiLop);
                cboLop.DisplayMember = "TenLop";
                cboLop.ValueMember = "MaLop";
            }
            else
            {
                // Không làm gì nếu giá trị được chọn không phải là một chuỗi số hợp lệ
            }
        }

        public void getList(int manamhoc, int mahk, int malop)
        {

            VIPHAM _vp = new VIPHAM();
            gcDanhSach.DataSource = _vp.getList(manamhoc, mahk, malop);
            gvDanhSach.OptionsBehavior.Editable = false;

        }
        private void showHide(bool kt)
        {
            btnThem.Enabled = kt;
            btnSua.Enabled = kt;
            btnXoa.Enabled = kt;
            btnDong.Enabled = kt;
            btnIn.Enabled = kt;

        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmQLViPham frm = new frmQLViPham();
            frm._them = true;
            frm.ShowDialog();
        }

        private void btnSua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmQLViPham frm = new frmQLViPham();
            frm._them = false;
            if (gvDanhSach.RowCount > 0)
            {
                frm._idmavp = int.Parse(gvDanhSach.GetFocusedRowCellValue("MaViPham").ToString());
                Console.WriteLine(frm._idmavp);
            }
            frm.ShowDialog();
        }

        private void cboNamHoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            int maNamHoc;
            if (int.TryParse(cboNamHoc.SelectedValue.ToString(), out maNamHoc))
            {
                cboHocKy.DataSource = _hocky.getList(maNamHoc);
                cboHocKy.DisplayMember = "TenHocKy";
                cboHocKy.ValueMember = "MaHocKy";
                getList(maNamHoc, int.Parse(cboHocKy.SelectedValue.ToString()), int.Parse(cboLop.SelectedValue.ToString()));

            }
            else
            {
                // Không làm gì nếu giá trị được chọn không phải là một chuỗi số hợp lệ

            }

        }

        private void cboKhoiLop_SelectedIndexChanged(object sender, EventArgs e)
        {

            int maKhoiLop;
            if (int.TryParse(cboKhoiLop.SelectedValue.ToString(), out maKhoiLop))
            {
                cboLop.DataSource = _lophoc.getList(maKhoiLop);
                cboLop.DisplayMember = "TenLop";
                cboLop.ValueMember = "MaLop";
            }
            else
            {
                // Không làm gì nếu giá trị được chọn không phải là một chuỗi số hợp lệ
            }
        }

        private void cboLop_SelectedIndexChanged(object sender, EventArgs e)
        {
            int maLop;
            if (int.TryParse(cboLop.SelectedValue.ToString(), out maLop))
            {
                getList(int.Parse(cboNamHoc.SelectedValue.ToString()), int.Parse(cboHocKy.SelectedValue.ToString()), maLop);
            }
            else
            {
                // Không làm gì nếu giá trị được chọn không phải là một chuỗi số hợp lệ

            }
        }

        private void cboHocKy_SelectedIndexChanged(object sender, EventArgs e)
        {
            int maHocKy;
            if (int.TryParse(cboHocKy.SelectedValue.ToString(), out maHocKy))
            {
                getList(int.Parse(cboNamHoc.SelectedValue.ToString()), maHocKy, int.Parse(cboLop.SelectedValue.ToString()));
            }
            else
            {
                // Không làm gì nếu giá trị được chọn không phải là một chuỗi số hợp lệ

            }

        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (MessageBox.Show("Bạn Có Chắc Xóa ?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                _viphamct.DeleteByVPId(_id);
                _vipham.Delete(_id);
            }
            getList(int.Parse(cboNamHoc.SelectedValue.ToString()), int.Parse(cboHocKy.SelectedValue.ToString()), int.Parse(cboLop.SelectedValue.ToString()));
        }

        private void gvDanhSach_Click(object sender, EventArgs e)
        {

            if (gvDanhSach.RowCount > 0)
            {
                _id = int.Parse(gvDanhSach.GetFocusedRowCellValue("MaViPham").ToString());
                Console.WriteLine(_id);
            }
        }
    }
}