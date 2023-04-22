using BussinessLayer;
using DevExpress.XtraCharts;
using System;

namespace QUANLYHOCSINH
{
    public partial class frmThongKeHSLop : DevExpress.XtraEditors.XtraForm
    {
        public frmThongKeHSLop()
        {
            InitializeComponent();
        }

        private HOCSINH_LOP_NAMHOC _hslop;
        private NAMHOC _namhoc;
        private KHOILOP _khoilop;

        private void frmThongKeHSLop_Load(object sender, EventArgs e)
        {
            _hslop = new HOCSINH_LOP_NAMHOC();
            _namhoc = new NAMHOC();
            _khoilop = new KHOILOP();
            loadData();
            drawChart();
        }

        private void loadData()
        {
            cboNamHoc.DataSource = _namhoc.getList();
            cboNamHoc.DisplayMember = "TenNamHoc";
            cboNamHoc.ValueMember = "MaNamHoc";

            cboKhoiLop.DataSource = _khoilop.getList();
            cboKhoiLop.DisplayMember = "TenKhoiLop";
            cboKhoiLop.ValueMember = "MaKhoiLop";
        }
        private void drawChart()
        {
            int maNamHoc;
            int khoilop;
            if (int.TryParse(cboNamHoc.SelectedValue.ToString(), out maNamHoc) && int.TryParse(cboKhoiLop.SelectedValue.ToString(), out khoilop))
            {
                var data = _hslop.getSoLuongHS_TungLop(maNamHoc, khoilop);

                // Thiết lập đối tượng dữ liệu cho biểu đồ
                charThongKeHS.DataSource = data;

                //// Thiết lập đối tượng loại biểu đồ
                //Series series = new Series("Số lượng học sinh", ViewType.Bar);
                //charThongKeHS.Series.Add(series);

                //// Thiết lập trường dữ liệu cho trục hoành (trục X)
                //series.ArgumentDataMember = "TenLop";

                //// Thiết lập trường dữ liệu cho trục tung (trục Y)
                //series.ValueDataMembers.AddRange(new string[] { "SoLuongHS" });

                //// Hiển thị giá trị trên biểu đồ
                //series.LabelsVisibility = DevExpress.Utils.DefaultBoolean.True;

                // Thiết lập tên cho trục hoành và trục tung
                ((XYDiagram)charThongKeHS.Diagram).AxisX.Title.Text = "Lớp";
                ((XYDiagram)charThongKeHS.Diagram).AxisY.Title.Text = "Số lượng học sinh";
            }
            else
            {
                // Không làm gì nếu giá trị được chọn không phải là một chuỗi số hợp lệ
            }
        }

        private void cboNamHoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            drawChart();
        }

        private void cboKhoiLop_SelectedIndexChanged(object sender, EventArgs e)
        {
            drawChart();
        }
    }
}