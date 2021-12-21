
namespace QLNGANHANG
{
    partial class frmKhachHang
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
            System.Windows.Forms.Label cMNDLabel;
            System.Windows.Forms.Label hOLabel;
            System.Windows.Forms.Label tENLabel;
            System.Windows.Forms.Label dIACHILabel;
            System.Windows.Forms.Label pHAILabel;
            System.Windows.Forms.Label nGAYCAPLabel;
            System.Windows.Forms.Label sODTLabel;
            System.Windows.Forms.Label mACNLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmKhachHang));
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.btn_Them = new DevExpress.XtraBars.BarButtonItem();
            this.btn_HieuChinh = new DevExpress.XtraBars.BarButtonItem();
            this.btn_Ghi = new DevExpress.XtraBars.BarButtonItem();
            this.btn_Xoa = new DevExpress.XtraBars.BarButtonItem();
            this.btn_PhucHoi = new DevExpress.XtraBars.BarButtonItem();
            this.btn_Reload = new DevExpress.XtraBars.BarButtonItem();
            this.btn_DanhSach = new DevExpress.XtraBars.BarButtonItem();
            this.btn_Thoat = new DevExpress.XtraBars.BarButtonItem();
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.cmb_CN = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.DS = new QLNGANHANG.DS();
            this.bdsKH = new System.Windows.Forms.BindingSource(this.components);
            this.khachHangTableAdapter = new QLNGANHANG.DSTableAdapters.KhachHangTableAdapter();
            this.tableAdapterManager = new QLNGANHANG.DSTableAdapters.TableAdapterManager();
            this.gcKhachHang = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colCMND = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TÊ = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDIACHI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPHAI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNGAYCAP = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSODT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMACN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panelControl_KH = new DevExpress.XtraEditors.PanelControl();
            this.txt_MaCN = new System.Windows.Forms.TextBox();
            this.txt_SoDT = new DevExpress.XtraEditors.TextEdit();
            this.de_NgayCap = new DevExpress.XtraEditors.DateEdit();
            this.cmb_Phai = new System.Windows.Forms.ComboBox();
            this.txt_DiaChi = new DevExpress.XtraEditors.TextEdit();
            this.txt_Ten = new System.Windows.Forms.TextBox();
            this.txt_Ho = new System.Windows.Forms.TextBox();
            this.txt_CMND = new System.Windows.Forms.TextBox();
            this.bdsTK = new System.Windows.Forms.BindingSource(this.components);
            this.taiKhoanTableAdapter = new QLNGANHANG.DSTableAdapters.TaiKhoanTableAdapter();
            this.ds1 = new QLNGANHANG.DS();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            cMNDLabel = new System.Windows.Forms.Label();
            hOLabel = new System.Windows.Forms.Label();
            tENLabel = new System.Windows.Forms.Label();
            dIACHILabel = new System.Windows.Forms.Label();
            pHAILabel = new System.Windows.Forms.Label();
            nGAYCAPLabel = new System.Windows.Forms.Label();
            sODTLabel = new System.Windows.Forms.Label();
            mACNLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsKH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcKhachHang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl_KH)).BeginInit();
            this.panelControl_KH.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_SoDT.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.de_NgayCap.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.de_NgayCap.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_DiaChi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsTK)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // cMNDLabel
            // 
            cMNDLabel.AutoSize = true;
            cMNDLabel.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cMNDLabel.Location = new System.Drawing.Point(96, 64);
            cMNDLabel.Name = "cMNDLabel";
            cMNDLabel.Size = new System.Drawing.Size(69, 21);
            cMNDLabel.TabIndex = 0;
            cMNDLabel.Text = "CMND:";
            // 
            // hOLabel
            // 
            hOLabel.AutoSize = true;
            hOLabel.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            hOLabel.Location = new System.Drawing.Point(96, 143);
            hOLabel.Name = "hOLabel";
            hOLabel.Size = new System.Drawing.Size(41, 21);
            hOLabel.TabIndex = 2;
            hOLabel.Text = "HỌ:";
            // 
            // tENLabel
            // 
            tENLabel.AutoSize = true;
            tENLabel.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            tENLabel.Location = new System.Drawing.Point(96, 220);
            tENLabel.Name = "tENLabel";
            tENLabel.Size = new System.Drawing.Size(50, 21);
            tENLabel.TabIndex = 4;
            tENLabel.Text = "TÊN:";
            // 
            // dIACHILabel
            // 
            dIACHILabel.AutoSize = true;
            dIACHILabel.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dIACHILabel.Location = new System.Drawing.Point(667, 143);
            dIACHILabel.Name = "dIACHILabel";
            dIACHILabel.Size = new System.Drawing.Size(83, 21);
            dIACHILabel.TabIndex = 6;
            dIACHILabel.Text = "ĐỊA CHỈ:";
            // 
            // pHAILabel
            // 
            pHAILabel.AutoSize = true;
            pHAILabel.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            pHAILabel.Location = new System.Drawing.Point(667, 64);
            pHAILabel.Name = "pHAILabel";
            pHAILabel.Size = new System.Drawing.Size(57, 21);
            pHAILabel.TabIndex = 8;
            pHAILabel.Text = "PHÁI:";
            // 
            // nGAYCAPLabel
            // 
            nGAYCAPLabel.AutoSize = true;
            nGAYCAPLabel.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nGAYCAPLabel.Location = new System.Drawing.Point(1451, 143);
            nGAYCAPLabel.Name = "nGAYCAPLabel";
            nGAYCAPLabel.Size = new System.Drawing.Size(108, 21);
            nGAYCAPLabel.TabIndex = 10;
            nGAYCAPLabel.Text = "NGÀY CẤP:";
            // 
            // sODTLabel
            // 
            sODTLabel.AutoSize = true;
            sODTLabel.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            sODTLabel.Location = new System.Drawing.Point(667, 220);
            sODTLabel.Name = "sODTLabel";
            sODTLabel.Size = new System.Drawing.Size(151, 21);
            sODTLabel.TabIndex = 12;
            sODTLabel.Text = "SỐ ĐIỆN THOẠI:";
            // 
            // mACNLabel
            // 
            mACNLabel.AutoSize = true;
            mACNLabel.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            mACNLabel.Location = new System.Drawing.Point(1451, 64);
            mACNLabel.Name = "mACNLabel";
            mACNLabel.Size = new System.Drawing.Size(150, 21);
            mACNLabel.TabIndex = 14;
            mACNLabel.Text = "MÃ CHI NHÁNH:";
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
            // btn_DanhSach
            // 
            this.btn_DanhSach.Border = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.btn_DanhSach.Caption = "In danh sách nhân viên";
            this.btn_DanhSach.Id = 6;
            this.btn_DanhSach.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_DanhSach.ImageOptions.Image")));
            this.btn_DanhSach.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btn_DanhSach.ImageOptions.LargeImage")));
            this.btn_DanhSach.Name = "btn_DanhSach";
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
            this.barDockControlTop.Size = new System.Drawing.Size(1912, 49);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 867);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(1912, 20);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 49);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 818);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1912, 49);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 818);
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.cmb_CN);
            this.panelControl1.Controls.Add(this.label1);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 49);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1912, 85);
            this.panelControl1.TabIndex = 10;
            // 
            // cmb_CN
            // 
            this.cmb_CN.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_CN.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_CN.FormattingEnabled = true;
            this.cmb_CN.Location = new System.Drawing.Point(208, 29);
            this.cmb_CN.Name = "cmb_CN";
            this.cmb_CN.Size = new System.Drawing.Size(281, 29);
            this.cmb_CN.TabIndex = 1;
            this.cmb_CN.SelectedIndexChanged += new System.EventHandler(this.cmb_CN_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(96, 32);
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
            // bdsKH
            // 
            this.bdsKH.DataMember = "KhachHang";
            this.bdsKH.DataSource = this.DS;
            // 
            // khachHangTableAdapter
            // 
            this.khachHangTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.GD_CHUYENTIENTableAdapter = null;
            this.tableAdapterManager.GD_GOIRUTTableAdapter = null;
            this.tableAdapterManager.KhachHangTableAdapter = this.khachHangTableAdapter;
            this.tableAdapterManager.NhanVienTableAdapter = null;
            this.tableAdapterManager.TaiKhoanTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = QLNGANHANG.DSTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // gcKhachHang
            // 
            this.gcKhachHang.DataSource = this.bdsKH;
            this.gcKhachHang.Dock = System.Windows.Forms.DockStyle.Top;
            this.gcKhachHang.Location = new System.Drawing.Point(0, 134);
            this.gcKhachHang.MainView = this.gridView1;
            this.gcKhachHang.MenuManager = this.barManager1;
            this.gcKhachHang.Name = "gcKhachHang";
            this.gcKhachHang.Size = new System.Drawing.Size(1912, 363);
            this.gcKhachHang.TabIndex = 11;
            this.gcKhachHang.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colCMND,
            this.colHO,
            this.TÊ,
            this.colDIACHI,
            this.colPHAI,
            this.colNGAYCAP,
            this.colSODT,
            this.colMACN});
            this.gridView1.DetailHeight = 404;
            this.gridView1.GridControl = this.gcKhachHang;
            this.gridView1.Name = "gridView1";
            // 
            // colCMND
            // 
            this.colCMND.FieldName = "CMND";
            this.colCMND.MinWidth = 23;
            this.colCMND.Name = "colCMND";
            this.colCMND.Visible = true;
            this.colCMND.VisibleIndex = 0;
            this.colCMND.Width = 87;
            // 
            // colHO
            // 
            this.colHO.Caption = "HỌ";
            this.colHO.FieldName = "HO";
            this.colHO.MinWidth = 23;
            this.colHO.Name = "colHO";
            this.colHO.Visible = true;
            this.colHO.VisibleIndex = 1;
            this.colHO.Width = 87;
            // 
            // TÊ
            // 
            this.TÊ.Caption = "TÊN";
            this.TÊ.FieldName = "TEN";
            this.TÊ.MinWidth = 23;
            this.TÊ.Name = "TÊ";
            this.TÊ.Visible = true;
            this.TÊ.VisibleIndex = 2;
            this.TÊ.Width = 87;
            // 
            // colDIACHI
            // 
            this.colDIACHI.Caption = "ĐỊA CHỈ";
            this.colDIACHI.FieldName = "DIACHI";
            this.colDIACHI.MinWidth = 23;
            this.colDIACHI.Name = "colDIACHI";
            this.colDIACHI.Visible = true;
            this.colDIACHI.VisibleIndex = 3;
            this.colDIACHI.Width = 87;
            // 
            // colPHAI
            // 
            this.colPHAI.Caption = "PHÁI";
            this.colPHAI.FieldName = "PHAI";
            this.colPHAI.MinWidth = 23;
            this.colPHAI.Name = "colPHAI";
            this.colPHAI.Visible = true;
            this.colPHAI.VisibleIndex = 4;
            this.colPHAI.Width = 87;
            // 
            // colNGAYCAP
            // 
            this.colNGAYCAP.Caption = "NGÀY CẤP";
            this.colNGAYCAP.DisplayFormat.FormatString = "dd/MM/yyyy";
            this.colNGAYCAP.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colNGAYCAP.FieldName = "NGAYCAP";
            this.colNGAYCAP.MinWidth = 23;
            this.colNGAYCAP.Name = "colNGAYCAP";
            this.colNGAYCAP.Visible = true;
            this.colNGAYCAP.VisibleIndex = 5;
            this.colNGAYCAP.Width = 87;
            // 
            // colSODT
            // 
            this.colSODT.Caption = "SỐ ĐIỆN THOẠI";
            this.colSODT.FieldName = "SODT";
            this.colSODT.MinWidth = 23;
            this.colSODT.Name = "colSODT";
            this.colSODT.Visible = true;
            this.colSODT.VisibleIndex = 6;
            this.colSODT.Width = 87;
            // 
            // colMACN
            // 
            this.colMACN.Caption = "MÃ CHI NHÁNH";
            this.colMACN.FieldName = "MACN";
            this.colMACN.MinWidth = 23;
            this.colMACN.Name = "colMACN";
            this.colMACN.Visible = true;
            this.colMACN.VisibleIndex = 7;
            this.colMACN.Width = 87;
            // 
            // panelControl_KH
            // 
            this.panelControl_KH.Controls.Add(mACNLabel);
            this.panelControl_KH.Controls.Add(this.txt_MaCN);
            this.panelControl_KH.Controls.Add(sODTLabel);
            this.panelControl_KH.Controls.Add(this.txt_SoDT);
            this.panelControl_KH.Controls.Add(nGAYCAPLabel);
            this.panelControl_KH.Controls.Add(this.de_NgayCap);
            this.panelControl_KH.Controls.Add(pHAILabel);
            this.panelControl_KH.Controls.Add(this.cmb_Phai);
            this.panelControl_KH.Controls.Add(dIACHILabel);
            this.panelControl_KH.Controls.Add(this.txt_DiaChi);
            this.panelControl_KH.Controls.Add(tENLabel);
            this.panelControl_KH.Controls.Add(this.txt_Ten);
            this.panelControl_KH.Controls.Add(hOLabel);
            this.panelControl_KH.Controls.Add(this.txt_Ho);
            this.panelControl_KH.Controls.Add(cMNDLabel);
            this.panelControl_KH.Controls.Add(this.txt_CMND);
            this.panelControl_KH.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl_KH.Location = new System.Drawing.Point(0, 497);
            this.panelControl_KH.Name = "panelControl_KH";
            this.panelControl_KH.Size = new System.Drawing.Size(1912, 370);
            this.panelControl_KH.TabIndex = 12;
            // 
            // txt_MaCN
            // 
            this.txt_MaCN.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsKH, "MACN", true));
            this.txt_MaCN.Enabled = false;
            this.txt_MaCN.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_MaCN.Location = new System.Drawing.Point(1632, 61);
            this.txt_MaCN.Name = "txt_MaCN";
            this.txt_MaCN.Size = new System.Drawing.Size(196, 29);
            this.txt_MaCN.TabIndex = 15;
            // 
            // txt_SoDT
            // 
            this.txt_SoDT.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsKH, "SODT", true));
            this.txt_SoDT.Location = new System.Drawing.Point(840, 217);
            this.txt_SoDT.MenuManager = this.barManager1;
            this.txt_SoDT.Name = "txt_SoDT";
            this.txt_SoDT.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_SoDT.Properties.Appearance.Options.UseFont = true;
            this.txt_SoDT.Size = new System.Drawing.Size(257, 28);
            this.txt_SoDT.TabIndex = 13;
            this.txt_SoDT.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_SoDT_KeyPress);
            this.txt_SoDT.Validating += new System.ComponentModel.CancelEventHandler(this.txt_SoDT_Validating);
            // 
            // de_NgayCap
            // 
            this.de_NgayCap.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsKH, "NGAYCAP", true));
            this.de_NgayCap.EditValue = null;
            this.de_NgayCap.Location = new System.Drawing.Point(1632, 140);
            this.de_NgayCap.MenuManager = this.barManager1;
            this.de_NgayCap.Name = "de_NgayCap";
            this.de_NgayCap.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.de_NgayCap.Properties.Appearance.Options.UseFont = true;
            this.de_NgayCap.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.de_NgayCap.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.de_NgayCap.Properties.DisplayFormat.FormatString = "dd/MM/yyyy";
            this.de_NgayCap.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.de_NgayCap.Properties.EditFormat.FormatString = "dd/MM/yyyy";
            this.de_NgayCap.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.de_NgayCap.Properties.Mask.EditMask = "dd/MM/yyyy";
            this.de_NgayCap.Size = new System.Drawing.Size(197, 28);
            this.de_NgayCap.TabIndex = 11;
            this.de_NgayCap.Validating += new System.ComponentModel.CancelEventHandler(this.de_NgayCap_Validating);
            // 
            // cmb_Phai
            // 
            this.cmb_Phai.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsKH, "PHAI", true));
            this.cmb_Phai.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Phai.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Phai.FormattingEnabled = true;
            this.cmb_Phai.Items.AddRange(new object[] {
            "",
            "Nam",
            "Nữ"});
            this.cmb_Phai.Location = new System.Drawing.Point(840, 61);
            this.cmb_Phai.Name = "cmb_Phai";
            this.cmb_Phai.Size = new System.Drawing.Size(167, 29);
            this.cmb_Phai.TabIndex = 9;
            this.cmb_Phai.Validating += new System.ComponentModel.CancelEventHandler(this.cmb_Phai_Validating);
            // 
            // txt_DiaChi
            // 
            this.txt_DiaChi.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsKH, "DIACHI", true));
            this.txt_DiaChi.Location = new System.Drawing.Point(840, 140);
            this.txt_DiaChi.MenuManager = this.barManager1;
            this.txt_DiaChi.Name = "txt_DiaChi";
            this.txt_DiaChi.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_DiaChi.Properties.Appearance.Options.UseFont = true;
            this.txt_DiaChi.Size = new System.Drawing.Size(473, 28);
            this.txt_DiaChi.TabIndex = 7;
            this.txt_DiaChi.Validating += new System.ComponentModel.CancelEventHandler(this.txt_DiaChi_Validating);
            // 
            // txt_Ten
            // 
            this.txt_Ten.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsKH, "TEN", true));
            this.txt_Ten.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Ten.Location = new System.Drawing.Point(222, 217);
            this.txt_Ten.Name = "txt_Ten";
            this.txt_Ten.Size = new System.Drawing.Size(235, 29);
            this.txt_Ten.TabIndex = 5;
            this.txt_Ten.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Ten_KeyPress);
            this.txt_Ten.Validating += new System.ComponentModel.CancelEventHandler(this.txt_Ten_Validating);
            // 
            // txt_Ho
            // 
            this.txt_Ho.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsKH, "HO", true));
            this.txt_Ho.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Ho.Location = new System.Drawing.Point(222, 140);
            this.txt_Ho.Name = "txt_Ho";
            this.txt_Ho.Size = new System.Drawing.Size(235, 29);
            this.txt_Ho.TabIndex = 3;
            this.txt_Ho.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Ho_KeyPress);
            this.txt_Ho.Validating += new System.ComponentModel.CancelEventHandler(this.txt_Ho_Validating);
            // 
            // txt_CMND
            // 
            this.txt_CMND.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsKH, "CMND", true));
            this.txt_CMND.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_CMND.Location = new System.Drawing.Point(222, 61);
            this.txt_CMND.Name = "txt_CMND";
            this.txt_CMND.Size = new System.Drawing.Size(235, 29);
            this.txt_CMND.TabIndex = 1;
            this.txt_CMND.TextChanged += new System.EventHandler(this.txt_CMND_TextChanged);
            this.txt_CMND.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_CMND_KeyPress);
            this.txt_CMND.Validating += new System.ComponentModel.CancelEventHandler(this.txt_CMND_Validating);
            // 
            // bdsTK
            // 
            this.bdsTK.DataMember = "FK_TaiKhoan_KhachHang";
            this.bdsTK.DataSource = this.bdsKH;
            // 
            // taiKhoanTableAdapter
            // 
            this.taiKhoanTableAdapter.ClearBeforeFill = true;
            // 
            // ds1
            // 
            this.ds1.DataSetName = "DS";
            this.ds1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // frmKhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1912, 887);
            this.Controls.Add(this.panelControl_KH);
            this.Controls.Add(this.gcKhachHang);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frmKhachHang";
            this.Text = "KHÁCH HÀNG";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmKhachHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsKH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcKhachHang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl_KH)).EndInit();
            this.panelControl_KH.ResumeLayout(false);
            this.panelControl_KH.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_SoDT.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.de_NgayCap.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.de_NgayCap.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_DiaChi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsTK)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds1)).EndInit();
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
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private System.Windows.Forms.BindingSource bdsKH;
        private DS DS;
        private DSTableAdapters.KhachHangTableAdapter khachHangTableAdapter;
        private DSTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraGrid.GridControl gcKhachHang;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colCMND;
        private DevExpress.XtraGrid.Columns.GridColumn colHO;
        private DevExpress.XtraGrid.Columns.GridColumn TÊ;
        private DevExpress.XtraGrid.Columns.GridColumn colDIACHI;
        private DevExpress.XtraGrid.Columns.GridColumn colPHAI;
        private DevExpress.XtraGrid.Columns.GridColumn colNGAYCAP;
        private DevExpress.XtraGrid.Columns.GridColumn colSODT;
        private DevExpress.XtraGrid.Columns.GridColumn colMACN;
        private DevExpress.XtraEditors.PanelControl panelControl_KH;
        private System.Windows.Forms.TextBox txt_MaCN;
        private DevExpress.XtraEditors.TextEdit txt_SoDT;
        private DevExpress.XtraEditors.DateEdit de_NgayCap;
        private System.Windows.Forms.ComboBox cmb_Phai;
        private DevExpress.XtraEditors.TextEdit txt_DiaChi;
        private System.Windows.Forms.TextBox txt_Ten;
        private System.Windows.Forms.TextBox txt_Ho;
        private System.Windows.Forms.TextBox txt_CMND;
        private System.Windows.Forms.ComboBox cmb_CN;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource bdsTK;
        private DSTableAdapters.TaiKhoanTableAdapter taiKhoanTableAdapter;
        private DS ds1;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}