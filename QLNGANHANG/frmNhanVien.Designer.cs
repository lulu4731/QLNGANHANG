
namespace QLNGANHANG
{
    partial class frmNhanVien
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
            System.Windows.Forms.Label mANVLabel;
            System.Windows.Forms.Label hOLabel;
            System.Windows.Forms.Label tENLabel;
            System.Windows.Forms.Label rd_TTX;
            System.Windows.Forms.Label pHAILabel;
            System.Windows.Forms.Label sODTLabel;
            System.Windows.Forms.Label dIACHILabel;
            System.Windows.Forms.Label mACNLabel1;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNhanVien));
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
            this.bdsNV = new System.Windows.Forms.BindingSource(this.components);
            this.nhanVienTableAdapter = new QLNGANHANG.DSTableAdapters.NhanVienTableAdapter();
            this.tableAdapterManager = new QLNGANHANG.DSTableAdapters.TableAdapterManager();
            this.gcNhanVien = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMANV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTEN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDIACHI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPHAI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSODT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMACN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTrangThaiXoa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panelControl_NV = new DevExpress.XtraEditors.PanelControl();
            this.txt_maCN = new DevExpress.XtraEditors.TextEdit();
            this.txt_DiaChi = new DevExpress.XtraEditors.TextEdit();
            this.txt_SDT = new DevExpress.XtraEditors.TextEdit();
            this.cmb_Phai = new System.Windows.Forms.ComboBox();
            this.cb_TTX = new System.Windows.Forms.CheckBox();
            this.txt_Ten = new System.Windows.Forms.TextBox();
            this.txt_Ho = new System.Windows.Forms.TextBox();
            this.txt_MaNV = new System.Windows.Forms.TextBox();
            this.bds_GOIRUT = new System.Windows.Forms.BindingSource(this.components);
            this.gD_GOIRUTTableAdapter = new QLNGANHANG.DSTableAdapters.GD_GOIRUTTableAdapter();
            this.bds_CHUYENTIEN = new System.Windows.Forms.BindingSource(this.components);
            this.gD_CHUYENTIENTableAdapter = new QLNGANHANG.DSTableAdapters.GD_CHUYENTIENTableAdapter();
            this.nhanVienTableAdapter1 = new QLNGANHANG.DSTableAdapters.NhanVienTableAdapter();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            mANVLabel = new System.Windows.Forms.Label();
            hOLabel = new System.Windows.Forms.Label();
            tENLabel = new System.Windows.Forms.Label();
            rd_TTX = new System.Windows.Forms.Label();
            pHAILabel = new System.Windows.Forms.Label();
            sODTLabel = new System.Windows.Forms.Label();
            dIACHILabel = new System.Windows.Forms.Label();
            mACNLabel1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsNV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcNhanVien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl_NV)).BeginInit();
            this.panelControl_NV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_maCN.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_DiaChi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_SDT.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bds_GOIRUT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bds_CHUYENTIEN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // mANVLabel
            // 
            mANVLabel.AutoSize = true;
            mANVLabel.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            mANVLabel.Location = new System.Drawing.Point(105, 46);
            mANVLabel.Name = "mANVLabel";
            mANVLabel.Size = new System.Drawing.Size(148, 21);
            mANVLabel.TabIndex = 0;
            mANVLabel.Text = "MÃ NHÂN VIÊN:";
            // 
            // hOLabel
            // 
            hOLabel.AutoSize = true;
            hOLabel.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            hOLabel.Location = new System.Drawing.Point(105, 116);
            hOLabel.Name = "hOLabel";
            hOLabel.Size = new System.Drawing.Size(41, 21);
            hOLabel.TabIndex = 2;
            hOLabel.Text = "HỌ:";
            // 
            // tENLabel
            // 
            tENLabel.AutoSize = true;
            tENLabel.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            tENLabel.Location = new System.Drawing.Point(105, 192);
            tENLabel.Name = "tENLabel";
            tENLabel.Size = new System.Drawing.Size(50, 21);
            tENLabel.TabIndex = 4;
            tENLabel.Text = "TÊN:";
            // 
            // rd_TTX
            // 
            rd_TTX.AutoSize = true;
            rd_TTX.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            rd_TTX.Location = new System.Drawing.Point(1517, 124);
            rd_TTX.Name = "rd_TTX";
            rd_TTX.Size = new System.Drawing.Size(173, 21);
            rd_TTX.TabIndex = 6;
            rd_TTX.Text = "TRẠNG THÁI XÓA:";
            // 
            // pHAILabel
            // 
            pHAILabel.AutoSize = true;
            pHAILabel.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            pHAILabel.Location = new System.Drawing.Point(805, 46);
            pHAILabel.Name = "pHAILabel";
            pHAILabel.Size = new System.Drawing.Size(57, 21);
            pHAILabel.TabIndex = 8;
            pHAILabel.Text = "PHÁI:";
            // 
            // sODTLabel
            // 
            sODTLabel.AutoSize = true;
            sODTLabel.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            sODTLabel.Location = new System.Drawing.Point(805, 116);
            sODTLabel.Name = "sODTLabel";
            sODTLabel.Size = new System.Drawing.Size(156, 21);
            sODTLabel.TabIndex = 10;
            sODTLabel.Text = "SỐ ĐIỆN THOẠI :";
            // 
            // dIACHILabel
            // 
            dIACHILabel.AutoSize = true;
            dIACHILabel.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dIACHILabel.Location = new System.Drawing.Point(805, 192);
            dIACHILabel.Name = "dIACHILabel";
            dIACHILabel.Size = new System.Drawing.Size(83, 21);
            dIACHILabel.TabIndex = 12;
            dIACHILabel.Text = "ĐỊA CHỈ:";
            // 
            // mACNLabel1
            // 
            mACNLabel1.AutoSize = true;
            mACNLabel1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            mACNLabel1.Location = new System.Drawing.Point(1517, 46);
            mACNLabel1.Name = "mACNLabel1";
            mACNLabel1.Size = new System.Drawing.Size(150, 21);
            mACNLabel1.TabIndex = 16;
            mACNLabel1.Text = "MÃ CHI NHÁNH:";
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
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btn_DanhSach, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
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
            this.btn_DanhSach.Caption = "Chuyển chi nhánh nhân viên";
            this.btn_DanhSach.Id = 6;
            this.btn_DanhSach.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_DanhSach.ImageOptions.Image")));
            this.btn_DanhSach.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btn_DanhSach.ImageOptions.LargeImage")));
            this.btn_DanhSach.Name = "btn_DanhSach";
            this.btn_DanhSach.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_DanhSach_ItemClick);
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
            this.panelControl1.TabIndex = 4;
            // 
            // cmb_CN
            // 
            this.cmb_CN.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_CN.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_CN.FormattingEnabled = true;
            this.cmb_CN.Location = new System.Drawing.Point(232, 26);
            this.cmb_CN.Name = "cmb_CN";
            this.cmb_CN.Size = new System.Drawing.Size(349, 29);
            this.cmb_CN.TabIndex = 1;
            this.cmb_CN.SelectedIndexChanged += new System.EventHandler(this.cmb_CN_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(74, 29);
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
            // bdsNV
            // 
            this.bdsNV.DataMember = "NhanVien";
            this.bdsNV.DataSource = this.DS;
            // 
            // nhanVienTableAdapter
            // 
            this.nhanVienTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.GD_CHUYENTIENTableAdapter = null;
            this.tableAdapterManager.GD_GOIRUTTableAdapter = null;
            this.tableAdapterManager.KhachHangTableAdapter = null;
            this.tableAdapterManager.NhanVienTableAdapter = this.nhanVienTableAdapter;
            this.tableAdapterManager.TaiKhoanTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = QLNGANHANG.DSTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // gcNhanVien
            // 
            this.gcNhanVien.DataSource = this.bdsNV;
            this.gcNhanVien.Dock = System.Windows.Forms.DockStyle.Top;
            this.gcNhanVien.Location = new System.Drawing.Point(0, 134);
            this.gcNhanVien.MainView = this.gridView1;
            this.gcNhanVien.MenuManager = this.barManager1;
            this.gcNhanVien.Name = "gcNhanVien";
            this.gcNhanVien.Size = new System.Drawing.Size(1912, 391);
            this.gcNhanVien.TabIndex = 6;
            this.gcNhanVien.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.gcNhanVien.Click += new System.EventHandler(this.nhanVienGridControl_Click);
            // 
            // gridView1
            // 
            this.gridView1.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.Aqua;
            this.gridView1.Appearance.ColumnFilterButton.BackColor2 = System.Drawing.Color.Aqua;
            this.gridView1.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.Aqua;
            this.gridView1.Appearance.ColumnFilterButton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridView1.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.Aqua;
            this.gridView1.Appearance.ColumnFilterButton.Options.UseBackColor = true;
            this.gridView1.Appearance.ColumnFilterButton.Options.UseBorderColor = true;
            this.gridView1.Appearance.ColumnFilterButton.Options.UseFont = true;
            this.gridView1.Appearance.ColumnFilterButton.Options.UseForeColor = true;
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMANV,
            this.colHO,
            this.colTEN,
            this.colDIACHI,
            this.colPHAI,
            this.colSODT,
            this.colMACN,
            this.colTrangThaiXoa});
            this.gridView1.GridControl = this.gcNhanVien;
            this.gridView1.Name = "gridView1";
            // 
            // colMANV
            // 
            this.colMANV.Caption = "MÃ NHÂN VIÊN";
            this.colMANV.FieldName = "MANV";
            this.colMANV.Name = "colMANV";
            this.colMANV.Visible = true;
            this.colMANV.VisibleIndex = 0;
            // 
            // colHO
            // 
            this.colHO.Caption = "HỌ";
            this.colHO.FieldName = "HO";
            this.colHO.Name = "colHO";
            this.colHO.Visible = true;
            this.colHO.VisibleIndex = 1;
            // 
            // colTEN
            // 
            this.colTEN.Caption = "TÊN";
            this.colTEN.FieldName = "TEN";
            this.colTEN.Name = "colTEN";
            this.colTEN.Visible = true;
            this.colTEN.VisibleIndex = 2;
            // 
            // colDIACHI
            // 
            this.colDIACHI.Caption = "ĐỊA CHỈ";
            this.colDIACHI.FieldName = "DIACHI";
            this.colDIACHI.Name = "colDIACHI";
            this.colDIACHI.Visible = true;
            this.colDIACHI.VisibleIndex = 3;
            // 
            // colPHAI
            // 
            this.colPHAI.Caption = "PHÁI";
            this.colPHAI.FieldName = "PHAI";
            this.colPHAI.Name = "colPHAI";
            this.colPHAI.Visible = true;
            this.colPHAI.VisibleIndex = 4;
            // 
            // colSODT
            // 
            this.colSODT.Caption = "SỐ ĐIỆN THOẠI";
            this.colSODT.FieldName = "SODT";
            this.colSODT.Name = "colSODT";
            this.colSODT.Visible = true;
            this.colSODT.VisibleIndex = 5;
            // 
            // colMACN
            // 
            this.colMACN.Caption = "MÃ CHI NHÁNH";
            this.colMACN.FieldName = "MACN";
            this.colMACN.Name = "colMACN";
            this.colMACN.Visible = true;
            this.colMACN.VisibleIndex = 6;
            // 
            // colTrangThaiXoa
            // 
            this.colTrangThaiXoa.Caption = "TRẠNG THÁI XÓA";
            this.colTrangThaiXoa.FieldName = "TrangThaiXoa";
            this.colTrangThaiXoa.Name = "colTrangThaiXoa";
            this.colTrangThaiXoa.Visible = true;
            this.colTrangThaiXoa.VisibleIndex = 7;
            // 
            // panelControl_NV
            // 
            this.panelControl_NV.Appearance.BackColor2 = System.Drawing.Color.Green;
            this.panelControl_NV.Appearance.BorderColor = System.Drawing.Color.Yellow;
            this.panelControl_NV.Appearance.Options.UseBackColor = true;
            this.panelControl_NV.Appearance.Options.UseBorderColor = true;
            this.panelControl_NV.Controls.Add(mACNLabel1);
            this.panelControl_NV.Controls.Add(this.txt_maCN);
            this.panelControl_NV.Controls.Add(dIACHILabel);
            this.panelControl_NV.Controls.Add(this.txt_DiaChi);
            this.panelControl_NV.Controls.Add(sODTLabel);
            this.panelControl_NV.Controls.Add(this.txt_SDT);
            this.panelControl_NV.Controls.Add(pHAILabel);
            this.panelControl_NV.Controls.Add(this.cmb_Phai);
            this.panelControl_NV.Controls.Add(rd_TTX);
            this.panelControl_NV.Controls.Add(this.cb_TTX);
            this.panelControl_NV.Controls.Add(tENLabel);
            this.panelControl_NV.Controls.Add(this.txt_Ten);
            this.panelControl_NV.Controls.Add(hOLabel);
            this.panelControl_NV.Controls.Add(this.txt_Ho);
            this.panelControl_NV.Controls.Add(mANVLabel);
            this.panelControl_NV.Controls.Add(this.txt_MaNV);
            this.panelControl_NV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl_NV.Location = new System.Drawing.Point(0, 525);
            this.panelControl_NV.Name = "panelControl_NV";
            this.panelControl_NV.Size = new System.Drawing.Size(1912, 342);
            this.panelControl_NV.TabIndex = 7;
            this.panelControl_NV.Paint += new System.Windows.Forms.PaintEventHandler(this.panelControl2_Paint);
            // 
            // txt_maCN
            // 
            this.txt_maCN.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsNV, "MACN", true));
            this.txt_maCN.Enabled = false;
            this.txt_maCN.Location = new System.Drawing.Point(1697, 43);
            this.txt_maCN.MenuManager = this.barManager1;
            this.txt_maCN.Name = "txt_maCN";
            this.txt_maCN.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_maCN.Properties.Appearance.Options.UseFont = true;
            this.txt_maCN.Size = new System.Drawing.Size(162, 28);
            this.txt_maCN.TabIndex = 17;
            this.txt_maCN.EditValueChanged += new System.EventHandler(this.maCN_EditValueChanged);
            // 
            // txt_DiaChi
            // 
            this.txt_DiaChi.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsNV, "DIACHI", true));
            this.txt_DiaChi.Location = new System.Drawing.Point(1001, 189);
            this.txt_DiaChi.MenuManager = this.barManager1;
            this.txt_DiaChi.Name = "txt_DiaChi";
            this.txt_DiaChi.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_DiaChi.Properties.Appearance.Options.UseFont = true;
            this.txt_DiaChi.Size = new System.Drawing.Size(447, 28);
            this.txt_DiaChi.TabIndex = 13;
            this.txt_DiaChi.Validating += new System.ComponentModel.CancelEventHandler(this.txt_DiaChi_Validating);
            // 
            // txt_SDT
            // 
            this.txt_SDT.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsNV, "SODT", true));
            this.txt_SDT.Location = new System.Drawing.Point(1001, 113);
            this.txt_SDT.MenuManager = this.barManager1;
            this.txt_SDT.Name = "txt_SDT";
            this.txt_SDT.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_SDT.Properties.Appearance.Options.UseFont = true;
            this.txt_SDT.Size = new System.Drawing.Size(209, 28);
            this.txt_SDT.TabIndex = 11;
            this.txt_SDT.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_SDT_KeyPress);
            this.txt_SDT.Validating += new System.ComponentModel.CancelEventHandler(this.txt_SDT_Validating);
            // 
            // cmb_Phai
            // 
            this.cmb_Phai.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsNV, "PHAI", true));
            this.cmb_Phai.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Phai.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Phai.FormattingEnabled = true;
            this.cmb_Phai.Items.AddRange(new object[] {
            "",
            "Nam",
            "Nữ"});
            this.cmb_Phai.Location = new System.Drawing.Point(1001, 43);
            this.cmb_Phai.Name = "cmb_Phai";
            this.cmb_Phai.Size = new System.Drawing.Size(158, 29);
            this.cmb_Phai.TabIndex = 9;
            this.cmb_Phai.Validating += new System.ComponentModel.CancelEventHandler(this.cmb_Phai_Validating);
            // 
            // cb_TTX
            // 
            this.cb_TTX.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.bdsNV, "TrangThaiXoa", true));
            this.cb_TTX.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_TTX.Location = new System.Drawing.Point(1697, 121);
            this.cb_TTX.Name = "cb_TTX";
            this.cb_TTX.Size = new System.Drawing.Size(138, 24);
            this.cb_TTX.TabIndex = 7;
            this.cb_TTX.UseVisualStyleBackColor = true;
            // 
            // txt_Ten
            // 
            this.txt_Ten.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsNV, "TEN", true));
            this.txt_Ten.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Ten.Location = new System.Drawing.Point(297, 189);
            this.txt_Ten.Name = "txt_Ten";
            this.txt_Ten.Size = new System.Drawing.Size(288, 29);
            this.txt_Ten.TabIndex = 5;
            this.txt_Ten.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Ten_KeyPress);
            this.txt_Ten.Validating += new System.ComponentModel.CancelEventHandler(this.txt_Ten_Validating);
            // 
            // txt_Ho
            // 
            this.txt_Ho.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsNV, "HO", true));
            this.txt_Ho.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Ho.Location = new System.Drawing.Point(297, 113);
            this.txt_Ho.Name = "txt_Ho";
            this.txt_Ho.Size = new System.Drawing.Size(281, 29);
            this.txt_Ho.TabIndex = 3;
            this.txt_Ho.Text = " ";
            this.txt_Ho.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Ho_KeyPress);
            this.txt_Ho.Validating += new System.ComponentModel.CancelEventHandler(this.txt_Ho_Validating);
            // 
            // txt_MaNV
            // 
            this.txt_MaNV.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsNV, "MANV", true));
            this.txt_MaNV.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_MaNV.Location = new System.Drawing.Point(297, 43);
            this.txt_MaNV.Name = "txt_MaNV";
            this.txt_MaNV.Size = new System.Drawing.Size(130, 29);
            this.txt_MaNV.TabIndex = 1;
            this.txt_MaNV.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_MaNV_KeyPress);
            this.txt_MaNV.Validating += new System.ComponentModel.CancelEventHandler(this.txt_MaNV_Validating);
            // 
            // bds_GOIRUT
            // 
            this.bds_GOIRUT.DataMember = "FK_GD_GOIRUT_NhanVien";
            this.bds_GOIRUT.DataSource = this.bdsNV;
            // 
            // gD_GOIRUTTableAdapter
            // 
            this.gD_GOIRUTTableAdapter.ClearBeforeFill = true;
            // 
            // bds_CHUYENTIEN
            // 
            this.bds_CHUYENTIEN.DataMember = "FK_GD_CHUYENTIEN_NhanVien";
            this.bds_CHUYENTIEN.DataSource = this.bdsNV;
            // 
            // gD_CHUYENTIENTableAdapter
            // 
            this.gD_CHUYENTIENTableAdapter.ClearBeforeFill = true;
            // 
            // nhanVienTableAdapter1
            // 
            this.nhanVienTableAdapter1.ClearBeforeFill = true;
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // frmNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1912, 887);
            this.Controls.Add(this.panelControl_NV);
            this.Controls.Add(this.gcNhanVien);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frmNhanVien";
            this.Text = "NHÂN VIÊN";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmNhanVien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsNV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcNhanVien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl_NV)).EndInit();
            this.panelControl_NV.ResumeLayout(false);
            this.panelControl_NV.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_maCN.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_DiaChi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_SDT.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bds_GOIRUT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bds_CHUYENTIEN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarButtonItem btn_Them;
        private DevExpress.XtraBars.BarButtonItem btn_HieuChinh;
        private DevExpress.XtraBars.BarButtonItem btn_Ghi;
        private DevExpress.XtraBars.BarButtonItem btn_Xoa;
        private DevExpress.XtraBars.BarButtonItem btn_PhucHoi;
        private DevExpress.XtraBars.BarButtonItem btn_Reload;
        private DevExpress.XtraBars.BarButtonItem btn_DanhSach;
        private DevExpress.XtraBars.BarButtonItem btn_Thoat;
        private System.Windows.Forms.BindingSource bdsNV;
        private DS DS;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private System.Windows.Forms.ComboBox cmb_CN;
        private System.Windows.Forms.Label label1;
        private DSTableAdapters.NhanVienTableAdapter nhanVienTableAdapter;
        private DSTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraGrid.GridControl gcNhanVien;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colMANV;
        private DevExpress.XtraGrid.Columns.GridColumn colHO;
        private DevExpress.XtraGrid.Columns.GridColumn colTEN;
        private DevExpress.XtraGrid.Columns.GridColumn colDIACHI;
        private DevExpress.XtraGrid.Columns.GridColumn colPHAI;
        private DevExpress.XtraGrid.Columns.GridColumn colSODT;
        private DevExpress.XtraGrid.Columns.GridColumn colMACN;
        private DevExpress.XtraGrid.Columns.GridColumn colTrangThaiXoa;
        private DevExpress.XtraEditors.PanelControl panelControl_NV;
        private DevExpress.XtraEditors.TextEdit txt_DiaChi;
        private DevExpress.XtraEditors.TextEdit txt_SDT;
        private System.Windows.Forms.ComboBox cmb_Phai;
        private System.Windows.Forms.CheckBox cb_TTX;
        private System.Windows.Forms.TextBox txt_Ten;
        private System.Windows.Forms.TextBox txt_Ho;
        private System.Windows.Forms.TextBox txt_MaNV;
        private System.Windows.Forms.BindingSource bds_GOIRUT;
        private DSTableAdapters.GD_GOIRUTTableAdapter gD_GOIRUTTableAdapter;
        private System.Windows.Forms.BindingSource bds_CHUYENTIEN;
        private DSTableAdapters.GD_CHUYENTIENTableAdapter gD_CHUYENTIENTableAdapter;
        private DSTableAdapters.NhanVienTableAdapter nhanVienTableAdapter1;
        private DevExpress.XtraEditors.TextEdit txt_maCN;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}