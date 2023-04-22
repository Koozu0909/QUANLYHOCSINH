
namespace QUANLYHOCSINH
{
    partial class frmChuyenLop
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmChuyenLop));
            this.gcHocSinh = new DevExpress.XtraGrid.GridControl();
            this.gvHocSinh = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.MaHS = new DevExpress.XtraGrid.Columns.GridColumn();
            this.HoTen = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GioiTinh = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NgaySinh = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DiaChi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.btnCapNhat = new DevExpress.XtraBars.BarButtonItem();
            this.btnDong = new DevExpress.XtraBars.BarButtonItem();
            this.btnHuy = new DevExpress.XtraBars.BarButtonItem();
            this.btnLuu = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.btnSua = new DevExpress.XtraBars.BarButtonItem();
            this.gcHocSinhLop = new DevExpress.XtraGrid.GridControl();
            this.gvHocSinhLop = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.MaHSLop = new DevExpress.XtraGrid.Columns.GridColumn();
            this.HoTenLop = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GioiTinhLop = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NgaySinhLop = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DiaChiLop = new DevExpress.XtraGrid.Columns.GridColumn();
            this.MaLop = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TenLop = new DevExpress.XtraGrid.Columns.GridColumn();
            this.behaviorManager1 = new DevExpress.Utils.Behaviors.BehaviorManager(this.components);
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.cboLop = new System.Windows.Forms.ComboBox();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.cboKhoiLop = new System.Windows.Forms.ComboBox();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.cboNamHoc = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.cboNamHocChuyen = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.gcHocSinh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvHocSinh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcHocSinhLop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvHocSinhLop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gcHocSinh
            // 
            this.gcHocSinh.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcHocSinh.Location = new System.Drawing.Point(0, 0);
            this.gcHocSinh.MainView = this.gvHocSinh;
            this.gcHocSinh.MenuManager = this.barManager1;
            this.gcHocSinh.Name = "gcHocSinh";
            this.gcHocSinh.Size = new System.Drawing.Size(627, 520);
            this.gcHocSinh.TabIndex = 0;
            this.gcHocSinh.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvHocSinh});
            // 
            // gvHocSinh
            // 
            this.gvHocSinh.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.MaHS,
            this.HoTen,
            this.GioiTinh,
            this.NgaySinh,
            this.DiaChi});
            this.gvHocSinh.GridControl = this.gcHocSinh;
            this.gvHocSinh.Name = "gvHocSinh";
            this.gvHocSinh.OptionsSelection.MultiSelect = true;
            this.gvHocSinh.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect;
            this.gvHocSinh.OptionsSelection.ShowCheckBoxSelectorInColumnHeader = DevExpress.Utils.DefaultBoolean.True;
            // 
            // MaHS
            // 
            this.MaHS.Caption = "ID";
            this.MaHS.FieldName = "MaHS";
            this.MaHS.MaxWidth = 30;
            this.MaHS.MinWidth = 30;
            this.MaHS.Name = "MaHS";
            this.MaHS.Visible = true;
            this.MaHS.VisibleIndex = 1;
            this.MaHS.Width = 30;
            // 
            // HoTen
            // 
            this.HoTen.Caption = "Họ Tên";
            this.HoTen.FieldName = "HoTen";
            this.HoTen.MaxWidth = 120;
            this.HoTen.MinWidth = 120;
            this.HoTen.Name = "HoTen";
            this.HoTen.Visible = true;
            this.HoTen.VisibleIndex = 2;
            this.HoTen.Width = 120;
            // 
            // GioiTinh
            // 
            this.GioiTinh.Caption = "Giới Tính";
            this.GioiTinh.FieldName = "GioiTinh";
            this.GioiTinh.MaxWidth = 80;
            this.GioiTinh.MinWidth = 80;
            this.GioiTinh.Name = "GioiTinh";
            this.GioiTinh.Visible = true;
            this.GioiTinh.VisibleIndex = 3;
            this.GioiTinh.Width = 80;
            // 
            // NgaySinh
            // 
            this.NgaySinh.Caption = "Ngày Sinh";
            this.NgaySinh.FieldName = "NgaySinh";
            this.NgaySinh.MaxWidth = 80;
            this.NgaySinh.MinWidth = 80;
            this.NgaySinh.Name = "NgaySinh";
            this.NgaySinh.Visible = true;
            this.NgaySinh.VisibleIndex = 4;
            this.NgaySinh.Width = 80;
            // 
            // DiaChi
            // 
            this.DiaChi.Caption = "Địa Chỉ";
            this.DiaChi.FieldName = "DiaChi";
            this.DiaChi.MaxWidth = 180;
            this.DiaChi.MinWidth = 180;
            this.DiaChi.Name = "DiaChi";
            this.DiaChi.Visible = true;
            this.DiaChi.VisibleIndex = 5;
            this.DiaChi.Width = 180;
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar2});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.btnCapNhat,
            this.btnSua,
            this.btnDong,
            this.btnHuy,
            this.btnLuu});
            this.barManager1.MainMenu = this.bar2;
            this.barManager1.MaxItemId = 11;
            // 
            // bar2
            // 
            this.bar2.BarName = "Main menu";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnCapNhat, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnDong, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnHuy, true),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnLuu, true)});
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.Caption = "Cập Nhật";
            this.btnCapNhat.Id = 0;
            this.btnCapNhat.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnCapNhat.ImageOptions.SvgImage")));
            this.btnCapNhat.Name = "btnCapNhat";
            // 
            // btnDong
            // 
            this.btnDong.Caption = "Đóng";
            this.btnDong.Id = 6;
            this.btnDong.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnDong.ImageOptions.SvgImage")));
            this.btnDong.Name = "btnDong";
            // 
            // btnHuy
            // 
            this.btnHuy.Caption = "Hủy";
            this.btnHuy.Id = 9;
            this.btnHuy.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnHuy.ImageOptions.Image")));
            this.btnHuy.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnHuy.ImageOptions.LargeImage")));
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            // 
            // btnLuu
            // 
            this.btnLuu.Caption = "Lưu";
            this.btnLuu.Id = 10;
            this.btnLuu.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnLuu.ImageOptions.Image")));
            this.btnLuu.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnLuu.ImageOptions.LargeImage")));
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(1251, 26);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 653);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(1251, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 26);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 627);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1251, 26);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 627);
            // 
            // btnSua
            // 
            this.btnSua.Caption = "Sửa";
            this.btnSua.Id = 1;
            this.btnSua.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnSua.ImageOptions.SvgImage")));
            this.btnSua.Name = "btnSua";
            // 
            // gcHocSinhLop
            // 
            this.gcHocSinhLop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcHocSinhLop.Location = new System.Drawing.Point(0, 0);
            this.gcHocSinhLop.MainView = this.gvHocSinhLop;
            this.gcHocSinhLop.MenuManager = this.barManager1;
            this.gcHocSinhLop.Name = "gcHocSinhLop";
            this.gcHocSinhLop.Size = new System.Drawing.Size(620, 520);
            this.gcHocSinhLop.TabIndex = 0;
            this.gcHocSinhLop.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvHocSinhLop});
            // 
            // gvHocSinhLop
            // 
            this.gvHocSinhLop.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.MaHSLop,
            this.HoTenLop,
            this.GioiTinhLop,
            this.NgaySinhLop,
            this.DiaChiLop,
            this.MaLop,
            this.TenLop});
            this.gvHocSinhLop.GridControl = this.gcHocSinhLop;
            this.gvHocSinhLop.Name = "gvHocSinhLop";
            // 
            // MaHSLop
            // 
            this.MaHSLop.Caption = "ID";
            this.MaHSLop.FieldName = "MaHS";
            this.MaHSLop.MaxWidth = 30;
            this.MaHSLop.MinWidth = 30;
            this.MaHSLop.Name = "MaHSLop";
            this.MaHSLop.Visible = true;
            this.MaHSLop.VisibleIndex = 0;
            this.MaHSLop.Width = 30;
            // 
            // HoTenLop
            // 
            this.HoTenLop.Caption = "Họ Tên";
            this.HoTenLop.FieldName = "HoTen";
            this.HoTenLop.MaxWidth = 120;
            this.HoTenLop.MinWidth = 120;
            this.HoTenLop.Name = "HoTenLop";
            this.HoTenLop.Visible = true;
            this.HoTenLop.VisibleIndex = 1;
            this.HoTenLop.Width = 120;
            // 
            // GioiTinhLop
            // 
            this.GioiTinhLop.Caption = "Giới Tính";
            this.GioiTinhLop.FieldName = "GioiTinh";
            this.GioiTinhLop.MaxWidth = 80;
            this.GioiTinhLop.MinWidth = 80;
            this.GioiTinhLop.Name = "GioiTinhLop";
            this.GioiTinhLop.Visible = true;
            this.GioiTinhLop.VisibleIndex = 2;
            this.GioiTinhLop.Width = 80;
            // 
            // NgaySinhLop
            // 
            this.NgaySinhLop.Caption = "Ngày Sinh";
            this.NgaySinhLop.FieldName = "NgaySinh";
            this.NgaySinhLop.MaxWidth = 80;
            this.NgaySinhLop.MinWidth = 80;
            this.NgaySinhLop.Name = "NgaySinhLop";
            this.NgaySinhLop.Visible = true;
            this.NgaySinhLop.VisibleIndex = 3;
            this.NgaySinhLop.Width = 80;
            // 
            // DiaChiLop
            // 
            this.DiaChiLop.Caption = "Địa Chỉ";
            this.DiaChiLop.FieldName = "DiaChi";
            this.DiaChiLop.MaxWidth = 180;
            this.DiaChiLop.MinWidth = 180;
            this.DiaChiLop.Name = "DiaChiLop";
            this.DiaChiLop.Visible = true;
            this.DiaChiLop.VisibleIndex = 4;
            this.DiaChiLop.Width = 180;
            // 
            // MaLop
            // 
            this.MaLop.Caption = "Mã Lớp";
            this.MaLop.FieldName = "MaLop";
            this.MaLop.MaxWidth = 80;
            this.MaLop.MinWidth = 80;
            this.MaLop.Name = "MaLop";
            this.MaLop.Width = 80;
            // 
            // TenLop
            // 
            this.TenLop.Caption = "Tên Lớp";
            this.TenLop.FieldName = "TenLop";
            this.TenLop.MaxWidth = 80;
            this.TenLop.MinWidth = 80;
            this.TenLop.Name = "TenLop";
            this.TenLop.Visible = true;
            this.TenLop.VisibleIndex = 5;
            this.TenLop.Width = 80;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.gcHocSinh);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.gcHocSinhLop);
            this.splitContainer2.Size = new System.Drawing.Size(1251, 520);
            this.splitContainer2.SplitterDistance = 627;
            this.splitContainer2.TabIndex = 0;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.Location = new System.Drawing.Point(0, 26);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.comboBox1);
            this.splitContainer1.Panel1.Controls.Add(this.labelControl1);
            this.splitContainer1.Panel1.Controls.Add(this.labelControl2);
            this.splitContainer1.Panel1.Controls.Add(this.comboBox2);
            this.splitContainer1.Panel1.Controls.Add(this.labelControl3);
            this.splitContainer1.Panel1.Controls.Add(this.cboNamHocChuyen);
            this.splitContainer1.Panel1.Controls.Add(this.cboLop);
            this.splitContainer1.Panel1.Controls.Add(this.labelControl4);
            this.splitContainer1.Panel1.Controls.Add(this.labelControl8);
            this.splitContainer1.Panel1.Controls.Add(this.cboKhoiLop);
            this.splitContainer1.Panel1.Controls.Add(this.labelControl5);
            this.splitContainer1.Panel1.Controls.Add(this.labelControl7);
            this.splitContainer1.Panel1.Controls.Add(this.cboNamHoc);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(1251, 627);
            this.splitContainer1.SplitterDistance = 103;
            this.splitContainer1.TabIndex = 10;
            // 
            // cboLop
            // 
            this.cboLop.FormattingEnabled = true;
            this.cboLop.Location = new System.Drawing.Point(96, 64);
            this.cboLop.Name = "cboLop";
            this.cboLop.Size = new System.Drawing.Size(116, 24);
            this.cboLop.TabIndex = 22;
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(239, 29);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(48, 16);
            this.labelControl4.TabIndex = 21;
            this.labelControl4.Text = "Khối Lớp";
            // 
            // labelControl8
            // 
            this.labelControl8.Location = new System.Drawing.Point(63, 67);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(20, 16);
            this.labelControl8.TabIndex = 20;
            this.labelControl8.Text = "Lớp";
            // 
            // cboKhoiLop
            // 
            this.cboKhoiLop.FormattingEnabled = true;
            this.cboKhoiLop.Location = new System.Drawing.Point(300, 24);
            this.cboKhoiLop.Name = "cboKhoiLop";
            this.cboKhoiLop.Size = new System.Drawing.Size(116, 24);
            this.cboKhoiLop.TabIndex = 18;
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold);
            this.labelControl5.Appearance.ForeColor = System.Drawing.Color.Red;
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Appearance.Options.UseForeColor = true;
            this.labelControl5.Location = new System.Drawing.Point(1178, 22);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(0, 16);
            this.labelControl5.TabIndex = 17;
            // 
            // labelControl7
            // 
            this.labelControl7.Location = new System.Drawing.Point(32, 29);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(51, 16);
            this.labelControl7.TabIndex = 14;
            this.labelControl7.Text = "Năm Học";
            // 
            // cboNamHoc
            // 
            this.cboNamHoc.FormattingEnabled = true;
            this.cboNamHoc.Location = new System.Drawing.Point(96, 24);
            this.cboNamHoc.Name = "cboNamHoc";
            this.cboNamHoc.Size = new System.Drawing.Size(116, 24);
            this.cboNamHoc.TabIndex = 11;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(844, 59);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(116, 24);
            this.comboBox1.TabIndex = 28;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(987, 24);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(48, 16);
            this.labelControl1.TabIndex = 27;
            this.labelControl1.Text = "Khối Lớp";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(811, 62);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(20, 16);
            this.labelControl2.TabIndex = 26;
            this.labelControl2.Text = "Lớp";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(1048, 19);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(116, 24);
            this.comboBox2.TabIndex = 25;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(780, 24);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(51, 16);
            this.labelControl3.TabIndex = 24;
            this.labelControl3.Text = "Năm Học";
            // 
            // cboNamHocChuyen
            // 
            this.cboNamHocChuyen.FormattingEnabled = true;
            this.cboNamHocChuyen.Location = new System.Drawing.Point(844, 19);
            this.cboNamHocChuyen.Name = "cboNamHocChuyen";
            this.cboNamHocChuyen.Size = new System.Drawing.Size(116, 24);
            this.cboNamHocChuyen.TabIndex = 23;
            // 
            // frmChuyenLop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1251, 653);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "frmChuyenLop";
            this.Text = "Chuyển Lớp";
            this.Load += new System.EventHandler(this.frmChuyenLop_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gcHocSinh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvHocSinh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcHocSinhLop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvHocSinhLop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).EndInit();
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gcHocSinh;
        private DevExpress.XtraGrid.Views.Grid.GridView gvHocSinh;
        private DevExpress.XtraGrid.Columns.GridColumn MaHS;
        private DevExpress.XtraGrid.Columns.GridColumn HoTen;
        private DevExpress.XtraGrid.Columns.GridColumn GioiTinh;
        private DevExpress.XtraGrid.Columns.GridColumn NgaySinh;
        private DevExpress.XtraGrid.Columns.GridColumn DiaChi;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.BarButtonItem btnCapNhat;
        private DevExpress.XtraBars.BarButtonItem btnDong;
        private DevExpress.XtraBars.BarButtonItem btnHuy;
        private DevExpress.XtraBars.BarButtonItem btnLuu;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ComboBox cboLop;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private System.Windows.Forms.ComboBox cboKhoiLop;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private System.Windows.Forms.ComboBox cboNamHoc;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private DevExpress.XtraGrid.GridControl gcHocSinhLop;
        private DevExpress.XtraGrid.Views.Grid.GridView gvHocSinhLop;
        private DevExpress.XtraGrid.Columns.GridColumn MaHSLop;
        private DevExpress.XtraGrid.Columns.GridColumn HoTenLop;
        private DevExpress.XtraGrid.Columns.GridColumn GioiTinhLop;
        private DevExpress.XtraGrid.Columns.GridColumn NgaySinhLop;
        private DevExpress.XtraGrid.Columns.GridColumn DiaChiLop;
        private DevExpress.XtraGrid.Columns.GridColumn MaLop;
        private DevExpress.XtraGrid.Columns.GridColumn TenLop;
        private DevExpress.XtraBars.BarButtonItem btnSua;
        private DevExpress.Utils.Behaviors.BehaviorManager behaviorManager1;
        private System.Windows.Forms.ComboBox comboBox1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private System.Windows.Forms.ComboBox comboBox2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private System.Windows.Forms.ComboBox cboNamHocChuyen;
    }
}