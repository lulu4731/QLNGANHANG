
namespace QLNGANHANG
{
    partial class frmTaiKhoan
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
            System.Windows.Forms.Label cMNDLabel;
            System.Windows.Forms.Label sODULabel;
            System.Windows.Forms.Label mACNLabel;
            System.Windows.Forms.Label nGAYMOTKLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTaiKhoan));
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
            this.DS = new QLNGANHANG.DS();
            this.bdsTK = new System.Windows.Forms.BindingSource(this.components);
            this.taiKhoanTableAdapter = new QLNGANHANG.DSTableAdapters.TaiKhoanTableAdapter();
            this.tableAdapterManager = new QLNGANHANG.DSTableAdapters.TableAdapterManager();
            this.gcTaiKhoan = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colSOTK = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCMND = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSODU = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMACN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNGAYMOTK = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panelControl_TK = new DevExpress.XtraEditors.PanelControl();
            this.de_NgayMo = new DevExpress.XtraEditors.DateEdit();
            this.txt_MaCN = new DevExpress.XtraEditors.TextEdit();
            this.txt_SoDu = new DevExpress.XtraEditors.TextEdit();
            this.txt_CMND = new DevExpress.XtraEditors.TextEdit();
            this.txt_SoTK = new DevExpress.XtraEditors.TextEdit();
            this.behaviorManager1 = new DevExpress.Utils.Behaviors.BehaviorManager(this.components);
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.bds_CHUYENTIEN = new System.Windows.Forms.BindingSource(this.components);
            this.gD_CHUYENTIENTableAdapter = new QLNGANHANG.DSTableAdapters.GD_CHUYENTIENTableAdapter();
            this.bds_GOIRUT = new System.Windows.Forms.BindingSource(this.components);
            this.gD_GOIRUTTableAdapter = new QLNGANHANG.DSTableAdapters.GD_GOIRUTTableAdapter();
            sOTKLabel = new System.Windows.Forms.Label();
            cMNDLabel = new System.Windows.Forms.Label();
            sODULabel = new System.Windows.Forms.Label();
            mACNLabel = new System.Windows.Forms.Label();
            nGAYMOTKLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsTK)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcTaiKhoan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl_TK)).BeginInit();
            this.panelControl_TK.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.de_NgayMo.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.de_NgayMo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_MaCN.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_SoDu.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_CMND.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_SoTK.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bds_CHUYENTIEN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bds_GOIRUT)).BeginInit();
            this.SuspendLayout();
            // 
            // sOTKLabel
            // 
            sOTKLabel.AutoSize = true;
            sOTKLabel.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            sOTKLabel.Location = new System.Drawing.Point(244, 54);
            sOTKLabel.Name = "sOTKLabel";
            sOTKLabel.Size = new System.Drawing.Size(146, 21);
            sOTKLabel.TabIndex = 0;
            sOTKLabel.Text = "SỐ TÀI KHOẢN:";
            // 
            // cMNDLabel
            // 
            cMNDLabel.AutoSize = true;
            cMNDLabel.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cMNDLabel.Location = new System.Drawing.Point(321, 134);
            cMNDLabel.Name = "cMNDLabel";
            cMNDLabel.Size = new System.Drawing.Size(69, 21);
            cMNDLabel.TabIndex = 2;
            cMNDLabel.Text = "CMND:";
            // 
            // sODULabel
            // 
            sODULabel.AutoSize = true;
            sODULabel.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            sODULabel.Location = new System.Drawing.Point(321, 217);
            sODULabel.Name = "sODULabel";
            sODULabel.Size = new System.Drawing.Size(72, 21);
            sODULabel.TabIndex = 4;
            sODULabel.Text = "SỐ DƯ:";
            // 
            // mACNLabel
            // 
            mACNLabel.AutoSize = true;
            mACNLabel.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            mACNLabel.Location = new System.Drawing.Point(1044, 54);
            mACNLabel.Name = "mACNLabel";
            mACNLabel.Size = new System.Drawing.Size(150, 21);
            mACNLabel.TabIndex = 6;
            mACNLabel.Text = "MÃ CHI NHÁNH:";
            mACNLabel.Click += new System.EventHandler(this.mACNLabel_Click);
            // 
            // nGAYMOTKLabel
            // 
            nGAYMOTKLabel.AutoSize = true;
            nGAYMOTKLabel.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nGAYMOTKLabel.Location = new System.Drawing.Point(986, 134);
            nGAYMOTKLabel.Name = "nGAYMOTKLabel";
            nGAYMOTKLabel.Size = new System.Drawing.Size(208, 21);
            nGAYMOTKLabel.TabIndex = 8;
            nGAYMOTKLabel.Text = "NGÀY MỞ TÀI KHOẢN:";
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
            // btn_DanhSach
            // 
            this.btn_DanhSach.Border = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.btn_DanhSach.Caption = "In danh sách nhân viên";
            this.btn_DanhSach.Id = 6;
            this.btn_DanhSach.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_DanhSach.ImageOptions.Image")));
            this.btn_DanhSach.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btn_DanhSach.ImageOptions.LargeImage")));
            this.btn_DanhSach.Name = "btn_DanhSach";
            // 
            // DS
            // 
            this.DS.DataSetName = "DS";
            this.DS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bdsTK
            // 
            this.bdsTK.DataMember = "TaiKhoan";
            this.bdsTK.DataSource = this.DS;
            // 
            // taiKhoanTableAdapter
            // 
            this.taiKhoanTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.GD_CHUYENTIENTableAdapter = null;
            this.tableAdapterManager.GD_GOIRUTTableAdapter = null;
            this.tableAdapterManager.KhachHangTableAdapter = null;
            this.tableAdapterManager.NhanVienTableAdapter = null;
            this.tableAdapterManager.TaiKhoanTableAdapter = this.taiKhoanTableAdapter;
            this.tableAdapterManager.UpdateOrder = QLNGANHANG.DSTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // gcTaiKhoan
            // 
            this.gcTaiKhoan.DataSource = this.bdsTK;
            this.gcTaiKhoan.Dock = System.Windows.Forms.DockStyle.Top;
            this.gcTaiKhoan.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gcTaiKhoan.Location = new System.Drawing.Point(0, 49);
            this.gcTaiKhoan.MainView = this.gridView1;
            this.gcTaiKhoan.MenuManager = this.barManager1;
            this.gcTaiKhoan.Name = "gcTaiKhoan";
            this.gcTaiKhoan.Size = new System.Drawing.Size(1912, 385);
            this.gcTaiKhoan.TabIndex = 6;
            this.gcTaiKhoan.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colSOTK,
            this.colCMND,
            this.colSODU,
            this.colMACN,
            this.colNGAYMOTK});
            this.gridView1.GridControl = this.gcTaiKhoan;
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
            // colCMND
            // 
            this.colCMND.FieldName = "CMND";
            this.colCMND.Name = "colCMND";
            this.colCMND.Visible = true;
            this.colCMND.VisibleIndex = 1;
            // 
            // colSODU
            // 
            this.colSODU.Caption = "SỐ DƯ";
            this.colSODU.DisplayFormat.FormatString = "n0";
            this.colSODU.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colSODU.FieldName = "SODU";
            this.colSODU.Name = "colSODU";
            this.colSODU.Visible = true;
            this.colSODU.VisibleIndex = 2;
            // 
            // colMACN
            // 
            this.colMACN.Caption = "MÃ CHI NHÁNH";
            this.colMACN.FieldName = "MACN";
            this.colMACN.Name = "colMACN";
            this.colMACN.Visible = true;
            this.colMACN.VisibleIndex = 3;
            // 
            // colNGAYMOTK
            // 
            this.colNGAYMOTK.Caption = "NGÀY MỞ TÀI KHOẢN";
            this.colNGAYMOTK.DisplayFormat.FormatString = "dd/MM/yyyy";
            this.colNGAYMOTK.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colNGAYMOTK.FieldName = "NGAYMOTK";
            this.colNGAYMOTK.Name = "colNGAYMOTK";
            this.colNGAYMOTK.Visible = true;
            this.colNGAYMOTK.VisibleIndex = 4;
            // 
            // panelControl_TK
            // 
            this.panelControl_TK.Controls.Add(nGAYMOTKLabel);
            this.panelControl_TK.Controls.Add(this.de_NgayMo);
            this.panelControl_TK.Controls.Add(mACNLabel);
            this.panelControl_TK.Controls.Add(this.txt_MaCN);
            this.panelControl_TK.Controls.Add(sODULabel);
            this.panelControl_TK.Controls.Add(this.txt_SoDu);
            this.panelControl_TK.Controls.Add(cMNDLabel);
            this.panelControl_TK.Controls.Add(this.txt_CMND);
            this.panelControl_TK.Controls.Add(sOTKLabel);
            this.panelControl_TK.Controls.Add(this.txt_SoTK);
            this.panelControl_TK.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl_TK.Location = new System.Drawing.Point(0, 434);
            this.panelControl_TK.Name = "panelControl_TK";
            this.panelControl_TK.Size = new System.Drawing.Size(1912, 433);
            this.panelControl_TK.TabIndex = 7;
            // 
            // de_NgayMo
            // 
            this.de_NgayMo.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsTK, "NGAYMOTK", true));
            this.de_NgayMo.EditValue = null;
            this.de_NgayMo.Location = new System.Drawing.Point(1247, 131);
            this.de_NgayMo.MenuManager = this.barManager1;
            this.de_NgayMo.Name = "de_NgayMo";
            this.de_NgayMo.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.de_NgayMo.Properties.Appearance.Options.UseFont = true;
            this.de_NgayMo.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.de_NgayMo.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.de_NgayMo.Properties.DisplayFormat.FormatString = "dd/MM/yyyy";
            this.de_NgayMo.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.de_NgayMo.Properties.EditFormat.FormatString = "dd/MM/yyyy";
            this.de_NgayMo.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.de_NgayMo.Properties.Mask.EditMask = "dd/MM/yyyy";
            this.de_NgayMo.Size = new System.Drawing.Size(207, 28);
            this.de_NgayMo.TabIndex = 9;
            this.de_NgayMo.Validating += new System.ComponentModel.CancelEventHandler(this.de_NgayMo_Validating);
            // 
            // txt_MaCN
            // 
            this.txt_MaCN.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsTK, "MACN", true));
            this.txt_MaCN.Enabled = false;
            this.txt_MaCN.Location = new System.Drawing.Point(1247, 51);
            this.txt_MaCN.MenuManager = this.barManager1;
            this.txt_MaCN.Name = "txt_MaCN";
            this.txt_MaCN.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_MaCN.Properties.Appearance.Options.UseFont = true;
            this.txt_MaCN.Size = new System.Drawing.Size(207, 28);
            this.txt_MaCN.TabIndex = 7;
            // 
            // txt_SoDu
            // 
            this.txt_SoDu.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsTK, "SODU", true));
            this.txt_SoDu.Location = new System.Drawing.Point(466, 214);
            this.txt_SoDu.MenuManager = this.barManager1;
            this.txt_SoDu.Name = "txt_SoDu";
            this.txt_SoDu.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_SoDu.Properties.Appearance.Options.UseFont = true;
            this.txt_SoDu.Properties.DisplayFormat.FormatString = "n0";
            this.txt_SoDu.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txt_SoDu.Properties.EditFormat.FormatString = "n0";
            this.txt_SoDu.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txt_SoDu.Size = new System.Drawing.Size(314, 28);
            this.txt_SoDu.TabIndex = 5;
            this.txt_SoDu.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_SoDu_KeyPress);
            this.txt_SoDu.Validating += new System.ComponentModel.CancelEventHandler(this.txt_SoDu_Validating);
            // 
            // txt_CMND
            // 
            this.txt_CMND.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsTK, "CMND", true));
            this.txt_CMND.Location = new System.Drawing.Point(466, 131);
            this.txt_CMND.MenuManager = this.barManager1;
            this.txt_CMND.Name = "txt_CMND";
            this.txt_CMND.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_CMND.Properties.Appearance.Options.UseFont = true;
            this.txt_CMND.Size = new System.Drawing.Size(314, 28);
            this.txt_CMND.TabIndex = 3;
            this.txt_CMND.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_CMND_KeyPress);
            this.txt_CMND.Validating += new System.ComponentModel.CancelEventHandler(this.txt_CMND_Validating);
            // 
            // txt_SoTK
            // 
            this.txt_SoTK.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsTK, "SOTK", true));
            this.txt_SoTK.Location = new System.Drawing.Point(466, 51);
            this.txt_SoTK.MenuManager = this.barManager1;
            this.txt_SoTK.Name = "txt_SoTK";
            this.txt_SoTK.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_SoTK.Properties.Appearance.Options.UseFont = true;
            this.txt_SoTK.Size = new System.Drawing.Size(314, 28);
            this.txt_SoTK.TabIndex = 1;
            this.txt_SoTK.EditValueChanged += new System.EventHandler(this.txt_SoTK_EditValueChanged);
            this.txt_SoTK.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_SoTK_KeyPress);
            this.txt_SoTK.Validating += new System.ComponentModel.CancelEventHandler(this.txt_SoTK_Validating);
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // bds_CHUYENTIEN
            // 
            this.bds_CHUYENTIEN.DataMember = "FK_TaiKhoan_GD_CHUYENTIEN";
            this.bds_CHUYENTIEN.DataSource = this.bdsTK;
            // 
            // gD_CHUYENTIENTableAdapter
            // 
            this.gD_CHUYENTIENTableAdapter.ClearBeforeFill = true;
            // 
            // bds_GOIRUT
            // 
            this.bds_GOIRUT.DataMember = "FK_GD_GOIRUT_TaiKhoan";
            this.bds_GOIRUT.DataSource = this.bdsTK;
            // 
            // gD_GOIRUTTableAdapter
            // 
            this.gD_GOIRUTTableAdapter.ClearBeforeFill = true;
            // 
            // frmTaiKhoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1912, 887);
            this.Controls.Add(this.panelControl_TK);
            this.Controls.Add(this.gcTaiKhoan);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frmTaiKhoan";
            this.Text = "TÀI KHOẢN";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmTaiKhoan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsTK)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcTaiKhoan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl_TK)).EndInit();
            this.panelControl_TK.ResumeLayout(false);
            this.panelControl_TK.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.de_NgayMo.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.de_NgayMo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_MaCN.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_SoDu.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_CMND.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_SoTK.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bds_CHUYENTIEN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bds_GOIRUT)).EndInit();
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
        private System.Windows.Forms.BindingSource bdsTK;
        private DS DS;
        private DSTableAdapters.TaiKhoanTableAdapter taiKhoanTableAdapter;
        private DSTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraGrid.GridControl gcTaiKhoan;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.PanelControl panelControl_TK;
        private DevExpress.XtraGrid.Columns.GridColumn colSOTK;
        private DevExpress.XtraGrid.Columns.GridColumn colCMND;
        private DevExpress.XtraGrid.Columns.GridColumn colSODU;
        private DevExpress.XtraGrid.Columns.GridColumn colMACN;
        private DevExpress.XtraGrid.Columns.GridColumn colNGAYMOTK;
        private DevExpress.XtraEditors.DateEdit de_NgayMo;
        private DevExpress.XtraEditors.TextEdit txt_MaCN;
        private DevExpress.XtraEditors.TextEdit txt_SoDu;
        private DevExpress.XtraEditors.TextEdit txt_CMND;
        private DevExpress.XtraEditors.TextEdit txt_SoTK;
        private DevExpress.Utils.Behaviors.BehaviorManager behaviorManager1;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.BindingSource bds_CHUYENTIEN;
        private DSTableAdapters.GD_CHUYENTIENTableAdapter gD_CHUYENTIENTableAdapter;
        private System.Windows.Forms.BindingSource bds_GOIRUT;
        private DSTableAdapters.GD_GOIRUTTableAdapter gD_GOIRUTTableAdapter;
    }
}