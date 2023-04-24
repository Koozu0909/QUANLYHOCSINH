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
using DevExpress.XtraCharts;

namespace QUANLYHOCSINH
{
    public partial class frmThongKeGVMon : DevExpress.XtraEditors.XtraForm
    {
        public frmThongKeGVMon()
        {
            InitializeComponent();
        }
        private GIAOVIEN_MONHOC _gv_mon;
        private NAMHOC _namhoc;
        private void frmThongKeGVMon_Load(object sender, EventArgs e)
        {
            _gv_mon = new GIAOVIEN_MONHOC();
            _namhoc = new NAMHOC();
            loadData();
            drawChart();
        }
        private void loadData()
        {
            cboNamHoc.DataSource = _namhoc.getList();
            cboNamHoc.DisplayMember = "TenNamHoc";
            cboNamHoc.ValueMember = "MaNamHoc";
        }
        private void drawChart()
        {
            int maNamHoc;
            if (int.TryParse(cboNamHoc.SelectedValue.ToString(), out maNamHoc))
            {
                var data = _gv_mon.getSoLuongGV_TungMon(maNamHoc);
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
                ((XYDiagram)charThongKeHS.Diagram).AxisX.Title.Text = "Môn";
                ((XYDiagram)charThongKeHS.Diagram).AxisY.Title.Text = "Số lượng GV";
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

        
    }
}