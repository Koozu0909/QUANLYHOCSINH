using BussinessLayer.DTO;
using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;

namespace QUANLYHOCSINH.Reports
{
    public partial class GiaoVien_rep : DevExpress.XtraReports.UI.XtraReport
    {
        public GiaoVien_rep()
        {
            InitializeComponent();
        }

        public void InitData(List<tb_GiaoVienDTO> data)
        {
            bindingSource1.DataSource = data;
        }

    }
}
