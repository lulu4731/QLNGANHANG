
namespace QLNGANHANG
{
    partial class frmGiaoDichChuyenTien
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
            System.Windows.Forms.Label sOTK_CHUYENLabel;
            System.Windows.Forms.Label sOTK_NHANLabel;
            System.Windows.Forms.Label sOTIENLabel;
            System.Windows.Forms.Label nGAYGDLabel;
            System.Windows.Forms.Label mANVLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGiaoDichChuyenTien));
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
            this.bdsCT = new System.Windows.Forms.BindingSource(this.components);
            this.gD_CHUYENTIENTableAdapter = new QLNGANHANG.DSTableAdapters.GD_CHUYENTIENTableAdapter();
            this.tableAdapterManager = new QLNGANHANG.DSTableAdapters.TableAdapterManager();
            this.gcChuyenTien = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colSOTK_CHUYEN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNGAYGD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSOTIEN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSOTK_NHAN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMANV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panelControl_CT = new DevExpress.XtraEditors.PanelControl();
            this.txt_MaNV = new DevExpress.XtraEditors.TextEdit();
            this.de_NgayGD = new DevExpress.XtraEditors.DateEdit();
            this.txt_SoT = new DevExpress.XtraEditors.TextEdit();
            this.txt_TKN = new DevExpress.XtraEditors.TextEdit();
            this.txt_TKC = new DevExpress.XtraEditors.TextEdit();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            sOTK_CHUYENLabel = new System.Windows.Forms.Label();
            sOTK_NHANLabel = new System.Windows.Forms.Label();
            sOTIENLabel = new System.Windows.Forms.Label();
            nGAYGDLabel = new System.Windows.Forms.Label();
            mANVLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsCT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcChuyenTien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl_CT)).BeginInit();
            this.panelControl_CT.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_MaNV.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.de_NgayGD.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.de_NgayGD.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_SoT.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_TKN.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_TKC.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // sOTK_CHUYENLabel
            // 
            sOTK_CHUYENLabel.AutoSize = true;
            sOTK_CHUYENLabel.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            sOTK_CHUYENLabel.Location = new System.Drawing.Point(127, 79);
            sOTK_CHUYENLabel.Name = "sOTK_CHUYENLabel";
            sOTK_CHUYENLabel.Size = new System.Drawing.Size(227, 21);
            sOTK_CHUYENLabel.TabIndex = 0;
            sOTK_CHUYENLabel.Text = "SỐ TÀI KHOẢN CHUYỂN:";
            // 
            // sOTK_NHANLabel
            // 
            sOTK_NHANLabel.AutoSize = true;
            sOTK_NHANLabel.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            sOTK_NHANLabel.Location = new System.Drawing.Point(127, 171);
            sOTK_NHANLabel.Name = "sOTK_NHANLabel";
            sOTK_NHANLabel.Size = new System.Drawing.Size(203, 21);
            sOTK_NHANLabel.TabIndex = 2;
            sOTK_NHANLabel.Text = "SỐ TÀI KHOẢN NHẬN:";
            // 
            // sOTIENLabel
            // 
            sOTIENLabel.AutoSize = true;
            sOTIENLabel.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            sOTIENLabel.Location = new System.Drawing.Point(772, 79);
            sOTIENLabel.Name = "sOTIENLabel";
            sOTIENLabel.Size = new System.Drawing.Size(86, 21);
            sOTIENLabel.TabIndex = 4;
            sOTIENLabel.Text = "SỐ TIỀN:";
            // 
            // nGAYGDLabel
            // 
            nGAYGDLabel.AutoSize = true;
            nGAYGDLabel.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nGAYGDLabel.Location = new System.Drawing.Point(772, 167);
            nGAYGDLabel.Name = "nGAYGDLabel";
            nGAYGDLabel.Size = new System.Drawing.Size(168, 21);
            nGAYGDLabel.TabIndex = 6;
            nGAYGDLabel.Text = "NGÀY GIAO DỊCH:";
            // 
            // mANVLabel
            // 
            mANVLabel.AutoSize = true;
            mANVLabel.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            mANVLabel.Location = new System.Drawing.Point(1370, 79);
            mANVLabel.Name = "mANVLabel";
            mANVLabel.Size = new System.Drawing.Size(148, 21);
            mANVLabel.TabIndex = 8;
            mANVLabel.Text = "MÃ NHÂN VIÊN:";
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
            this.btn_DanhSach.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_DanhSach_ItemClick);
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
            this.cmb_CN.Location = new System.Drawing.Point(255, 26);
            this.cmb_CN.Name = "cmb_CN";
            this.cmb_CN.Size = new System.Drawing.Size(287, 29);
            this.cmb_CN.TabIndex = 1;
            this.cmb_CN.SelectedIndexChanged += new System.EventHandler(this.cmb_CN_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(127, 29);
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
            // bdsCT
            // 
            this.bdsCT.DataMember = "GD_CHUYENTIEN";
            this.bdsCT.DataSource = this.DS;
            // 
            // gD_CHUYENTIENTableAdapter
            // 
            this.gD_CHUYENTIENTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.GD_CHUYENTIENTableAdapter = this.gD_CHUYENTIENTableAdapter;
            this.tableAdapterManager.GD_GOIRUTTableAdapter = null;
            this.tableAdapterManager.KhachHangTableAdapter = null;
            this.tableAdapterManager.NhanVienTableAdapter = null;
            this.tableAdapterManager.TaiKhoanTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = QLNGANHANG.DSTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // gcChuyenTien
            // 
            this.gcChuyenTien.DataSource = this.bdsCT;
            this.gcChuyenTien.Dock = System.Windows.Forms.DockStyle.Top;
            this.gcChuyenTien.Location = new System.Drawing.Point(0, 134);
            this.gcChuyenTien.MainView = this.gridView1;
            this.gcChuyenTien.MenuManager = this.barManager1;
            this.gcChuyenTien.Name = "gcChuyenTien";
            this.gcChuyenTien.Size = new System.Drawing.Size(1910, 391);
            this.gcChuyenTien.TabIndex = 6;
            this.gcChuyenTien.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colSOTK_CHUYEN,
            this.colNGAYGD,
            this.colSOTIEN,
            this.colSOTK_NHAN,
            this.colMANV});
            this.gridView1.GridControl = this.gcChuyenTien;
            this.gridView1.Name = "gridView1";
            // 
            // colSOTK_CHUYEN
            // 
            this.colSOTK_CHUYEN.Caption = "SỐ TÀI KHOẢN CHUYỂN";
            this.colSOTK_CHUYEN.FieldName = "SOTK_CHUYEN";
            this.colSOTK_CHUYEN.Name = "colSOTK_CHUYEN";
            this.colSOTK_CHUYEN.Visible = true;
            this.colSOTK_CHUYEN.VisibleIndex = 0;
            // 
            // colNGAYGD
            // 
            this.colNGAYGD.Caption = "NGÀY GIAO DỊCH";
            this.colNGAYGD.DisplayFormat.FormatString = "dd/MM/yyyy";
            this.colNGAYGD.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colNGAYGD.FieldName = "NGAYGD";
            this.colNGAYGD.Name = "colNGAYGD";
            this.colNGAYGD.Visible = true;
            this.colNGAYGD.VisibleIndex = 1;
            // 
            // colSOTIEN
            // 
            this.colSOTIEN.Caption = "SỐ TIỀN";
            this.colSOTIEN.DisplayFormat.FormatString = "n0";
            this.colSOTIEN.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colSOTIEN.FieldName = "SOTIEN";
            this.colSOTIEN.Name = "colSOTIEN";
            this.colSOTIEN.Visible = true;
            this.colSOTIEN.VisibleIndex = 2;
            // 
            // colSOTK_NHAN
            // 
            this.colSOTK_NHAN.Caption = "SỐ TÀI KHOẢN NHẬN";
            this.colSOTK_NHAN.FieldName = "SOTK_NHAN";
            this.colSOTK_NHAN.Name = "colSOTK_NHAN";
            this.colSOTK_NHAN.Visible = true;
            this.colSOTK_NHAN.VisibleIndex = 3;
            // 
            // colMANV
            // 
            this.colMANV.Caption = "MÃ NHÂN VIÊN";
            this.colMANV.FieldName = "MANV";
            this.colMANV.Name = "colMANV";
            this.colMANV.Visible = true;
            this.colMANV.VisibleIndex = 4;
            // 
            // panelControl_CT
            // 
            this.panelControl_CT.Controls.Add(mANVLabel);
            this.panelControl_CT.Controls.Add(this.txt_MaNV);
            this.panelControl_CT.Controls.Add(nGAYGDLabel);
            this.panelControl_CT.Controls.Add(this.de_NgayGD);
            this.panelControl_CT.Controls.Add(sOTIENLabel);
            this.panelControl_CT.Controls.Add(this.txt_SoT);
            this.panelControl_CT.Controls.Add(sOTK_NHANLabel);
            this.panelControl_CT.Controls.Add(this.txt_TKN);
            this.panelControl_CT.Controls.Add(sOTK_CHUYENLabel);
            this.panelControl_CT.Controls.Add(this.txt_TKC);
            this.panelControl_CT.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl_CT.Location = new System.Drawing.Point(0, 525);
            this.panelControl_CT.Name = "panelControl_CT";
            this.panelControl_CT.Size = new System.Drawing.Size(1910, 344);
            this.panelControl_CT.TabIndex = 7;
            // 
            // txt_MaNV
            // 
            this.txt_MaNV.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsCT, "MANV", true));
            this.txt_MaNV.Enabled = false;
            this.txt_MaNV.Location = new System.Drawing.Point(1548, 76);
            this.txt_MaNV.MenuManager = this.barManager1;
            this.txt_MaNV.Name = "txt_MaNV";
            this.txt_MaNV.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_MaNV.Properties.Appearance.Options.UseFont = true;
            this.txt_MaNV.Size = new System.Drawing.Size(187, 28);
            this.txt_MaNV.TabIndex = 9;
            // 
            // de_NgayGD
            // 
            this.de_NgayGD.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsCT, "NGAYGD", true));
            this.de_NgayGD.EditValue = null;
            this.de_NgayGD.Location = new System.Drawing.Point(990, 164);
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
            this.de_NgayGD.Size = new System.Drawing.Size(270, 28);
            this.de_NgayGD.TabIndex = 7;
            this.de_NgayGD.Validating += new System.ComponentModel.CancelEventHandler(this.de_NgayGD_Validating);
            // 
            // txt_SoT
            // 
            this.txt_SoT.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsCT, "SOTIEN", true));
            this.txt_SoT.Location = new System.Drawing.Point(990, 76);
            this.txt_SoT.MenuManager = this.barManager1;
            this.txt_SoT.Name = "txt_SoT";
            this.txt_SoT.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_SoT.Properties.Appearance.Options.UseFont = true;
            this.txt_SoT.Properties.DisplayFormat.FormatString = "n0";
            this.txt_SoT.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txt_SoT.Properties.EditFormat.FormatString = "n0";
            this.txt_SoT.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txt_SoT.Size = new System.Drawing.Size(270, 28);
            this.txt_SoT.TabIndex = 5;
            this.txt_SoT.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_SoT_KeyPress);
            this.txt_SoT.Validating += new System.ComponentModel.CancelEventHandler(this.txt_SoT_Validating);
            // 
            // txt_TKN
            // 
            this.txt_TKN.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsCT, "SOTK_NHAN", true));
            this.txt_TKN.Location = new System.Drawing.Point(410, 168);
            this.txt_TKN.MenuManager = this.barManager1;
            this.txt_TKN.Name = "txt_TKN";
            this.txt_TKN.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_TKN.Properties.Appearance.Options.UseFont = true;
            this.txt_TKN.Size = new System.Drawing.Size(248, 28);
            this.txt_TKN.TabIndex = 3;
            this.txt_TKN.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_TKN_KeyPress);
            this.txt_TKN.Validating += new System.ComponentModel.CancelEventHandler(this.txt_TKN_Validating);
            // 
            // txt_TKC
            // 
            this.txt_TKC.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsCT, "SOTK_CHUYEN", true));
            this.txt_TKC.Location = new System.Drawing.Point(410, 76);
            this.txt_TKC.MenuManager = this.barManager1;
            this.txt_TKC.Name = "txt_TKC";
            this.txt_TKC.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_TKC.Properties.Appearance.Options.UseFont = true;
            this.txt_TKC.Size = new System.Drawing.Size(248, 28);
            this.txt_TKC.TabIndex = 1;
            this.txt_TKC.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_TKC_KeyPress);
            this.txt_TKC.Validating += new System.ComponentModel.CancelEventHandler(this.txt_TKC_Validating);
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // frmGiaoDichChuyenTien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1910, 889);
            this.Controls.Add(this.panelControl_CT);
            this.Controls.Add(this.gcChuyenTien);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frmGiaoDichChuyenTien";
            this.Text = "GIAO DỊCH CHUYỂN TIỀN";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmGiaoDichChuyenTien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsCT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcChuyenTien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl_CT)).EndInit();
            this.panelControl_CT.ResumeLayout(false);
            this.panelControl_CT.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_MaNV.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.de_NgayGD.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.de_NgayGD.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_SoT.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_TKN.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_TKC.Properties)).EndInit();
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
        private System.Windows.Forms.BindingSource bdsCT;
        private DS DS;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DSTableAdapters.GD_CHUYENTIENTableAdapter gD_CHUYENTIENTableAdapter;
        private DSTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraEditors.PanelControl panelControl_CT;
        private DevExpress.XtraEditors.TextEdit txt_MaNV;
        private DevExpress.XtraEditors.DateEdit de_NgayGD;
        private DevExpress.XtraEditors.TextEdit txt_SoT;
        private DevExpress.XtraEditors.TextEdit txt_TKN;
        private DevExpress.XtraEditors.TextEdit txt_TKC;
        private DevExpress.XtraGrid.GridControl gcChuyenTien;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colSOTK_CHUYEN;
        private DevExpress.XtraGrid.Columns.GridColumn colNGAYGD;
        private DevExpress.XtraGrid.Columns.GridColumn colSOTIEN;
        private DevExpress.XtraGrid.Columns.GridColumn colSOTK_NHAN;
        private DevExpress.XtraGrid.Columns.GridColumn colMANV;
        private System.Windows.Forms.ComboBox cmb_CN;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}