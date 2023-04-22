using BussinessLayer;
using BussinessLayer.DTO;
using DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace QUANLYHOCSINH
{
    public partial class frmQLViPham : DevExpress.XtraEditors.XtraForm
    {
        public frmQLViPham()
        {
            InitializeComponent();
        }
        private QUANLYHOCSINHEntities db = new QUANLYHOCSINHEntities();
        public bool _them = false;
        public int _idmavp = 0;
        private int _idmavpct = 0;


        private HOCSINH _hocsinh;
        private LOPHOC _lophoc;
        private NAMHOC _namhoc;
        private HOCKY _hocky;
        private KHOILOP _khoilop;
        private DANHMUCLOI _loi;
        private VIPHAM _vipham;
        private VIPHAM_CT _viphamct;
        List<tb_ViPham_CT_DTO> lstVPCT;
        frmDanhSachLoiViPham obj = (frmDanhSachLoiViPham)Application.OpenForms["frmDanhSachLoiViPham"];
        private int _id;

        private void frmQLViPham_Load(object sender, EventArgs e)
        {
            _namhoc = new NAMHOC();
            _viphamct = new VIPHAM_CT();
            _lophoc = new LOPHOC();
            _hocky = new HOCKY();
            _khoilop = new KHOILOP();
            _vipham = new VIPHAM();
            _loi = new DANHMUCLOI();
            _hocsinh = new HOCSINH();
            lstVPCT = new List<tb_ViPham_CT_DTO>();
            cboNamHoc.SelectedIndexChanged += cboNamHoc_SelectedIndexChanged;
            cboKhoiLop.SelectedIndexChanged += cboKhoiLop_SelectedIndexChanged;
            cboLop.SelectedIndexChanged += cboLop_SelectedIndexChanged;
            loadData();
            loadDMLoi();
            loadHocSinh();
            checkLoadGv();
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

        private void loadHocSinh()
        {
            int malop;
            int manamhoc;
            if (int.TryParse(cboLop.SelectedValue.ToString(), out malop) && int.TryParse(cboNamHoc.SelectedValue.ToString(), out manamhoc))
            {
                lkHocSinh.Properties.DataSource = _hocsinh.getList(malop, manamhoc);
                lkHocSinh.Properties.ValueMember = "MaHS";
                lkHocSinh.Properties.DisplayMember = "HoTen";
            }
            else
            {
                // Thêm mã lỗi hoặc thông báo lỗi để giúp phát hiện lỗi nhanh hơn.
            }
        }

        private void loadDMLoi()
        {
            lkDanhMucLoi.Properties.DataSource = _loi.getList();
            lkDanhMucLoi.Properties.DisplayMember = "TenLoi";
            lkDanhMucLoi.Properties.ValueMember = "MaLoi";
        }

        private void cboNamHoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            int maNamHoc;
            if (int.TryParse(cboNamHoc.SelectedValue.ToString(), out maNamHoc))
            {
                cboHocKy.DataSource = _hocky.getList(maNamHoc);
                cboHocKy.DisplayMember = "TenHocKy";
                cboHocKy.ValueMember = "MaHocKy";
                loadHocSinh();
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
                loadHocSinh();
            }
            else
            {
                // Không làm gì nếu giá trị được chọn không phải là một chuỗi số hợp lệ
            }
        }

        private void cboLop_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadHocSinh();
        }

        private void showHide(bool kt)
        {
            //btnCapNhat.Enabled = !kt;
            //btnThem.Enabled = kt;
            //btnDong.Enabled = kt;
        }

        private void btnCapNhat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (_them)
            {
                tb_ViPham vp = new tb_ViPham();
                vp.MaNamHoc = int.Parse(cboNamHoc.SelectedValue.ToString());
                vp.MaHocKy = int.Parse(cboHocKy.SelectedValue.ToString());
                vp.MaLop = int.Parse(cboLop.SelectedValue.ToString());
                vp.NgayViPham = DateTime.Now;
                vp.TongSoLoi = gvDanhSach.RowCount;
                vp.TongDiem = int.Parse(gvDanhSach.Columns["Diem"].SummaryItem.SummaryValue.ToString());
                vp.GhiChu = txtGhiChu.Text;
                vp.CreatedBy = 1;
                vp.CreatedDate = DateTime.Now;
                var result = _vipham.Add(vp);
                for (int i = 0; i < gvDanhSach.RowCount; i++)
                {
                    tb_ViPham_CT ct = new tb_ViPham_CT();
                    ct.MaViPham = result.MaViPham;
                    ct.MaHS = int.Parse(gvDanhSach.GetRowCellValue(i, "MaHS").ToString());
                    ct.MaLoi = int.Parse(gvDanhSach.GetRowCellValue(i, "MaLoi").ToString());
                    ct.Diem = int.Parse(gvDanhSach.GetRowCellValue(i, "Diem").ToString());
                    ct.NgayViPham = DateTime.Now;
                    if(gvDanhSach.GetRowCellValue(i, "GhiChu") == null)
                    {
                        ct.GhiChu = " ";
                    }
                    else
                    {
                        ct.GhiChu = gvDanhSach.GetRowCellValue(i, "GhiChu").ToString();
                    }
                    _viphamct.Add(ct);
                }
            }
            else
            {
                tb_ViPham vp = _vipham.getItem(_idmavp);
                vp.MaNamHoc = int.Parse(cboNamHoc.SelectedValue.ToString());
                vp.MaHocKy = int.Parse(cboHocKy.SelectedValue.ToString());
                vp.MaLop = int.Parse(cboLop.SelectedValue.ToString());
                vp.NgayViPham = DateTime.Now;
                vp.TongSoLoi = gvDanhSach.RowCount;
                vp.TongDiem = int.Parse(gvDanhSach.Columns["Diem"].SummaryItem.SummaryValue.ToString());
                vp.GhiChu = txtGhiChu.Text;
                vp.CreatedBy = 1;
                vp.CreatedDate = DateTime.Now;
                var result = _vipham.Update(vp);

                for (int i = 0; i < gvDanhSach.RowCount; i++)
                {
                    _idmavpct = int.Parse(gvDanhSach.GetRowCellValue(i, "MaVPCT").ToString());
                    tb_ViPham_CT ct = _viphamct.getItem(_idmavpct);
                    if(ct == null)
                    {
                        tb_ViPham_CT cta = new tb_ViPham_CT();
                        cta.MaViPham = result.MaViPham;
                        cta.MaHS = int.Parse(gvDanhSach.GetRowCellValue(i, "MaHS").ToString());
                        cta.MaLoi = int.Parse(gvDanhSach.GetRowCellValue(i, "MaLoi").ToString());
                        cta.Diem = int.Parse(gvDanhSach.GetRowCellValue(i, "Diem").ToString());
                        cta.NgayViPham = DateTime.Now;
                        if (gvDanhSach.GetRowCellValue(i, "GhiChu") == null)
                        {
                            cta.GhiChu = " ";
                        }
                        else
                        {
                            cta.GhiChu = gvDanhSach.GetRowCellValue(i, "GhiChu").ToString();
                        }
                        _viphamct.Add(cta);
                    }
                    else
                    {
                        ct.MaViPham = result.MaViPham;
                        ct.MaHS = int.Parse(gvDanhSach.GetRowCellValue(i, "MaHS").ToString());
                        ct.MaLoi = int.Parse(gvDanhSach.GetRowCellValue(i, "MaLoi").ToString());
                        ct.Diem = int.Parse(gvDanhSach.GetRowCellValue(i, "Diem").ToString());
                        ct.NgayViPham = DateTime.Now;
                        if (gvDanhSach.GetRowCellValue(i, "GhiChu") == null)
                        {
                            ct.GhiChu = " ";
                        }
                        else
                        {
                            ct.GhiChu = gvDanhSach.GetRowCellValue(i, "GhiChu").ToString();
                        }
                        _viphamct.Update(ct);
                    }

                }
            }
            obj.getList(int.Parse(cboNamHoc.SelectedValue.ToString()), int.Parse(cboHocKy.SelectedValue.ToString()), int.Parse(cboLop.SelectedValue.ToString()));
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            tb_ViPham_CT_DTO ct = new tb_ViPham_CT_DTO();
            ct.MaHS = int.Parse(lkHocSinh.EditValue.ToString());
            ct.TenHS = lkHocSinh.Text;
            var dr = (tb_DanhMucLoi)lkDanhMucLoi.GetSelectedDataRow();
            ct.MaLoi = dr.MaLoi;
            ct.TenLoi = dr.TenLoi;
            ct.Diem = dr.Diem;
            ct.GhiChu = txtGhiChu.Text;
            ct.NgayViPham = DateTime.Now;


            // Lấy dữ liệu hiện tại từ Gridview
            lstVPCT = (List<tb_ViPham_CT_DTO>)gcDanhSach.DataSource;

            // Thêm mục mới vào danh sách
            lstVPCT.Add(ct);

            // Thiết lập lại nguồn dữ liệu của Gridview bằng danh sách mới
            gcDanhSach.DataSource = lstVPCT;

            // Cập nhật lại giao diện người dùng nếu cần thiết
            gcDanhSach.RefreshDataSource();
        }

        private void checkLoadGv()
        {
            if (_them == false)
            {
                _viphamct = new VIPHAM_CT();
                gcDanhSach.DataSource = _viphamct.getListFull(_idmavp);
                gvDanhSach.OptionsBehavior.Editable = false;
            }
            else
            {
                // Khởi tạo danh sách rỗng nếu cần thiết
                List<tb_ViPham_CT_DTO> newlstVPCT = new List<tb_ViPham_CT_DTO>();

                // Thiết lập nguồn dữ liệu của Gridview
                gcDanhSach.DataSource = newlstVPCT;

                // Cập nhật lại giao diện người dùng nếu cần thiết
                gcDanhSach.RefreshDataSource();
            }
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (gvDanhSach.RowCount > 0)
            {
                if(_id == 0)
                {
                    int index = gvDanhSach.GetFocusedDataSourceRowIndex();
                    lstVPCT.RemoveAt(index);
                    gcDanhSach.DataSource = lstVPCT.ToList();
                    _id = 0;
                }
                else
                {
                    _viphamct.Delete(_id);
                    gcDanhSach.DataSource = _viphamct.getListFull(_idmavp);
                    _id = 0;
                }

            }
        }
        private void gvDanhSach_Click(object sender, EventArgs e)
        {
            if (gvDanhSach.RowCount > 0)
            {
                _id = int.Parse(gvDanhSach.GetFocusedRowCellValue("MaVPCT").ToString());
                Console.WriteLine(_id);
            }
        }
        private void btnSave_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (gvDanhSach.RowCount > 0)
            {
                int index = gvDanhSach.GetFocusedDataSourceRowIndex();
                tb_ViPham_CT_DTO ct = lstVPCT[index];
                ct.MaHS = int.Parse(lkHocSinh.EditValue.ToString());
                ct.TenHS = lkHocSinh.Text;
                var dr = (tb_DanhMucLoi)lkDanhMucLoi.GetSelectedDataRow();
                ct.MaLoi = dr.MaLoi;
                ct.TenLoi = dr.TenLoi;
                ct.Diem = dr.Diem;
                ct.GhiChu = txtGhiChu.Text;
                ct.NgayViPham = DateTime.Now;
                gcDanhSach.DataSource = lstVPCT.ToList();
            }
        }
 

        private void btnLuu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }


        private void btnDong_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

    
    }
}