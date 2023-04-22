using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Collections.Generic;

using BussinessLayer.DTO;

namespace QUANLYHOCSINH.Reports
{
    public partial class HocSinh_rep : DevExpress.XtraReports.UI.XtraReport
    {
        public HocSinh_rep()
        {
            InitializeComponent();
        }
        public void InitData(List<tb_HocSinhDTO> data)
        {
            objectDataSource1.DataSource = data;
        }

    }
}
