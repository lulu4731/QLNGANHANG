
namespace QLNGANHANG
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.btn_Login = new DevExpress.XtraBars.BarButtonItem();
            this.btn_Register = new DevExpress.XtraBars.BarButtonItem();
            this.btn_Logout = new DevExpress.XtraBars.BarButtonItem();
            this.btn_NV = new DevExpress.XtraBars.BarButtonItem();
            this.btn_LietKeTaiKhoan = new DevExpress.XtraBars.BarButtonItem();
            this.btn_LietKeKhachHang = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            this.btn_KH = new DevExpress.XtraBars.BarButtonItem();
            this.btn_TK = new DevExpress.XtraBars.BarButtonItem();
            this.btn_CT = new DevExpress.XtraBars.BarButtonItem();
            this.btn_RT = new DevExpress.XtraBars.BarButtonItem();
            this.btn_GT = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem3 = new DevExpress.XtraBars.BarButtonItem();
            this.hethong = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup7 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup8 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPage_NV = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPage_KH = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup4 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPage_TK = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup5 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup10 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup11 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPage_SK = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup9 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup12 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.xtraTabbedMdiManager1 = new DevExpress.XtraTabbedMdi.XtraTabbedMdiManager(this.components);
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.MANV_Label = new System.Windows.Forms.ToolStripStatusLabel();
            this.HOVATEN_Label = new System.Windows.Forms.ToolStripStatusLabel();
            this.NHOMQUYEN_Label = new System.Windows.Forms.ToolStripStatusLabel();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.ribbonPageGroup6 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).BeginInit();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.ribbonControl1.SearchEditItem,
            this.btn_Login,
            this.btn_Register,
            this.btn_Logout,
            this.btn_NV,
            this.btn_LietKeTaiKhoan,
            this.btn_LietKeKhachHang,
            this.barButtonItem1,
            this.barButtonItem2,
            this.btn_KH,
            this.btn_TK,
            this.btn_CT,
            this.btn_RT,
            this.btn_GT,
            this.barButtonItem3});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.Margin = new System.Windows.Forms.Padding(5);
            this.ribbonControl1.MaxItemId = 17;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.hethong,
            this.ribbonPage_NV,
            this.ribbonPage_KH,
            this.ribbonPage_TK,
            this.ribbonPage_SK});
            this.ribbonControl1.Size = new System.Drawing.Size(1023, 158);
            // 
            // btn_Login
            // 
            this.btn_Login.Caption = "Đăng nhập";
            this.btn_Login.Id = 1;
            this.btn_Login.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_Login.ImageOptions.Image")));
            this.btn_Login.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btn_Login.ImageOptions.LargeImage")));
            this.btn_Login.Name = "btn_Login";
            this.btn_Login.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bntDangNhap_ItemClick);
            // 
            // btn_Register
            // 
            this.btn_Register.Caption = "Tạo tài khoản";
            this.btn_Register.Id = 2;
            this.btn_Register.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_Register.ImageOptions.Image")));
            this.btn_Register.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btn_Register.ImageOptions.LargeImage")));
            this.btn_Register.Name = "btn_Register";
            this.btn_Register.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btn_Register.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_Register_ItemClick);
            // 
            // btn_Logout
            // 
            this.btn_Logout.Caption = "Đăng xuất";
            this.btn_Logout.Id = 3;
            this.btn_Logout.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_Logout.ImageOptions.Image")));
            this.btn_Logout.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btn_Logout.ImageOptions.LargeImage")));
            this.btn_Logout.Name = "btn_Logout";
            this.btn_Logout.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_Logout_ItemClick);
            // 
            // btn_NV
            // 
            this.btn_NV.Caption = "Nhân viên";
            this.btn_NV.Id = 4;
            this.btn_NV.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_NV.ImageOptions.Image")));
            this.btn_NV.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btn_NV.ImageOptions.LargeImage")));
            this.btn_NV.Name = "btn_NV";
            this.btn_NV.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_NV_ItemClick);
            // 
            // btn_LietKeTaiKhoan
            // 
            this.btn_LietKeTaiKhoan.Caption = "Liêt kê tài khoản";
            this.btn_LietKeTaiKhoan.Id = 5;
            this.btn_LietKeTaiKhoan.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_LietKeTaiKhoan.ImageOptions.Image")));
            this.btn_LietKeTaiKhoan.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btn_LietKeTaiKhoan.ImageOptions.LargeImage")));
            this.btn_LietKeTaiKhoan.Name = "btn_LietKeTaiKhoan";
            this.btn_LietKeTaiKhoan.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_LK_ItemClick);
            // 
            // btn_LietKeKhachHang
            // 
            this.btn_LietKeKhachHang.Caption = "Liệt kê khách hàng";
            this.btn_LietKeKhachHang.Id = 6;
            this.btn_LietKeKhachHang.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_LietKeKhachHang.ImageOptions.Image")));
            this.btn_LietKeKhachHang.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btn_LietKeKhachHang.ImageOptions.LargeImage")));
            this.btn_LietKeKhachHang.Name = "btn_LietKeKhachHang";
            this.btn_LietKeKhachHang.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_LietKeKhachHang_ItemClick);
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Id = 7;
            this.barButtonItem1.Name = "barButtonItem1";
            this.barButtonItem1.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.Caption;
            // 
            // barButtonItem2
            // 
            this.barButtonItem2.Caption = "barButtonItem2";
            this.barButtonItem2.Id = 8;
            this.barButtonItem2.Name = "barButtonItem2";
            // 
            // btn_KH
            // 
            this.btn_KH.Caption = "Khách_hàng";
            this.btn_KH.Id = 11;
            this.btn_KH.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_KH.ImageOptions.Image")));
            this.btn_KH.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btn_KH.ImageOptions.LargeImage")));
            this.btn_KH.Name = "btn_KH";
            this.btn_KH.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_KH_ItemClick);
            // 
            // btn_TK
            // 
            this.btn_TK.Caption = "Tài khoản";
            this.btn_TK.Id = 12;
            this.btn_TK.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_TK.ImageOptions.Image")));
            this.btn_TK.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btn_TK.ImageOptions.LargeImage")));
            this.btn_TK.Name = "btn_TK";
            this.btn_TK.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_TK_ItemClick);
            // 
            // btn_CT
            // 
            this.btn_CT.Caption = "Chuyển tiền";
            this.btn_CT.Id = 13;
            this.btn_CT.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_CT.ImageOptions.Image")));
            this.btn_CT.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btn_CT.ImageOptions.LargeImage")));
            this.btn_CT.Name = "btn_CT";
            this.btn_CT.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_CT_ItemClick);
            // 
            // btn_RT
            // 
            this.btn_RT.Caption = "Gởi tiền, Rút tiền";
            this.btn_RT.Id = 14;
            this.btn_RT.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_RT.ImageOptions.Image")));
            this.btn_RT.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btn_RT.ImageOptions.LargeImage")));
            this.btn_RT.Name = "btn_RT";
            this.btn_RT.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_RT_ItemClick);
            // 
            // btn_GT
            // 
            this.btn_GT.Caption = "Gửi tiền";
            this.btn_GT.Id = 15;
            this.btn_GT.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_GT.ImageOptions.Image")));
            this.btn_GT.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btn_GT.ImageOptions.LargeImage")));
            this.btn_GT.Name = "btn_GT";
            // 
            // barButtonItem3
            // 
            this.barButtonItem3.Caption = "Sao kê giao dịch của một tài khoản";
            this.barButtonItem3.Id = 16;
            this.barButtonItem3.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem3.ImageOptions.Image")));
            this.barButtonItem3.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem3.ImageOptions.LargeImage")));
            this.barButtonItem3.Name = "barButtonItem3";
            this.barButtonItem3.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem3_ItemClick);
            // 
            // hethong
            // 
            this.hethong.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1,
            this.ribbonPageGroup7,
            this.ribbonPageGroup8});
            this.hethong.Name = "hethong";
            this.hethong.Text = "HỆ THỐNG";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.AllowTextClipping = false;
            this.ribbonPageGroup1.ItemLinks.Add(this.btn_Login);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "Trang đăng nhập";
            // 
            // ribbonPageGroup7
            // 
            this.ribbonPageGroup7.AllowTextClipping = false;
            this.ribbonPageGroup7.ItemLinks.Add(this.btn_Register);
            this.ribbonPageGroup7.Name = "ribbonPageGroup7";
            this.ribbonPageGroup7.Text = "Trang tạo tài khoản";
            // 
            // ribbonPageGroup8
            // 
            this.ribbonPageGroup8.AllowTextClipping = false;
            this.ribbonPageGroup8.ItemLinks.Add(this.btn_Logout);
            this.ribbonPageGroup8.Name = "ribbonPageGroup8";
            this.ribbonPageGroup8.Text = "Trang đăng xuất";
            // 
            // ribbonPage_NV
            // 
            this.ribbonPage_NV.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup2});
            this.ribbonPage_NV.Name = "ribbonPage_NV";
            this.ribbonPage_NV.Text = "NHÂN VIÊN";
            this.ribbonPage_NV.Visible = false;
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.AllowTextClipping = false;
            this.ribbonPageGroup2.ItemLinks.Add(this.btn_NV);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            this.ribbonPageGroup2.Text = "Trang quản lí nhân viên";
            // 
            // ribbonPage_KH
            // 
            this.ribbonPage_KH.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup4});
            this.ribbonPage_KH.Name = "ribbonPage_KH";
            this.ribbonPage_KH.Text = "KHÁCH HÀNG";
            this.ribbonPage_KH.Visible = false;
            // 
            // ribbonPageGroup4
            // 
            this.ribbonPageGroup4.AllowTextClipping = false;
            this.ribbonPageGroup4.ItemLinks.Add(this.btn_KH);
            this.ribbonPageGroup4.Name = "ribbonPageGroup4";
            this.ribbonPageGroup4.Text = "Trang quản lý khách hàng";
            // 
            // ribbonPage_TK
            // 
            this.ribbonPage_TK.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup5,
            this.ribbonPageGroup10,
            this.ribbonPageGroup11});
            this.ribbonPage_TK.Name = "ribbonPage_TK";
            this.ribbonPage_TK.Text = "TÀI KHOẢN";
            this.ribbonPage_TK.Visible = false;
            // 
            // ribbonPageGroup5
            // 
            this.ribbonPageGroup5.AllowTextClipping = false;
            this.ribbonPageGroup5.ItemLinks.Add(this.btn_TK);
            this.ribbonPageGroup5.Name = "ribbonPageGroup5";
            this.ribbonPageGroup5.Text = "Trang quản lý tài khoản";
            // 
            // ribbonPageGroup10
            // 
            this.ribbonPageGroup10.AllowTextClipping = false;
            this.ribbonPageGroup10.ItemLinks.Add(this.btn_CT);
            this.ribbonPageGroup10.Name = "ribbonPageGroup10";
            this.ribbonPageGroup10.Text = "Trang chuyển tiền";
            // 
            // ribbonPageGroup11
            // 
            this.ribbonPageGroup11.AllowTextClipping = false;
            this.ribbonPageGroup11.ItemLinks.Add(this.btn_RT);
            this.ribbonPageGroup11.Name = "ribbonPageGroup11";
            this.ribbonPageGroup11.Text = "Trang rút tiền gởi tiền";
            // 
            // ribbonPage_SK
            // 
            this.ribbonPage_SK.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup3,
            this.ribbonPageGroup9,
            this.ribbonPageGroup12});
            this.ribbonPage_SK.Name = "ribbonPage_SK";
            this.ribbonPage_SK.Text = "THỐNG KÊ";
            this.ribbonPage_SK.Visible = false;
            // 
            // ribbonPageGroup3
            // 
            this.ribbonPageGroup3.AllowTextClipping = false;
            this.ribbonPageGroup3.ItemLinks.Add(this.btn_LietKeTaiKhoan);
            this.ribbonPageGroup3.Name = "ribbonPageGroup3";
            this.ribbonPageGroup3.Text = "Trang thống kê tài khoản";
            // 
            // ribbonPageGroup9
            // 
            this.ribbonPageGroup9.AllowTextClipping = false;
            this.ribbonPageGroup9.ItemLinks.Add(this.btn_LietKeKhachHang);
            this.ribbonPageGroup9.Name = "ribbonPageGroup9";
            this.ribbonPageGroup9.Text = "Trang thống kê khách hàng";
            // 
            // ribbonPageGroup12
            // 
            this.ribbonPageGroup12.AllowTextClipping = false;
            this.ribbonPageGroup12.ItemLinks.Add(this.barButtonItem3);
            this.ribbonPageGroup12.Name = "ribbonPageGroup12";
            this.ribbonPageGroup12.Text = "Trang thống kê giao dịch";
            // 
            // xtraTabbedMdiManager1
            // 
            this.xtraTabbedMdiManager1.MdiParent = this;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MANV_Label,
            this.HOVATEN_Label,
            this.NHOMQUYEN_Label});
            this.statusStrip1.Location = new System.Drawing.Point(0, 572);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(2, 0, 23, 0);
            this.statusStrip1.Size = new System.Drawing.Size(1023, 27);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // MANV_Label
            // 
            this.MANV_Label.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MANV_Label.Name = "MANV_Label";
            this.MANV_Label.Size = new System.Drawing.Size(126, 22);
            this.MANV_Label.Text = "Mã nhân viên:";
            // 
            // HOVATEN_Label
            // 
            this.HOVATEN_Label.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HOVATEN_Label.Name = "HOVATEN_Label";
            this.HOVATEN_Label.Size = new System.Drawing.Size(93, 22);
            this.HOVATEN_Label.Text = "Họ và tên:";
            // 
            // NHOMQUYEN_Label
            // 
            this.NHOMQUYEN_Label.ForeColor = System.Drawing.Color.Black;
            this.NHOMQUYEN_Label.Name = "NHOMQUYEN_Label";
            this.NHOMQUYEN_Label.Size = new System.Drawing.Size(64, 22);
            this.NHOMQUYEN_Label.Text = "Nhóm:";
            // 
            // ribbonPageGroup6
            // 
            this.ribbonPageGroup6.AllowTextClipping = false;
            this.ribbonPageGroup6.Name = "ribbonPageGroup6";
            // 
            // frmMain
            // 
            this.AllowFormGlass = DevExpress.Utils.DefaultBoolean.True;
            this.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Appearance.Options.UseBackColor = true;
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1023, 599);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.ribbonControl1);
            this.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "frmMain";
            this.Ribbon = this.ribbonControl1;
            this.Text = "QUẢN LÝ NGÂN HÀNG";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.Ribbon.RibbonPage hethong;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.BarButtonItem btn_Login;
        private DevExpress.XtraBars.BarButtonItem btn_Logout;
        private DevExpress.XtraTabbedMdi.XtraTabbedMdiManager xtraTabbedMdiManager1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.ToolStripStatusLabel MANV_Label;
        private System.Windows.Forms.ToolStripStatusLabel HOVATEN_Label;
        private System.Windows.Forms.ToolStripStatusLabel NHOMQUYEN_Label;
        private DevExpress.XtraBars.BarButtonItem btn_NV;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage_NV;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.BarButtonItem btn_LietKeTaiKhoan;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage_SK;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
        private DevExpress.XtraBars.BarButtonItem btn_LietKeKhachHang;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage_KH;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup4;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage_TK;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup5;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem2;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup6;
        private DevExpress.XtraBars.BarButtonItem btn_Register;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup7;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup8;
        private DevExpress.XtraBars.BarButtonItem btn_KH;
        private DevExpress.XtraBars.BarButtonItem btn_TK;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup9;
        private DevExpress.XtraBars.BarButtonItem btn_CT;
        private DevExpress.XtraBars.BarButtonItem btn_RT;
        private DevExpress.XtraBars.BarButtonItem btn_GT;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup10;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup11;
        private DevExpress.XtraBars.BarButtonItem barButtonItem3;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup12;
    }
}

