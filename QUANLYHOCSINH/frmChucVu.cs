﻿using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BussinessLayer;
using DataLayer;

namespace QUANLYHOCSINH
{
    public partial class frmChucVu : DevExpress.XtraEditors.XtraForm
    {
        public frmChucVu()
        {
            InitializeComponent();
        }
        private bool _them;
        private CHUCVU _chucvu;
        private int _id;
        private void frmChucVu_Load(object sender, EventArgs e)
        {
            showHide(true);
            _chucvu = new CHUCVU();
            loadData();
        }

        private void loadData()
        {
            _chucvu = new CHUCVU();
            gcDanhSach.DataSource = _chucvu.getList();
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
            txtChucVu.Enabled = !kt;
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
                _chucvu.Delete(_id, All_Func.UserStatic.UID);
            }
            loadData();
        }

        private void btnLuu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (txtChucVu.Text != "")
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
                tb_ChucVu cv = new tb_ChucVu();
                cv.TenChucVu = txtChucVu.Text;
                _chucvu.Add(cv);
            }
            else
            {
                tb_ChucVu cv = _chucvu.getItem(_id);
                cv.TenChucVu = txtChucVu.Text;
                _chucvu.Update(cv);
            }
        }

        private void gvDanhSach_Click(object sender, EventArgs e)
        {
            if (gvDanhSach.RowCount > 0)
            {
                _id = int.Parse(gvDanhSach.GetFocusedRowCellValue("MaChucVu").ToString());
                txtChucVu.Text = gvDanhSach.GetFocusedRowCellValue("TenChucVu").ToString();
            }
        }
    }
}