
namespace QUANLYHOCSINH
{
    partial class frmThongKeGVMon
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DevExpress.XtraCharts.XYDiagram xyDiagram4 = new DevExpress.XtraCharts.XYDiagram();
            DevExpress.XtraCharts.Series series4 = new DevExpress.XtraCharts.Series();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.cboNamHoc = new System.Windows.Forms.ComboBox();
            this.charThongKeHS = new DevExpress.XtraCharts.ChartControl();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.charThongKeHS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(xyDiagram4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series4)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.labelControl7);
            this.splitContainer1.Panel1.Controls.Add(this.cboNamHoc);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.charThongKeHS);
            this.splitContainer1.Size = new System.Drawing.Size(1103, 508);
            this.splitContainer1.SplitterDistance = 74;
            this.splitContainer1.TabIndex = 7;
            // 
            // labelControl7
            // 
            this.labelControl7.Location = new System.Drawing.Point(28, 15);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(51, 16);
            this.labelControl7.TabIndex = 27;
            this.labelControl7.Text = "Năm Học";
            // 
            // cboNamHoc
            // 
            this.cboNamHoc.FormattingEnabled = true;
            this.cboNamHoc.Location = new System.Drawing.Point(85, 12);
            this.cboNamHoc.Name = "cboNamHoc";
            this.cboNamHoc.Size = new System.Drawing.Size(202, 24);
            this.cboNamHoc.TabIndex = 26;
            this.cboNamHoc.SelectedIndexChanged += new System.EventHandler(this.cboNamHoc_SelectedIndexChanged);
            // 
            // charThongKeHS
            // 
            this.charThongKeHS.AppearanceNameSerializable = "Gray";
            xyDiagram4.AxisX.Title.Text = "Lớp";
            xyDiagram4.AxisX.VisibleInPanesSerializable = "-1";
            xyDiagram4.AxisY.Title.Text = "Số Lượng Học Sinh";
            xyDiagram4.AxisY.VisibleInPanesSerializable = "-1";
            this.charThongKeHS.Diagram = xyDiagram4;
            this.charThongKeHS.Dock = System.Windows.Forms.DockStyle.Fill;
            this.charThongKeHS.Legend.Name = "Default Legend";
            this.charThongKeHS.Location = new System.Drawing.Point(0, 0);
            this.charThongKeHS.Name = "charThongKeHS";
            this.charThongKeHS.PaletteBaseColorNumber = 4;
            this.charThongKeHS.PaletteName = "Oriel";
            series4.ArgumentDataMember = "TenMH";
            series4.LabelsVisibility = DevExpress.Utils.DefaultBoolean.True;
            series4.Name = "Số lượng Giáo Viên Từng Môn";
            series4.ValueDataMembersSerializable = "SoLuongGV";
            this.charThongKeHS.SeriesSerializable = new DevExpress.XtraCharts.Series[] {
        series4};
            this.charThongKeHS.Size = new System.Drawing.Size(1103, 430);
            this.charThongKeHS.TabIndex = 0;
            // 
            // frmThongKeGVMon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1103, 508);
            this.Controls.Add(this.splitContainer1);
            this.Name = "frmThongKeGVMon";
            this.Text = "frmThongKeGVMon";
            this.Load += new System.EventHandler(this.frmThongKeGVMon_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(xyDiagram4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.charThongKeHS)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private System.Windows.Forms.ComboBox cboNamHoc;
        private DevExpress.XtraCharts.ChartControl charThongKeHS;
    }
}