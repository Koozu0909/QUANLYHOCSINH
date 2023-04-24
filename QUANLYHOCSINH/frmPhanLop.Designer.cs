
namespace QUANLYHOCSINH
{
    partial class frmPhanLop
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPhanLop));
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.btnCapNhat = new DevExpress.XtraBars.BarButtonItem();
            this.btnDong = new DevExpress.XtraBars.BarButtonItem();
            this.btnXoa = new DevExpress.XtraBars.BarButtonItem();
            this.btnHuy = new DevExpress.XtraBars.BarButtonItem();
            this.btnLuu = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.btnSua = new DevExpress.XtraBars.BarButtonItem();
            this.cboLop = new System.Windows.Forms.ComboBox();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.cboKhoiLop = new System.Windows.Forms.ComboBox();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.cboNamHoc = new System.Windows.Forms.ComboBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.label1 = new System.Windows.Forms.Label();
            this.btnXoaHS = new System.Windows.Forms.Button();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.gcHocSinh = new DevExpress.XtraGrid.GridControl();
            this.gvHocSinh = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.MaHS = new DevExpress.XtraGrid.Columns.GridColumn();
            this.HoTen = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GioiTinh = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NgaySinh = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DiaChi = new DevExpress.XtraGrid.Columns.GridColumn();
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
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcHocSinh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvHocSinh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcHocSinhLop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvHocSinhLop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).BeginInit();
            this.SuspendLayout();
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
            this.btnXoa,
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
            new DevExpress.XtraBars.LinkPersistInfo(this.btnXoa, true),
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
            this.btnCapNhat.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnCapNhat_ItemClick);
            // 
            // btnDong
            // 
            this.btnDong.Caption = "Đóng";
            this.btnDong.Id = 6;
            this.btnDong.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnDong.ImageOptions.SvgImage")));
            this.btnDong.Name = "btnDong";
            this.btnDong.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnDong_ItemClick);
            // 
            // btnXoa
            // 
            this.btnXoa.Caption = "Xóa";
            this.btnXoa.Id = 8;
            this.btnXoa.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnXoa.ImageOptions.Image")));
            this.btnXoa.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnXoa.ImageOptions.LargeImage")));
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnXoa.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnXoa_ItemClick);
            // 
            // btnHuy
            // 
            this.btnHuy.Caption = "Hủy";
            this.btnHuy.Id = 9;
            this.btnHuy.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnHuy.ImageOptions.Image")));
            this.btnHuy.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnHuy.ImageOptions.LargeImage")));
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnHuy.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnHuy_ItemClick);
            // 
            // btnLuu
            // 
            this.btnLuu.Caption = "Lưu";
            this.btnLuu.Id = 10;
            this.btnLuu.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnLuu.ImageOptions.Image")));
            this.btnLuu.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnLuu.ImageOptions.LargeImage")));
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnLuu.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnLuu_ItemClick);
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(1077, 26);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 577);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(1077, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 26);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 551);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1077, 26);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 551);
            // 
            // btnSua
            // 
            this.btnSua.Caption = "Sửa";
            this.btnSua.Id = 1;
            this.btnSua.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnSua.ImageOptions.SvgImage")));
            this.btnSua.Name = "btnSua";
            // 
            // cboLop
            // 
            this.cboLop.FormattingEnabled = true;
            this.cboLop.Location = new System.Drawing.Point(96, 64);
            this.cboLop.Name = "cboLop";
            this.cboLop.Size = new System.Drawing.Size(202, 24);
            this.cboLop.TabIndex = 22;
            this.cboLop.SelectedIndexChanged += new System.EventHandler(this.cboLop_SelectedIndexChanged);
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(327, 30);
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
            this.cboKhoiLop.Location = new System.Drawing.Point(388, 25);
            this.cboKhoiLop.Name = "cboKhoiLop";
            this.cboKhoiLop.Size = new System.Drawing.Size(202, 24);
            this.cboKhoiLop.TabIndex = 18;
            this.cboKhoiLop.SelectedIndexChanged += new System.EventHandler(this.cboKhoiLop_SelectedIndexChanged);
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
            this.cboNamHoc.Size = new System.Drawing.Size(202, 24);
            this.cboNamHoc.TabIndex = 11;
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
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Controls.Add(this.btnXoaHS);
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
            this.splitContainer1.Size = new System.Drawing.Size(1077, 551);
            this.splitContainer1.SplitterDistance = 103;
            this.splitContainer1.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(645, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 16);
            this.label1.TabIndex = 23;
            this.label1.Text = "Xóa Học Sinh Đã Phân Lớp";
            // 
            // btnXoaHS
            // 
            this.btnXoaHS.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btnXoaHS.FlatAppearance.BorderSize = 50;
            this.btnXoaHS.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnXoaHS.ForeColor = System.Drawing.Color.Red;
            this.btnXoaHS.Location = new System.Drawing.Point(668, 60);
            this.btnXoaHS.Name = "btnXoaHS";
            this.btnXoaHS.Size = new System.Drawing.Size(115, 23);
            this.btnXoaHS.TabIndex = 14;
            this.btnXoaHS.Text = "Xóa Học Sinh";
            this.btnXoaHS.UseVisualStyleBackColor = true;
            this.btnXoaHS.Click += new System.EventHandler(this.btnXoaHS_Click);
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold);
            this.labelControl5.Appearance.ForeColor = System.Drawing.Color.Red;
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Appearance.Options.UseForeColor = true;
            this.labelControl5.Location = new System.Drawing.Point(914, 24);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(0, 16);
            this.labelControl5.TabIndex = 17;
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
            this.splitContainer2.Size = new System.Drawing.Size(1077, 444);
            this.splitContainer2.SplitterDistance = 540;
            this.splitContainer2.TabIndex = 0;
            // 
            // gcHocSinh
            // 
            this.gcHocSinh.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcHocSinh.Location = new System.Drawing.Point(0, 0);
            this.gcHocSinh.MainView = this.gvHocSinh;
            this.gcHocSinh.MenuManager = this.barManager1;
            this.gcHocSinh.Name = "gcHocSinh";
            this.gcHocSinh.Size = new System.Drawing.Size(540, 444);
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
            this.gvHocSinh.CustomDrawCell += new DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventHandler(this.gvHocSinh_CustomDrawCell);
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
            // gcHocSinhLop
            // 
            this.gcHocSinhLop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcHocSinhLop.Location = new System.Drawing.Point(0, 0);
            this.gcHocSinhLop.MainView = this.gvHocSinhLop;
            this.gcHocSinhLop.MenuManager = this.barManager1;
            this.gcHocSinhLop.Name = "gcHocSinhLop";
            this.gcHocSinhLop.Size = new System.Drawing.Size(533, 444);
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
            this.gvHocSinhLop.CustomDrawCell += new DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventHandler(this.gvHocSinhLop_CustomDrawCell);
            this.gvHocSinhLop.Click += new System.EventHandler(this.gvHocSinhLop_Click);
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
            // frmPhanLop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1077, 577);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "frmPhanLop";
            this.Text = "Phân Lớp";
            this.Load += new System.EventHandler(this.frmPhanLop_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcHocSinh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvHocSinh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcHocSinhLop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvHocSinhLop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.BarButtonItem btnCapNhat;
        private DevExpress.XtraBars.BarButtonItem btnDong;
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
        private DevExpress.XtraGrid.GridControl gcHocSinh;
        private DevExpress.XtraGrid.Views.Grid.GridView gvHocSinh;
        private DevExpress.XtraGrid.Columns.GridColumn MaHS;
        private DevExpress.XtraGrid.Columns.GridColumn HoTen;
        private DevExpress.XtraGrid.Columns.GridColumn GioiTinh;
        private DevExpress.XtraGrid.Columns.GridColumn NgaySinh;
        private DevExpress.XtraGrid.Columns.GridColumn DiaChi;
        private DevExpress.XtraGrid.GridControl gcHocSinhLop;
        private DevExpress.XtraGrid.Views.Grid.GridView gvHocSinhLop;
        private DevExpress.XtraGrid.Columns.GridColumn MaHSLop;
        private DevExpress.XtraGrid.Columns.GridColumn HoTenLop;
        private DevExpress.XtraGrid.Columns.GridColumn GioiTinhLop;
        private DevExpress.XtraGrid.Columns.GridColumn NgaySinhLop;
        private DevExpress.XtraGrid.Columns.GridColumn DiaChiLop;
        private DevExpress.XtraBars.BarButtonItem btnSua;
        private DevExpress.Utils.Behaviors.BehaviorManager behaviorManager1;
        private DevExpress.XtraGrid.Columns.GridColumn MaLop;
        private DevExpress.XtraGrid.Columns.GridColumn TenLop;
        private DevExpress.XtraBars.BarButtonItem btnXoa;
        private DevExpress.XtraBars.BarButtonItem btnHuy;
        private DevExpress.XtraBars.BarButtonItem btnLuu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnXoaHS;
    }
}