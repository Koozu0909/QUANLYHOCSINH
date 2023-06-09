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
using DataLayer;
using BussinessLayer;

namespace QUANLYHOCSINH
{
    public partial class frmChuyenLop : DevExpress.XtraEditors.XtraForm
    {
        public frmChuyenLop()
        {
            InitializeComponent();
        }

        private QUANLYHOCSINHEntities db = new QUANLYHOCSINHEntities();

        private NAMHOC _namhoc;
        private HOCSINH _hocsinh;
        private KHOILOP _khoilop;
        private LOPHOC _lophoc;
        private HOCSINH_LOP_NAMHOC _phanlop;
        private int _id;
        private void frmChuyenLop_Load(object sender, EventArgs e)
        {
            _hocsinh = new HOCSINH();
            _namhoc = new NAMHOC();
            _khoilop = new KHOILOP();
            _lophoc = new LOPHOC();
            _phanlop = new HOCSINH_LOP_NAMHOC();
            loadKhoiLop();
            loadNamhoc();
            loadLop();
            loadPhanLop();
            showHide(true);
        }

        private void loadNamhoc()
        {
            cboNamHoc.DataSource = _namhoc.getList();
            cboNamHoc.DisplayMember = "TenNamHoc";
            cboNamHoc.ValueMember = "MaNamHoc";
        }

        private void loadKhoiLop()  
        {
            cboKhoiLop.DataSource = _khoilop.getList();
            cboKhoiLop.DisplayMember = "TenKhoiLop";
            cboKhoiLop.ValueMember = "MaKhoiLop";
        }

        private void loadLop()
        {
            _lophoc = new LOPHOC();
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

        private void loadPhanLop()
        {
            int namHoc;
            int lop;
            int khoilop;
            if (int.TryParse(cboNamHoc.SelectedValue.ToString(), out namHoc) && int.TryParse(cboLop.SelectedValue.ToString(), out lop) && int.TryParse(cboKhoiLop.SelectedValue.ToString(), out khoilop))
            {
                gcHocSinhLop.DataSource = _phanlop.getList(namHoc, lop, khoilop);
                gvHocSinhLop.OptionsBehavior.Editable = false;
            }
            else
            {
                // Handle the case where the parsing failed
            }
        }

        private void showHide(bool kt)
        {
            gcHocSinhLop.Enabled = kt;
            btnCapNhat.Enabled = kt;
            btnDong.Enabled = kt;
            btnHuy.Enabled = !kt;
            btnLuu.Enabled = !kt;
            //cboKhoiLop.Enabled = !kt;
            //cboLop.Enabled = !kt;
            //cboNamHoc.Enabled = !kt;
            gcHocSinh.Enabled = !kt;
        }
        //private void loadHocSinh()
        //{
        //    var lstHocSinh = _hocsinh.getList().Where(hs => !db.tb_HocSinh_Lop_NamHoc.Any(pl => pl.MaHS == hs.MaHS));
        //    gcHocSinh.DataSource = lstHocSinh.ToList();
        //    gvHocSinh.OptionsBehavior.Editable = false;
        //}

    }
}