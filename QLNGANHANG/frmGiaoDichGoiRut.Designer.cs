
namespace QLNGANHANG
{
    partial class frmGiaoDichGoiRut
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
            System.Windows.Forms.Label sOTKLabel;
            System.Windows.Forms.Label lOAIGDLabel;
            System.Windows.Forms.Label sOTIENLabel;
            System.Windows.Forms.Label mANVLabel;
            System.Windows.Forms.Label nGAYGDLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGiaoDichGoiRut));
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.btn_Them = new DevExpress.XtraBars.BarButtonItem();
            this.btn_HieuChinh = new DevExpress.XtraBars.BarButtonItem();
            this.btn_Ghi = new DevExpress.XtraBars.BarButtonItem();
            this.btn_Xoa = new DevExpress.XtraBars.BarButtonItem();
            this.btn_PhucHoi = new DevExpress.XtraBars.BarButtonItem();
            this.btn_Reload = new DevExpress.XtraBars.BarButtonItem();
            this.btn_Thoat = new DevExpress.XtraBars.BarButtonItem();
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.btn_DanhSach = new DevExpress.XtraBars.BarButtonItem();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.cmb_CN = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.DS = new QLNGANHANG.DS();
            this.bdsGR = new System.Windows.Forms.BindingSource(this.components);
            this.gD_GOIRUTTableAdapter = new QLNGANHANG.DSTableAdapters.GD_GOIRUTTableAdapter();
            this.tableAdapterManager = new QLNGANHANG.DSTableAdapters.TableAdapterManager();
            this.gcGoiRut = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colSOTK = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLOAIGD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNGAYGD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSOTIEN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMANV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panelControl_GR = new DevExpress.XtraEditors.PanelControl();
            this.de_NgayGD = new DevExpress.XtraEditors.DateEdit();
            this.txt_MaNV = new DevExpress.XtraEditors.TextEdit();
            this.txt_SoTien = new DevExpress.XtraEditors.TextEdit();
            this.cmb_LoaiGD = new System.Windows.Forms.ComboBox();
            this.txt_SoTK = new DevExpress.XtraEditors.TextEdit();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            sOTKLabel = new System.Windows.Forms.Label();
            lOAIGDLabel = new System.Windows.Forms.Label();
            sOTIENLabel = new System.Windows.Forms.Label();
            mANVLabel = new System.Windows.Forms.Label();
            nGAYGDLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsGR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcGoiRut)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl_GR)).BeginInit();
            this.panelControl_GR.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.de_NgayGD.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.de_NgayGD.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_MaNV.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_SoTien.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_SoTK.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // sOTKLabel
            // 
            sOTKLabel.AutoSize = true;
            sOTKLabel.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            sOTKLabel.Location = new System.Drawing.Point(148, 78);
            sOTKLabel.Name = "sOTKLabel";
            sOTKLabel.Size = new System.Drawing.Size(146, 21);
            sOTKLabel.TabIndex = 0;
            sOTKLabel.Text = "SỐ TÀI KHOẢN:";
            // 
            // lOAIGDLabel
            // 
            lOAIGDLabel.AutoSize = true;
            lOAIGDLabel.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lOAIGDLabel.Location = new System.Drawing.Point(148, 190);
            lOAIGDLabel.Name = "lOAIGDLabel";
            lOAIGDLabel.Size = new System.Drawing.Size(160, 21);
            lOAIGDLabel.TabIndex = 2;
            lOAIGDLabel.Text = "LOẠI GIAO DỊCH:";
            // 
            // sOTIENLabel
            // 
            sOTIENLabel.AutoSize = true;
            sOTIENLabel.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            sOTIENLabel.Location = new System.Drawing.Point(792, 78);
            sOTIENLabel.Name = "sOTIENLabel";
            sOTIENLabel.Size = new System.Drawing.Size(86, 21);
            sOTIENLabel.TabIndex = 6;
            sOTIENLabel.Text = "SỐ TIỀN:";
            // 
            // mANVLabel
            // 
            mANVLabel.AutoSize = true;
            mANVLabel.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            mANVLabel.Location = new System.Drawing.Point(1383, 78);
            mANVLabel.Name = "mANVLabel";
            mANVLabel.Size = new System.Drawing.Size(148, 21);
            mANVLabel.TabIndex = 8;
            mANVLabel.Text = "MÃ NHÂN VIÊN:";
            // 
            // nGAYGDLabel
            // 
            nGAYGDLabel.AutoSize = true;
            nGAYGDLabel.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nGAYGDLabel.Location = new System.Drawing.Point(792, 190);
            nGAYGDLabel.Name = "nGAYGDLabel";
            nGAYGDLabel.Size = new System.Drawing.Size(168, 21);
            nGAYGDLabel.TabIndex = 10;
            nGAYGDLabel.Text = "NGÀY GIAO DỊCH:";
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar1,
            this.bar2,
            this.bar3});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.btn_Them,
            this.btn_HieuChinh,
            this.btn_Ghi,
            this.btn_Xoa,
            this.btn_PhucHoi,
            this.btn_Reload,
            this.btn_DanhSach,
            this.btn_Thoat});
            this.barManager1.MainMenu = this.bar2;
            this.barManager1.MaxItemId = 8;
            this.barManager1.StatusBar = this.bar3;
            // 
            // bar1
            // 
            this.bar1.BarName = "Tools";
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 1;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btn_Them, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btn_HieuChinh, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btn_Ghi, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btn_Xoa, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btn_PhucHoi, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btn_Reload, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btn_Thoat, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar1.Text = "Tools";
            // 
            // btn_Them
            // 
            this.btn_Them.Border = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.btn_Them.Caption = "Thêm";
            this.btn_Them.Id = 0;
            this.btn_Them.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_Them.ImageOptions.Image")));
            this.btn_Them.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btn_Them.ImageOptions.LargeImage")));
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_Them_ItemClick);
            // 
            // btn_HieuChinh
            // 
            this.btn_HieuChinh.Border = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.btn_HieuChinh.Caption = "Hiệu chỉnh";
            this.btn_HieuChinh.Id = 1;
            this.btn_HieuChinh.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_HieuChinh.ImageOptions.Image")));
            this.btn_HieuChinh.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btn_HieuChinh.ImageOptions.LargeImage")));
            this.btn_HieuChinh.Name = "btn_HieuChinh";
            this.btn_HieuChinh.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            this.btn_HieuChinh.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_HieuChinh_ItemClick);
            // 
            // btn_Ghi
            // 
            this.btn_Ghi.Border = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.btn_Ghi.Caption = "Ghi";
            this.btn_Ghi.Id = 2;
            this.btn_Ghi.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_Ghi.ImageOptions.Image")));
            this.btn_Ghi.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btn_Ghi.ImageOptions.LargeImage")));
            this.btn_Ghi.Name = "btn_Ghi";
            this.btn_Ghi.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_Ghi_ItemClick);
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.Border = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.btn_Xoa.Caption = "Xóa";
            this.btn_Xoa.Id = 3;
            this.btn_Xoa.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_Xoa.ImageOptions.Image")));
            this.btn_Xoa.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btn_Xoa.ImageOptions.LargeImage")));
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            this.btn_Xoa.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_Xoa_ItemClick);
            // 
            // btn_PhucHoi
            // 
            this.btn_PhucHoi.Border = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.btn_PhucHoi.Caption = "Phục hồi";
            this.btn_PhucHoi.Id = 4;
            this.btn_PhucHoi.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_PhucHoi.ImageOptions.Image")));
            this.btn_PhucHoi.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btn_PhucHoi.ImageOptions.LargeImage")));
            this.btn_PhucHoi.Name = "btn_PhucHoi";
            this.btn_PhucHoi.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_PhucHoi_ItemClick);
            // 
            // btn_Reload
            // 
            this.btn_Reload.Border = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.btn_Reload.Caption = "Reload";
            this.btn_Reload.Id = 5;
            this.btn_Reload.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_Reload.ImageOptions.Image")));
            this.btn_Reload.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btn_Reload.ImageOptions.LargeImage")));
            this.btn_Reload.Name = "btn_Reload";
            this.btn_Reload.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_Reload_ItemClick);
            // 
            // btn_Thoat
            // 
            this.btn_Thoat.Border = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.btn_Thoat.Caption = "Thoát";
            this.btn_Thoat.Id = 7;
            this.btn_Thoat.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btn_Thoat.ImageOptions.SvgImage")));
            this.btn_Thoat.Name = "btn_Thoat";
            this.btn_Thoat.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_Thoat_ItemClick);
            // 
            // bar2
            // 
            this.bar2.BarName = "Main menu";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
            // 
            // bar3
            // 
            this.bar3.BarName = "Status bar";
            this.bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom;
            this.bar3.DockCol = 0;
            this.bar3.DockRow = 0;
            this.bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom;
            this.bar3.OptionsBar.AllowQuickCustomization = false;
            this.bar3.OptionsBar.DrawDragBorder = false;
            this.bar3.OptionsBar.UseWholeRow = true;
            this.bar3.Text = "Status bar";
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barDockControlTop.Appearance.Options.UseFont = true;
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(1910, 49);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 869);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(1910, 20);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 49);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 820);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1910, 49);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 820);
            // 
            // btn_DanhSach
            // 
            this.btn_DanhSach.Border = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.btn_DanhSach.Caption = "In danh sách nhân viên";
            this.btn_DanhSach.Id = 6;
            this.btn_DanhSach.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_DanhSach.ImageOptions.Image")));
            this.btn_DanhSach.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btn_DanhSach.ImageOptions.LargeImage")));
            this.btn_DanhSach.Name = "btn_DanhSach";
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.cmb_CN);
            this.panelControl1.Controls.Add(this.label1);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 49);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1910, 85);
            this.panelControl1.TabIndex = 4;
            // 
            // cmb_CN
            // 
            this.cmb_CN.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_CN.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_CN.FormattingEnabled = true;
            this.cmb_CN.Location = new System.Drawing.Point(271, 28);
            this.cmb_CN.Name = "cmb_CN";
            this.cmb_CN.Size = new System.Drawing.Size(310, 29);
            this.cmb_CN.TabIndex = 1;
            this.cmb_CN.SelectedIndexChanged += new System.EventHandler(this.cmb_CN_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(129, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Chi nhánh";
            // 
            // DS
            // 
            this.DS.DataSetName = "DS";
            this.DS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bdsGR
            // 
            this.bdsGR.DataMember = "GD_GOIRUT";
            this.bdsGR.DataSource = this.DS;
            // 
            // gD_GOIRUTTableAdapter
            // 
            this.gD_GOIRUTTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.GD_CHUYENTIENTableAdapter = null;
            this.tableAdapterManager.GD_GOIRUTTableAdapter = this.gD_GOIRUTTableAdapter;
            this.tableAdapterManager.KhachHangTableAdapter = null;
            this.tableAdapterManager.NhanVienTableAdapter = null;
            this.tableAdapterManager.TaiKhoanTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = QLNGANHANG.DSTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // gcGoiRut
            // 
            this.gcGoiRut.DataSource = this.bdsGR;
            this.gcGoiRut.Dock = System.Windows.Forms.DockStyle.Top;
            this.gcGoiRut.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gcGoiRut.Location = new System.Drawing.Point(0, 134);
            this.gcGoiRut.MainView = this.gridView1;
            this.gcGoiRut.MenuManager = this.barManager1;
            this.gcGoiRut.Name = "gcGoiRut";
            this.gcGoiRut.Size = new System.Drawing.Size(1910, 406);
            this.gcGoiRut.TabIndex = 6;
            this.gcGoiRut.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colSOTK,
            this.colLOAIGD,
            this.colNGAYGD,
            this.colSOTIEN,
            this.colMANV});
            this.gridView1.GridControl = this.gcGoiRut;
            this.gridView1.Name = "gridView1";
            // 
            // colSOTK
            // 
            this.colSOTK.Caption = "SỐ TÀI KHOẢN";
            this.colSOTK.FieldName = "SOTK";
            this.colSOTK.Name = "colSOTK";
            this.colSOTK.Visible = true;
            this.colSOTK.VisibleIndex = 0;
            // 
            // colLOAIGD
            // 
            this.colLOAIGD.Caption = "LOẠI GIAO DỊCH";
            this.colLOAIGD.FieldName = "LOAIGD";
            this.colLOAIGD.Name = "colLOAIGD";
            this.colLOAIGD.Visible = true;
            this.colLOAIGD.VisibleIndex = 1;
            // 
            // colNGAYGD
            // 
            this.colNGAYGD.Caption = "NGÀY GIAO DỊCH";
            this.colNGAYGD.DisplayFormat.FormatString = "dd/MM/yyyy";
            this.colNGAYGD.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colNGAYGD.FieldName = "NGAYGD";
            this.colNGAYGD.Name = "colNGAYGD";
            this.colNGAYGD.Visible = true;
            this.colNGAYGD.VisibleIndex = 2;
            // 
            // colSOTIEN
            // 
            this.colSOTIEN.Caption = "SỐ TIỀN";
            this.colSOTIEN.DisplayFormat.FormatString = "n0";
            this.colSOTIEN.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colSOTIEN.FieldName = "SOTIEN";
            this.colSOTIEN.Name = "colSOTIEN";
            this.colSOTIEN.Visible = true;
            this.colSOTIEN.VisibleIndex = 3;
            // 
            // colMANV
            // 
            this.colMANV.Caption = "MÃ NHÂN VIÊN";
            this.colMANV.FieldName = "MANV";
            this.colMANV.Name = "colMANV";
            this.colMANV.Visible = true;
            this.colMANV.VisibleIndex = 4;
            // 
            // panelControl_GR
            // 
            this.panelControl_GR.Controls.Add(nGAYGDLabel);
            this.panelControl_GR.Controls.Add(this.de_NgayGD);
            this.panelControl_GR.Controls.Add(mANVLabel);
            this.panelControl_GR.Controls.Add(this.txt_MaNV);
            this.panelControl_GR.Controls.Add(sOTIENLabel);
            this.panelControl_GR.Controls.Add(this.txt_SoTien);
            this.panelControl_GR.Controls.Add(lOAIGDLabel);
            this.panelControl_GR.Controls.Add(this.cmb_LoaiGD);
            this.panelControl_GR.Controls.Add(sOTKLabel);
            this.panelControl_GR.Controls.Add(this.txt_SoTK);
            this.panelControl_GR.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl_GR.Location = new System.Drawing.Point(0, 540);
            this.panelControl_GR.Name = "panelControl_GR";
            this.panelControl_GR.Size = new System.Drawing.Size(1910, 329);
            this.panelControl_GR.TabIndex = 7;
            // 
            // de_NgayGD
            // 
            this.de_NgayGD.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsGR, "NGAYGD", true));
            this.de_NgayGD.EditValue = null;
            this.de_NgayGD.Location = new System.Drawing.Point(995, 183);
            this.de_NgayGD.MenuManager = this.barManager1;
            this.de_NgayGD.Name = "de_NgayGD";
            this.de_NgayGD.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.de_NgayGD.Properties.Appearance.Options.UseFont = true;
            this.de_NgayGD.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.de_NgayGD.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.de_NgayGD.Properties.DisplayFormat.FormatString = "dd/MM/yyyy";
            this.de_NgayGD.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.de_NgayGD.Properties.EditFormat.FormatString = "dd/MM/yyyy";
            this.de_NgayGD.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.de_NgayGD.Properties.Mask.EditMask = "dd/MM/yyyy";
            this.de_NgayGD.Size = new System.Drawing.Size(236, 28);
            this.de_NgayGD.TabIndex = 11;
            this.de_NgayGD.Validating += new System.ComponentModel.CancelEventHandler(this.de_NgayGD_Validating);
            // 
            // txt_MaNV
            // 
            this.txt_MaNV.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsGR, "MANV", true));
            this.txt_MaNV.Enabled = false;
            this.txt_MaNV.Location = new System.Drawing.Point(1582, 75);
            this.txt_MaNV.MenuManager = this.barManager1;
            this.txt_MaNV.Name = "txt_MaNV";
            this.txt_MaNV.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_MaNV.Properties.Appearance.Options.UseFont = true;
            this.txt_MaNV.Size = new System.Drawing.Size(169, 28);
            this.txt_MaNV.TabIndex = 9;
            // 
            // txt_SoTien
            // 
            this.txt_SoTien.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsGR, "SOTIEN", true));
            this.txt_SoTien.Location = new System.Drawing.Point(995, 75);
            this.txt_SoTien.MenuManager = this.barManager1;
            this.txt_SoTien.Name = "txt_SoTien";
            this.txt_SoTien.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_SoTien.Properties.Appearance.Options.UseFont = true;
            this.txt_SoTien.Properties.DisplayFormat.FormatString = "n0";
            this.txt_SoTien.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txt_SoTien.Properties.EditFormat.FormatString = "n0";
            this.txt_SoTien.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txt_SoTien.Size = new System.Drawing.Size(283, 28);
            this.txt_SoTien.TabIndex = 7;
            this.txt_SoTien.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_SoTien_KeyPress);
            this.txt_SoTien.Validating += new System.ComponentModel.CancelEventHandler(this.txt_SoTien_Validating);
            // 
            // cmb_LoaiGD
            // 
            this.cmb_LoaiGD.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsGR, "LOAIGD", true));
            this.cmb_LoaiGD.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_LoaiGD.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_LoaiGD.FormattingEnabled = true;
            this.cmb_LoaiGD.Items.AddRange(new object[] {
            "",
            "GT",
            "RT"});
            this.cmb_LoaiGD.Location = new System.Drawing.Point(347, 187);
            this.cmb_LoaiGD.Name = "cmb_LoaiGD";
            this.cmb_LoaiGD.Size = new System.Drawing.Size(204, 29);
            this.cmb_LoaiGD.TabIndex = 3;
            this.cmb_LoaiGD.Validating += new System.ComponentModel.CancelEventHandler(this.cmb_LoaiGD_Validating);
            // 
            // txt_SoTK
            // 
            this.txt_SoTK.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsGR, "SOTK", true));
            this.txt_SoTK.Location = new System.Drawing.Point(347, 75);
            this.txt_SoTK.MenuManager = this.barManager1;
            this.txt_SoTK.Name = "txt_SoTK";
            this.txt_SoTK.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_SoTK.Properties.Appearance.Options.UseFont = true;
            this.txt_SoTK.Size = new System.Drawing.Size(278, 28);
            this.txt_SoTK.TabIndex = 1;
            this.txt_SoTK.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_SoTK_KeyPress);
            this.txt_SoTK.Validating += new System.ComponentModel.CancelEventHandler(this.txt_SoTK_Validating);
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // frmGiaoDichGoiRut
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1910, 889);
            this.Controls.Add(this.panelControl_GR);
            this.Controls.Add(this.gcGoiRut);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frmGiaoDichGoiRut";
            this.Text = "GIAO DỊCH GỞI RÚT";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmGiaoDichGoiRut_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsGR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcGoiRut)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl_GR)).EndInit();
            this.panelControl_GR.ResumeLayout(false);
            this.panelControl_GR.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.de_NgayGD.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.de_NgayGD.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_MaNV.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_SoTien.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_SoTK.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.BarButtonItem btn_Them;
        private DevExpress.XtraBars.BarButtonItem btn_HieuChinh;
        private DevExpress.XtraBars.BarButtonItem btn_Ghi;
        private DevExpress.XtraBars.BarButtonItem btn_Xoa;
        private DevExpress.XtraBars.BarButtonItem btn_PhucHoi;
        private DevExpress.XtraBars.BarButtonItem btn_Reload;
        private DevExpress.XtraBars.BarButtonItem btn_DanhSach;
        private DevExpress.XtraBars.BarButtonItem btn_Thoat;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private System.Windows.Forms.BindingSource bdsGR;
        private DS DS;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DSTableAdapters.GD_GOIRUTTableAdapter gD_GOIRUTTableAdapter;
        private DSTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraEditors.PanelControl panelControl_GR;
        private DevExpress.XtraGrid.GridControl gcGoiRut;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colSOTK;
        private DevExpress.XtraGrid.Columns.GridColumn colLOAIGD;
        private DevExpress.XtraGrid.Columns.GridColumn colNGAYGD;
        private DevExpress.XtraGrid.Columns.GridColumn colSOTIEN;
        private DevExpress.XtraGrid.Columns.GridColumn colMANV;
        private DevExpress.XtraEditors.DateEdit de_NgayGD;
        private DevExpress.XtraEditors.TextEdit txt_MaNV;
        private DevExpress.XtraEditors.TextEdit txt_SoTien;
        private System.Windows.Forms.ComboBox cmb_LoaiGD;
        private DevExpress.XtraEditors.TextEdit txt_SoTK;
        private System.Windows.Forms.ComboBox cmb_CN;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}