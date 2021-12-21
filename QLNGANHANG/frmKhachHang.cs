using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLNGANHANG
{
    public partial class frmKhachHang : Form
    {
        int index = 0;
        String maCN = "";
        public frmKhachHang()
        {
            InitializeComponent();
        }

        private void khachHangBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bdsKH.EndEdit();
            this.tableAdapterManager.UpdateAll(this.DS);
        }

        private void frmKhachHang_Load(object sender, EventArgs e)
        {
            DS.EnforceConstraints = false;
            // TODO: This line of code loads data into the 'dS.KhachHang' table. You can move, or remove it, as needed.
            this.khachHangTableAdapter.Connection.ConnectionString = Program.connstr;
            this.khachHangTableAdapter.Fill(this.DS.KhachHang);
            // TODO: This line of code loads data into the 'dS.TaiKhoan' table. You can move, or remove it, as needed.
            this.khachHangTableAdapter.Connection.ConnectionString = Program.connstr;
            this.taiKhoanTableAdapter.Fill(this.DS.TaiKhoan);

            //maCN = ((DataRowView)bdsKH[0])["MACN"].ToString();
            if(Program.mChiNhanh == 0)
            {
                maCN = "BENTHANH";
            }
            else
            {
                maCN = "TANDINH";
            }
            cmb_CN.DataSource = Program.bds_dspm;
            cmb_CN.DisplayMember = "TENCN";
            cmb_CN.ValueMember = "TENSERVER";
            cmb_CN.SelectedIndex = Program.mChiNhanh;

            if (Program.mGroup == "NGANHANG")
            {
                cmb_CN.Enabled = true;
                btn_Them.Enabled = btn_HieuChinh.Enabled = btn_Ghi.Enabled = btn_PhucHoi.Enabled = btn_Reload.Enabled = btn_Xoa.Enabled = false;
                panelControl_KH.Enabled = false;
            }
            else
            {
                cmb_CN.Enabled = false;
                btn_Them.Enabled = btn_HieuChinh.Enabled = btn_Ghi.Enabled = btn_PhucHoi.Enabled = btn_Reload.Enabled = btn_Xoa.Enabled = true;
                panelControl_KH.Enabled = false;
            }
        }

        private void khachHangBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.bdsKH.EndEdit();
            this.tableAdapterManager.UpdateAll(this.DS);

        }

        private void btn_Them_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            index = bdsKH.Position;
            panelControl_KH.Enabled = true;
            bdsKH.AddNew();
            txt_MaCN.Text = maCN;
            de_NgayCap.Text = DateTime.Now.ToString("dd/MM/yyyy");
            de_NgayCap.Enabled = false;

            btn_Them.Enabled = btn_HieuChinh.Enabled = btn_Thoat.Enabled = btn_Xoa.Enabled = btn_Reload.Enabled = false;
            btn_Ghi.Enabled = btn_PhucHoi.Enabled = true;
            gcKhachHang.Enabled = false;
        }

        private void btn_Thoat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void btn_PhucHoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bdsKH.CancelEdit();
            if (btn_Them.Enabled == false) bdsKH.Position = index;

            gcKhachHang.Enabled = true;
            panelControl_KH.Enabled = false;
            txt_CMND.Enabled = true;
            de_NgayCap.Enabled = true;

            btn_Them.Enabled = btn_HieuChinh.Enabled = btn_Thoat.Enabled = btn_Xoa.Enabled = btn_Reload.Enabled = true;
            btn_Ghi.Enabled = btn_PhucHoi.Enabled = false;
        }

        private void btn_HieuChinh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            index = bdsKH.Position;
            panelControl_KH.Enabled = true;
            txt_CMND.Enabled = false;
            de_NgayCap.Enabled = false;

            btn_Them.Enabled = btn_HieuChinh.Enabled = btn_Thoat.Enabled = btn_Xoa.Enabled = btn_Reload.Enabled = false;
            btn_Ghi.Enabled = btn_PhucHoi.Enabled = true;
            gcKhachHang.Enabled = false;
        }

        private void btn_Reload_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                this.khachHangTableAdapter.Fill(this.DS.KhachHang);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi Reload: " + ex.Message, "", MessageBoxButtons.OK);
                return;
            }
        }

        private void btn_Xoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            String cmnd = "";
            if (bdsTK.Count > 0)
            {
                MessageBox.Show("Không thể xóa khách hàng này vì đã tạo tài khoản", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (MessageBox.Show("Bạn có thật sự muốn xóa khách hàng không?", "Xác nhận", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                try
                {
                    cmnd = ((DataRowView)bdsKH[bdsKH.Position])["CMND"].ToString();
                    bdsKH.RemoveCurrent();
                    this.khachHangTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.khachHangTableAdapter.Update(this.DS.KhachHang);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi xảy ra trong quá trình xóa khách hàng: " + ex.Message, "Thống báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.khachHangTableAdapter.Fill(this.DS.KhachHang);
                    bdsKH.Position = bdsKH.Find("CMND", cmnd);
                }
            }
            if (bdsKH.Count == 0) btn_Xoa.Enabled = false;
        }

        private void btn_Ghi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (ValidateChildren(ValidationConstraints.Enabled))
            {
                String cmnd = txt_CMND.Text.Trim();

                if (Program.KetNoi() == 0) return;
                int result_value = Program.ExecSqlKiemTra1("sp_TimKH", cmnd);

                int indexCMND = bdsKH.Find("CMND", txt_CMND.Text);
                int indexCurrent = bdsKH.Position;

                if (result_value == 1 && indexCMND != indexCurrent)
                {
                    MessageBox.Show("CMND này đã tồn tại!", "Thông báo",
                                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    if (MessageBox.Show("Bạn có chắc muốn ghi dữ liệu vào Database?", "Thông báo",
                            MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                    {
                        try
                        {
                            bdsKH.EndEdit();
                            bdsKH.ResetCurrentItem();
                            this.khachHangTableAdapter.Connection.ConnectionString = Program.connstr;
                            this.khachHangTableAdapter.Update(this.DS.KhachHang);

                            gcKhachHang.Enabled = true;
                            panelControl_KH.Enabled = false;

                            btn_Them.Enabled = btn_HieuChinh.Enabled = btn_Thoat.Enabled = btn_Xoa.Enabled = btn_Reload.Enabled = true;
                            btn_Ghi.Enabled = btn_PhucHoi.Enabled = false;
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Lỗi ghi khách hàng: " + ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
        }

        private void cmb_CN_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmb_CN.SelectedValue.ToString() == "System.Data.DataRowView") return;

            Program.servername = cmb_CN.SelectedValue.ToString();
            if (cmb_CN.SelectedIndex != Program.mChiNhanh)
            {
                Program.mlogin = Program.remoteLogin;
                Program.password = Program.remotePassword;
            }
            if (Program.KetNoi() == 0)
            {
                MessageBox.Show("Lỗi kết nối chi nhánh mới", "", MessageBoxButtons.OK);
            }
            else
            {
                DS.EnforceConstraints = false;
                this.khachHangTableAdapter.Connection.ConnectionString = Program.connstr;
                // TODO: This line of code loads data into the 'dS.KhachHang' table. You can move, or remove it, as needed.
                this.khachHangTableAdapter.Fill(this.DS.KhachHang);
            }
        }

        private void txt_CMND_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_CMND.Text))
            {
                e.Cancel = true;
                txt_CMND.Focus();
                errorProvider.SetError(txt_CMND, "Chứng minh nhân dân không được để trống!");
            }
            else if (txt_CMND.Text.Trim().Length < 9 || txt_CMND.Text.Trim().Length > 9)
            {
                e.Cancel = true;
                txt_CMND.Focus();
                errorProvider.SetError(txt_CMND, "Chứng minh nhân dân phải đủ 9 chữ số!");
            }
            else
            {
                e.Cancel = false;
                errorProvider.SetError(txt_CMND, "");
            }
        }

        private void txt_CMND_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(e.KeyChar >= '0' && e.KeyChar <= '9' || e.KeyChar == (char)8))
            {
                e.Handled = true;
            }
        }

        private void txt_Ho_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_Ho.Text))
            {
                e.Cancel = true;
                txt_Ho.Focus();
                errorProvider.SetError(txt_Ho, "Họ khách hàng không được để trống!");
            }
            else
            {
                e.Cancel = false;
                errorProvider.SetError(txt_Ho, "");
            }
        }

        private void txt_Ten_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_Ten.Text))
            {
                e.Cancel = true;
                txt_Ten.Focus();
                errorProvider.SetError(txt_Ten, "Tên khách hàng không được để trống!");
            }
            else
            {
                e.Cancel = false;
                errorProvider.SetError(txt_Ten, "");
            }
        }

        private void txt_DiaChi_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_DiaChi.Text))
            {
                e.Cancel = true;
                txt_DiaChi.Focus();
                errorProvider.SetError(txt_DiaChi, "Địa chỉ khách hàng không được để trống!");
            }
            else
            {
                e.Cancel = false;
                errorProvider.SetError(txt_DiaChi, "");
            }
        }

        private void txt_SoDT_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_SoDT.Text))
            {
                e.Cancel = true;
                txt_SoDT.Focus();
                errorProvider.SetError(txt_SoDT, "Địa chỉ khách hàng không được để trống!");
            }
            else if (txt_SoDT.Text.Trim().Length < 10 || txt_SoDT.Text.Trim().Length > 10)
            {
                e.Cancel = true;
                txt_SoDT.Focus();
                errorProvider.SetError(txt_SoDT, "Số điện thoại phải có 10 chữ số!");
            }
            else if (!txt_SoDT.Text.Trim().Substring(0, 1).Equals("0"))
            {
                e.Cancel = true;
                txt_SoDT.Focus();
                errorProvider.SetError(txt_SoDT, "Số điện thoại phải chưa đúng định dạng!");
            }
            else
            {
                e.Cancel = false;
                errorProvider.SetError(txt_SoDT, "");
            }
        }

        private void txt_SoDT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(e.KeyChar >= '0' && e.KeyChar <= '9' || e.KeyChar == (char)8))
            {
                e.Handled = true;
            }
        }

        private void de_NgayCap_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(de_NgayCap.Text))
            {
                e.Cancel = true;
                de_NgayCap.Focus();
                errorProvider.SetError(de_NgayCap, "Ngày cấp không được để trống!");
            }
            else
            {
                e.Cancel = false;
                errorProvider.SetError(de_NgayCap, "");
            }
        }

        private void txt_CMND_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmb_Phai_Validating(object sender, CancelEventArgs e)
        {

            if (string.IsNullOrWhiteSpace(cmb_Phai.SelectedItem.ToString().Trim()))
            {
                e.Cancel = true;
                cmb_Phai.Focus();
                errorProvider.SetError(cmb_Phai, "Giới tính không được để trống!");
            }
            else
            {
                e.Cancel = false;
                errorProvider.SetError(cmb_Phai, "");
            }
        }

        private void txt_Ho_KeyPress(object sender, KeyPressEventArgs e)
        {
            //if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            //{
            //    e.Handled = true;
            //}
        }

        private void txt_Ten_KeyPress(object sender, KeyPressEventArgs e)
        {
            //if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            //{
            //    e.Handled = true;
            //}
        }
    }
}
