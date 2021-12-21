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
    public partial class frmGiaoDichChuyenTien : Form
    {
        int index = 0;
        String soTKNHC = "";
        String soTKCHC = "";
        Double soTHC = 0;

        public frmGiaoDichChuyenTien()
        {
            InitializeComponent();
        }

        private void gD_CHUYENTIENBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bdsCT.EndEdit();
            this.tableAdapterManager.UpdateAll(this.DS);

        }

        private void frmGiaoDichChuyenTien_Load(object sender, EventArgs e)
        {
            DS.EnforceConstraints = false;
            // TODO: This line of code loads data into the 'dS.GD_CHUYENTIEN' table. You can move, or remove it, as needed.
            this.gD_CHUYENTIENTableAdapter.Connection.ConnectionString = Program.connstr;
            this.gD_CHUYENTIENTableAdapter.Fill(this.DS.GD_CHUYENTIEN);

            cmb_CN.DataSource = Program.bds_dspm;
            cmb_CN.DisplayMember = "TENCN";
            cmb_CN.ValueMember = "TENSERVER";
            cmb_CN.SelectedIndex = Program.mChiNhanh;

            if (Program.mGroup == "NGANHANG")
            {
                cmb_CN.Enabled = true;
                btn_Them.Enabled = btn_HieuChinh.Enabled = btn_Ghi.Enabled = btn_PhucHoi.Enabled = btn_Reload.Enabled = btn_Xoa.Enabled = false;
                panelControl_CT.Enabled = false;
            }
            else
            {
                cmb_CN.Enabled = false;
                btn_Them.Enabled = btn_HieuChinh.Enabled = btn_Ghi.Enabled = btn_PhucHoi.Enabled = btn_Reload.Enabled = btn_Xoa.Enabled = true;
                panelControl_CT.Enabled = false;
            }

        }

        private void btn_Them_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            index = bdsCT.Position;
            panelControl_CT.Enabled = true;
            bdsCT.AddNew();
            txt_MaNV.Text = Program.username;
            de_NgayGD.Text = DateTime.Now.ToString("dd/MM/yyyy");
            de_NgayGD.Enabled = false;

            btn_Them.Enabled = btn_HieuChinh.Enabled = btn_Thoat.Enabled = btn_Xoa.Enabled = btn_Reload.Enabled = false;
            btn_Ghi.Enabled = btn_PhucHoi.Enabled = true;
            gcChuyenTien.Enabled = false;
        }

        private void btn_Thoat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void btn_PhucHoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bdsCT.CancelEdit();
            if (btn_Them.Enabled == false) bdsCT.Position = index;

            gcChuyenTien.Enabled = true;
            panelControl_CT.Enabled = false;

            btn_Them.Enabled = btn_HieuChinh.Enabled = btn_Thoat.Enabled = btn_Xoa.Enabled = btn_Reload.Enabled = true;
            btn_Ghi.Enabled = btn_PhucHoi.Enabled = false;
        }

        private void btn_HieuChinh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            index = bdsCT.Position;
            soTKNHC = ((DataRowView)bdsCT[bdsCT.Position])["SOTK_NHAN"].ToString().Trim();
            soTKCHC = ((DataRowView)bdsCT[bdsCT.Position])["SOTK_CHUYEN"].ToString().Trim();
            soTHC = Double.Parse(((DataRowView)bdsCT[bdsCT.Position])["SOTIEN"].ToString().Trim());
            panelControl_CT.Enabled = true;

            btn_Them.Enabled = btn_HieuChinh.Enabled = btn_Thoat.Enabled = btn_Xoa.Enabled = btn_Reload.Enabled = false;
            btn_Ghi.Enabled = btn_PhucHoi.Enabled = true;
            gcChuyenTien.Enabled = false;
        }

        private void btn_Reload_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                this.gD_CHUYENTIENTableAdapter.Fill(this.DS.GD_CHUYENTIEN);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi Reload: " + ex.Message, "", MessageBoxButtons.OK);
                return;
            }
        }

        private void btn_Xoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            String soTKN = "";
            String soTKC = "";
            Double soT = 0;
            String maNV = ((DataRowView)bdsCT[bdsCT.Position])["MANV"].ToString().Trim();

            if (Program.username.Equals(maNV))
            {
                if (MessageBox.Show("Bạn có thật sự muốn xóa giao dịch này?", "Xác nhận", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    try
                    {
                        soTKN = ((DataRowView)bdsCT[bdsCT.Position])["SOTK_NHAN"].ToString();
                        soTKC = ((DataRowView)bdsCT[bdsCT.Position])["SOTK_CHUYEN"].ToString();
                        soT = Double.Parse(((DataRowView)bdsCT[bdsCT.Position])["SOTIEN"].ToString());

                        bdsCT.RemoveCurrent();

                        if (Program.ExecSqlGiaoDichCT("sp_XoaGiaoDichChuyenTien", soTKN, soTKC, soT) == 0)
                        {
                            MessageBox.Show("Xóa Chuyển tiền không thành công!", "Thông báo lỗi",
                                   MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }

                        this.gD_CHUYENTIENTableAdapter.Connection.ConnectionString = Program.connstr;
                        this.gD_CHUYENTIENTableAdapter.Update(this.DS.GD_CHUYENTIEN);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi xóa nhân viên: " + ex.Message, "", MessageBoxButtons.OK);
                        this.gD_CHUYENTIENTableAdapter.Fill(this.DS.GD_CHUYENTIEN);
                        bdsCT.Position = bdsCT.Find("SOTK_NHAN", soTKN);
                    }
                }
            }
            else
            {
                MessageBox.Show("Bạn không có quyền xóa giao dịch này", "Cảnh báo",
                          MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (bdsCT.Count == 0) btn_Xoa.Enabled = false;
        }

        private void btn_Ghi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (ValidateChildren(ValidationConstraints.Enabled))
            {
                String soTKN = txt_TKN.Text.Trim();
                String soTKC = txt_TKC.Text.Trim();
                Double soT = Double.Parse(txt_SoT.Text.Trim());
                int maGD = int.Parse(((DataRowView)bdsCT[bdsCT.Position])["MAGD"].ToString().Trim());

                if (soTKN.Equals(soTKC))
                {
                    MessageBox.Show("Số tài khoản nhận và chuyển phải khác nhau!", "Thông báo",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (Program.KetNoi() == 0) return;
                if (Program.ExecSqlKiemTra1("sp_TimSoTK", soTKC) == 0)
                {
                    MessageBox.Show("Số tài khoản chuyển này chưa được đăng kí!", "Thông báo",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (Program.KetNoi() == 0) return;
                if (Program.ExecSqlKiemTra1("sp_TimSoTK", soTKN) == 0)
                {
                    MessageBox.Show("Số tài khoản nhận này chưa được đăng kí!", "Thông báo",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                //if (maGD == -1)
                //{
                    if (Program.ExecSqlKiemTra2("sp_KiemTraSoDu", soTKC, soT) == 0)
                    {
                        MessageBox.Show("Tài khoản của bạn không đủ cho giao dịch này!", "Thông báo",
                                   MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    bdsCT.EndEdit();
                    if (Program.KetNoi() == 0) return;
                    if (Program.ExecSqlGiaoDichCT("sp_GiaoDichChuyenTien", soTKN, soTKC, soT) != 0)
                    {
                        MessageBox.Show("Chuyển tiền không thành công!", "Thông báo lỗi",
                               MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    bdsCT.ResetCurrentItem();
                    this.gD_CHUYENTIENTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.gD_CHUYENTIENTableAdapter.Update(this.DS.GD_CHUYENTIEN);
                //}
                //else
                //{
                //    if (soTKC.Equals(soTKCHC))
                //    {
                //        if (soT > soTHC)
                //        {
                //            if (Program.ExecSqlKiemTra2("sp_KiemTraSoDu", soTKC, Math.Abs(soT - soTHC)) == 0)
                //            {
                //                MessageBox.Show("Tài khoản của bạn không đủ cho giao dịch này!", "Thông báo",
                //                           MessageBoxButtons.OK, MessageBoxIcon.Warning);
                //                return;
                //            }
                //        }
                //    }
                //    else if(soTKC.Equals(soTKNHC) && soTKN.Equals(soTKCHC))
                //    {
                //        if (Program.ExecSqlKiemTra2("sp_KiemTraSoDu", soTKC, soT + soTHC) == 0)
                //        {
                //            MessageBox.Show("Tài khoản của bạn không đủ cho giao dịch này!", "Thông báo",
                //                       MessageBoxButtons.OK, MessageBoxIcon.Warning);
                //            return;
                //        }
                //    }
                //    else
                //    {
                //        if (Program.ExecSqlKiemTra2("sp_KiemTraSoDu", soTKC, soT) == 0)
                //        {
                //            MessageBox.Show("Tài khoản của bạn không đủ cho giao dịch này!", "Thông báo",
                //                       MessageBoxButtons.OK, MessageBoxIcon.Warning);
                //            return;
                //        }
                //    }



                //    bdsCT.EndEdit();
                //    if (Program.KetNoi() == 0) return;
                //    if (Program.ExecSqlGiaoDichCT("sp_XoaGiaoDichChuyenTien", soTKNHC, soTKCHC, soTHC) == 0)
                //    {
                //        MessageBox.Show("Hiệu chỉnh Chuyển tiền không thành công!", "Thông báo lỗi",
                //               MessageBoxButtons.OK, MessageBoxIcon.Error);
                //    }

                //    if (Program.ExecSqlGiaoDichCT("sp_GiaoDichChuyenTien", soTKN, soTKC, soT) == 0)
                //    {
                //        MessageBox.Show("Chuyển tiền không thành công!", "Thông báo lỗi",
                //               MessageBoxButtons.OK, MessageBoxIcon.Error);
                //    }
                //    bdsCT.ResetCurrentItem();
                //    this.gD_CHUYENTIENTableAdapter.Connection.ConnectionString = Program.connstr;
                //    this.gD_CHUYENTIENTableAdapter.Update(this.DS.GD_CHUYENTIEN);
                //}

                gcChuyenTien.Enabled = true;
                panelControl_CT.Enabled = false;

                btn_Them.Enabled = btn_HieuChinh.Enabled = btn_Thoat.Enabled = btn_Xoa.Enabled = btn_Reload.Enabled = true;
                btn_Ghi.Enabled = btn_PhucHoi.Enabled = false;
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
                // TODO: This line of code loads data into the 'dS.GD_CHUYENTIEN' table. You can move, or remove it, as needed.
                this.gD_CHUYENTIENTableAdapter.Connection.ConnectionString = Program.connstr;
                this.gD_CHUYENTIENTableAdapter.Fill(this.DS.GD_CHUYENTIEN);
            }
        }

        private void txt_SoT_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_SoT.Text))
            {
                e.Cancel = true;
                txt_SoT.Focus();
                errorProvider.SetError(txt_SoT, "Số tiền không được để trống!");
            }
            else if (Double.Parse(txt_SoT.Text.Trim()) < 100000)
            {
                e.Cancel = true;
                txt_SoT.Focus();
                errorProvider.SetError(txt_SoT, "Số tiền chuyển phải lớn hơn hoặc bằng 100000K");
            }
            else
            {
                e.Cancel = false;
                errorProvider.SetError(txt_SoT, "");
            }
        }

        private void txt_SoT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(e.KeyChar >= '0' && e.KeyChar <= '9' || e.KeyChar == (char)8))
            {
                e.Handled = true;
            }
        }

        private void txt_TKC_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_TKC.Text))
            {
                e.Cancel = true;
                txt_TKC.Focus();
                errorProvider.SetError(txt_TKC, "Số tài khoản chuyển không được để trống!");
            }
            else
            {
                e.Cancel = false;
                errorProvider.SetError(txt_TKC, "");
            }
        }

        private void txt_TKC_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(e.KeyChar >= '0' && e.KeyChar <= '9' || e.KeyChar == (char)8))
            {
                e.Handled = true;
            }
        }

        private void txt_TKN_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_TKN.Text))
            {
                e.Cancel = true;
                txt_TKN.Focus();
                errorProvider.SetError(txt_TKN, "Số tài khoản chuyển không được để trống!");
            }
            else
            {
                e.Cancel = false;
                errorProvider.SetError(txt_TKN, "");
            }
        }

        private void txt_TKN_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(e.KeyChar >= '0' && e.KeyChar <= '9' || e.KeyChar == (char)8))
            {
                e.Handled = true;
            }
        }

        private void de_NgayGD_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(de_NgayGD.Text))
            {
                e.Cancel = true;
                de_NgayGD.Focus();
                errorProvider.SetError(de_NgayGD, "Ngày chuyển khoản không được để trống!");
            }
            else
            {
                e.Cancel = false;
                errorProvider.SetError(de_NgayGD, "");
            }
        }

        private void btn_DanhSach_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }
    }
}
