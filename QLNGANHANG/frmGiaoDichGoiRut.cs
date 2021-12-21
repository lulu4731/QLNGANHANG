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
    public partial class frmGiaoDichGoiRut : Form
    {
        int index = 0;
        String soTKHC = "";
        String loaiGDHC = "";
        Double soTHC = 0;
        public frmGiaoDichGoiRut()
        {
            InitializeComponent();
        }

        private void gD_GOIRUTBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bdsGR.EndEdit();
            this.tableAdapterManager.UpdateAll(this.DS);

        }

        private void frmGiaoDichGoiRut_Load(object sender, EventArgs e)
        {
            DS.EnforceConstraints = false;
            // TODO: This line of code loads data into the 'dS.GD_GOIRUT' table. You can move, or remove it, as needed.
            this.gD_GOIRUTTableAdapter.Connection.ConnectionString = Program.connstr;
            this.gD_GOIRUTTableAdapter.Fill(this.DS.GD_GOIRUT);

            cmb_CN.DataSource = Program.bds_dspm;
            cmb_CN.DisplayMember = "TENCN";
            cmb_CN.ValueMember = "TENSERVER";
            cmb_CN.SelectedIndex = Program.mChiNhanh;

            if (Program.mGroup == "NGANHANG")
            {
                cmb_CN.Enabled = true;
                btn_Them.Enabled = btn_HieuChinh.Enabled = btn_Ghi.Enabled = btn_PhucHoi.Enabled = btn_Reload.Enabled = btn_Xoa.Enabled = false;
                panelControl_GR.Enabled = false;
            }
            else
            {
                cmb_CN.Enabled = false;
                btn_Them.Enabled = btn_HieuChinh.Enabled = btn_Ghi.Enabled = btn_PhucHoi.Enabled = btn_Reload.Enabled = btn_Xoa.Enabled = true;
                panelControl_GR.Enabled = false;
            }

        }

        private void btn_Them_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            index = bdsGR.Position;
            panelControl_GR.Enabled = true;
            bdsGR.AddNew();
            txt_MaNV.Text = Program.username;
            de_NgayGD.Text = DateTime.Now.ToString("dd/MM/yyyy");
            de_NgayGD.Enabled = false;

            btn_Them.Enabled = btn_HieuChinh.Enabled = btn_Thoat.Enabled = btn_Xoa.Enabled = btn_Reload.Enabled = false;
            btn_Ghi.Enabled = btn_PhucHoi.Enabled = true;
            gcGoiRut.Enabled = false;
        }

        private void btn_Thoat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void btn_PhucHoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bdsGR.CancelEdit();
            if (btn_Them.Enabled == false) bdsGR.Position = index;

            gcGoiRut.Enabled = true;
            panelControl_GR.Enabled = false;

            btn_Them.Enabled = btn_HieuChinh.Enabled = btn_Thoat.Enabled = btn_Xoa.Enabled = btn_Reload.Enabled = true;
            btn_Ghi.Enabled = btn_PhucHoi.Enabled = false;
        }

        private void btn_HieuChinh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            index = bdsGR.Position;
            soTKHC = ((DataRowView)bdsGR[index])["SOTK"].ToString().Trim();
            loaiGDHC = ((DataRowView)bdsGR[index])["LOAIGD"].ToString().Trim();
            soTHC = Double.Parse(((DataRowView)bdsGR[index])["SOTIEN"].ToString().Trim());
            panelControl_GR.Enabled = true;

            btn_Them.Enabled = btn_HieuChinh.Enabled = btn_Thoat.Enabled = btn_Xoa.Enabled = btn_Reload.Enabled = false;
            btn_Ghi.Enabled = btn_PhucHoi.Enabled = true;
            gcGoiRut.Enabled = false;
        }

        private void btn_Reload_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                this.gD_GOIRUTTableAdapter.Fill(this.DS.GD_GOIRUT);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi Reload: " + ex.Message, "", MessageBoxButtons.OK);
                return;
            }
        }

        private void btn_Xoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            String soTK = "";
            String loaiGD = "";
            Double soT = 0;
            String maNV = ((DataRowView)bdsGR[bdsGR.Position])["MANV"].ToString().Trim();

            if (Program.username.Equals(maNV))
            {
                if (MessageBox.Show("Bạn có thật sự muốn xóa giao dịch này không?", "Xác nhận", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    try
                    {
                        soTK = ((DataRowView)bdsGR[bdsGR.Position])["SOTK"].ToString();
                        loaiGD = ((DataRowView)bdsGR[bdsGR.Position])["LOAIGD"].ToString();
                        soT = Double.Parse(((DataRowView)bdsGR[bdsGR.Position])["SOTIEN"].ToString());

                        bdsGR.RemoveCurrent();

                        if (Program.KetNoi() == 0) return;
                        if (Program.ExecSqlGiaoDichGR("sp_XoaGiaoDichGoiRut", loaiGD, soT, soTK) == 0)
                        {
                            MessageBox.Show("Xóa giao dịch gởi rút không thành công!", "Thông báo lỗi",
                                   MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }

                        this.gD_GOIRUTTableAdapter.Connection.ConnectionString = Program.connstr;
                        this.gD_GOIRUTTableAdapter.Update(this.DS.GD_GOIRUT);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi xảy ra trong quá trình xóa giao dịch: " + ex.Message, "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        this.gD_GOIRUTTableAdapter.Fill(this.DS.GD_GOIRUT);
                        bdsGR.Position = bdsGR.Find("SOTK", soTK);
                    }
                }
                if (bdsGR.Count == 0) btn_Xoa.Enabled = false;
            }
            else
            {
                MessageBox.Show("Bạn không có quyền xóa giao dịch này", "Cảnh báo",
                           MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }

        private void btn_Ghi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (ValidateChildren(ValidationConstraints.Enabled))
            {
                String loaiGD = cmb_LoaiGD.SelectedItem.ToString().Trim();
                String soTK = txt_SoTK.Text.Trim();
                Double soT = Double.Parse(txt_SoTien.Text.Trim());
                int maGD = int.Parse(((DataRowView)bdsGR[bdsGR.Position])["MAGD"].ToString());


                if (Program.KetNoi() == 0) return;
                if (Program.ExecSqlKiemTra1("sp_TimSoTK", soTK) == 0)
                {
                    MessageBox.Show("Số tài khoản này chưa được đăng kí!", "Cảnh báo",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                //if (maGD == -1)
                //{
                    if (loaiGD.Equals("RT"))
                    {
                        if (Program.ExecSqlKiemTra2("sp_KiemTraSoDu", soTK, soT) == 0)
                        {
                            MessageBox.Show("Tài khoản của bạn không đủ cho giao dịch này!", "Thông báo",
                                       MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                    }

                    try
                    {
                        bdsGR.EndEdit();
                        if (Program.KetNoi() == 0) return;
                        if (Program.ExecSqlGiaoDichGR("sp_GiaoDichGoiRut", loaiGD, soT, soTK) != 0)
                        {
                            MessageBox.Show("Gởi rút không thành công!", "Thông báo lỗi",
                                   MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        bdsGR.ResetCurrentItem();
                        this.gD_GOIRUTTableAdapter.Connection.ConnectionString = Program.connstr;
                        this.gD_GOIRUTTableAdapter.Update(this.DS.GD_GOIRUT);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi ghi giao dịch gởi rút: " + ex.Message, "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                //}
                //else
                //{
                //    if (soTK.Equals(soTKHC))
                //    {
                //        if (loaiGD.Equals(loaiGDHC).Equals("RT"))
                //        {
                //            if (soT > soTHC)
                //            {
                //                if (Program.ExecSqlKiemTra2("sp_KiemTraSoDu", soTK, Math.Abs(soT - soTHC)) == 0)
                //                {
                //                    MessageBox.Show("Tài khoản của bạn không đủ cho giao dịch này!", "Thông báo",
                //                               MessageBoxButtons.OK, MessageBoxIcon.Warning);
                //                    return;
                //                }
                //            }
                //        }else if(loaiGD.Equals("RT") && loaiGDHC.Equals("GT"))
                //        {
                //            if (Program.ExecSqlKiemTra2("sp_KiemTraSoDu", soTK, soT + soTHC) == 0)
                //            {
                //                MessageBox.Show("Tài khoản của bạn không đủ cho giao dịch này!", "Thông báo",
                //                           MessageBoxButtons.OK, MessageBoxIcon.Warning);
                //                return;
                //            }
                //        }
                //    }
                //    else
                //    {
                //        if (Program.ExecSqlKiemTra2("sp_KiemTraSoDu", soTK, soT) == 0)
                //        {
                //            MessageBox.Show("Tài khoản của bạn không đủ cho giao dịch này!", "Thông báo",
                //                       MessageBoxButtons.OK, MessageBoxIcon.Warning);
                //            return;
                //        }
                //    }
                    
                //    //else if (soTK.Equals(soTKHC) && loaiGD.Equals("RT") && loaiGDHC.Equals("GT"))
                //    //{
                        
                //    //}
                //    //else if(loaiGD.Equals("RT"))
                //    //{
                        
                //    //}
                //    try
                //    {
                //        bdsGR.EndEdit();

                //        if (Program.KetNoi() == 0) return;
                //        if (Program.ExecSqlGiaoDichGR("sp_XoaGiaoDichGoiRut", loaiGDHC, soTHC, soTKHC) == 0)
                //        {
                //            MessageBox.Show("Xóa giao dịch gởi rút không thành công!", "Thông báo lỗi",
                //                   MessageBoxButtons.OK, MessageBoxIcon.Error);
                //        }


                //        if (Program.KetNoi() == 0) return;
                //        if (Program.ExecSqlGiaoDichGR("sp_GiaoDichGoiRut", loaiGD, soT, soTK) == 0)
                //        {
                //            MessageBox.Show("Chuyển tiền không thành công!", "Thông báo lỗi",
                //                   MessageBoxButtons.OK, MessageBoxIcon.Error);
                //        }

                //        bdsGR.ResetCurrentItem();
                //        this.gD_GOIRUTTableAdapter.Connection.ConnectionString = Program.connstr;
                //        this.gD_GOIRUTTableAdapter.Update(this.DS.GD_GOIRUT);
                //    }
                //    catch (Exception ex)
                //    {
                //        MessageBox.Show("Lỗi ghi giao dịch gởi rút: " + ex.Message, "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //    }
                //}
                gcGoiRut.Enabled = true;
                panelControl_GR.Enabled = false;


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
                // TODO: This line of code loads data into the 'dS.GD_GOIRUT' table. You can move, or remove it, as needed.
                this.gD_GOIRUTTableAdapter.Connection.ConnectionString = Program.connstr;
                this.gD_GOIRUTTableAdapter.Fill(this.DS.GD_GOIRUT);
            }
        }

        private void txt_SoTK_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_SoTK.Text))
            {
                e.Cancel = true;
                txt_SoTK.Focus();
                errorProvider.SetError(txt_SoTK, "Số tài khoản chuyển không được để trống!");
            }
            else
            {
                e.Cancel = false;
                errorProvider.SetError(txt_SoTK, "");
            }
        }

        private void txt_SoTK_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(e.KeyChar >= '0' && e.KeyChar <= '9' || e.KeyChar == (char)8))
            {
                e.Handled = true;
            }
        }

        private void txt_SoTien_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_SoTien.Text))
            {
                e.Cancel = true;
                txt_SoTien.Focus();
                errorProvider.SetError(txt_SoTien, "Số tiền không được để trống!");
            }
            else if (Double.Parse(txt_SoTien.Text.Trim()) < 100000)
            {
                e.Cancel = true;
                txt_SoTien.Focus();
                errorProvider.SetError(txt_SoTien, "Số tiền chuyển phải lớn hơn hoặc bằng 100000K");
            }
            else
            {
                e.Cancel = false;
                errorProvider.SetError(txt_SoTien, "");
            }
        }

        private void txt_SoTien_KeyPress(object sender, KeyPressEventArgs e)
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

        private void cmb_LoaiGD_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(cmb_LoaiGD.SelectedItem.ToString()))
            {
                e.Cancel = true;
                cmb_LoaiGD.Focus();
                errorProvider.SetError(cmb_LoaiGD, "Ngày chuyển khoản không được để trống!");
            }
            else
            {
                e.Cancel = false;
                errorProvider.SetError(cmb_LoaiGD, "");
            }
        }
    }
}
