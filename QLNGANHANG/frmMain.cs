using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QLNGANHANG
{
    public partial class frmMain : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public frmMain()
        {
            InitializeComponent();
            btn_Logout.Enabled = false;
            btn_Register.Enabled = false;
        }
        private Form CheckExists(Type ftype)
        {
            foreach (Form f in this.MdiChildren)
                if (f.GetType() == ftype)
                    return f;
            return null;
        }
        private void bntDangNhap_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(frmLogin));
            if (frm != null) frm.Activate();
            else
            {
                frmLogin f = new frmLogin();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void btn_Register_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(frmRegister));
            if (frm != null) frm.Activate();
            else
            {
                frmRegister f = new frmRegister();
                f.MdiParent = this;
                f.Show();
            }
        }
        public void HienThiMenu()
        {
            MANV_Label.Text ="Mã nhân viên: " + Program.username;
            HOVATEN_Label.Text ="Họ và tên: " + Program.mHoten;
            NHOMQUYEN_Label.Text ="Nhóm: " + Program.mGroup;

            btn_Logout.Enabled = true;
            btn_Register.Enabled = true;
            ribbonPage_KH.Visible = true;
            ribbonPage_NV.Visible = true;
            ribbonPage_SK.Visible = true;
            ribbonPage_TK.Visible = true;
        }
        public void frmMain_Load(object sender, EventArgs e)
        {
           
        }
        public void setLogin()
        {
            btn_Login.Enabled = false;
        }
        private void btn_Logout_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //frmLogin document = (frmLogin)ActiveMdiChild;
            //if (document != null)
            //{
            //    document.Close();
            //}

            foreach (Form frm in this.MdiChildren)
            {
                if (!frm.Focused)
                {
                    frm.Visible = false;
                    frm.Dispose();
                }
            }

            Program.username = "";
            Program.mHoten = "";
            Program.mGroup = "";
            Program.frmChinh.HienThiMenu();
            btn_Register.Enabled = false;
            btn_Logout.Enabled = false;
            btn_Login.Enabled = true;
            ribbonPage_KH.Visible = false;
            ribbonPage_NV.Visible = false;
            ribbonPage_SK.Visible = false;
            ribbonPage_TK.Visible = false;
        }

        private void btn_NV_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(frmNhanVien));
            if (frm != null) frm.Activate();
            else
            {
                frmNhanVien f = new frmNhanVien();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void btn_LK_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(frmLietKeTaiKhoanTrongMotKhoangThoiGian));
            if (frm != null) frm.Activate();
            else
            {
                frmLietKeTaiKhoanTrongMotKhoangThoiGian f = new frmLietKeTaiKhoanTrongMotKhoangThoiGian();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void btn_LietKeKhachHang_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(frmLietKeKhachHangTheoTungChiNhanh));
            if (frm != null) frm.Activate();
            else
            {
                frmLietKeKhachHangTheoTungChiNhanh f = new frmLietKeKhachHangTheoTungChiNhanh();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void btn_KH_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(frmKhachHang));
            if (frm != null) frm.Activate();
            else
            {
                frmKhachHang f = new frmKhachHang();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void btn_TK_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(frmTaiKhoan));
            if (frm != null) frm.Activate();
            else
            {
                frmTaiKhoan f = new frmTaiKhoan();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void btn_RT_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(frmGiaoDichGoiRut));
            if (frm != null) frm.Activate();
            else
            {
                frmGiaoDichGoiRut f = new frmGiaoDichGoiRut();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void btn_CT_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(frmGiaoDichChuyenTien));
            if (frm != null) frm.Activate();
            else
            {
                frmGiaoDichChuyenTien f = new frmGiaoDichChuyenTien();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(frmSaoKeGiaoDichTaiKhoanTrongKhangThoiGian));
            if (frm != null) frm.Activate();
            else
            {
                frmSaoKeGiaoDichTaiKhoanTrongKhangThoiGian f = new frmSaoKeGiaoDichTaiKhoanTrongKhangThoiGian();
                f.MdiParent = this;
                f.Show();
            }
        }
    }
}
