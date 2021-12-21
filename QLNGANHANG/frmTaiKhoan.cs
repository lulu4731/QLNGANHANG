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
    public partial class frmTaiKhoan : Form
    {
        int index = 0;
        public frmTaiKhoan()
        {
            InitializeComponent();
        }

        private void taiKhoanBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bdsTK.EndEdit();
            this.tableAdapterManager.UpdateAll(this.DS);

        }

        private void frmTaiKhoan_Load(object sender, EventArgs e)
        {
            DS.EnforceConstraints = false;
            // TODO: This line of code loads data into the 'dS.TaiKhoan' table. You can move, or remove it, as needed.
            this.taiKhoanTableAdapter.Connection.ConnectionString = Program.connstr;
            this.taiKhoanTableAdapter.Fill(this.DS.TaiKhoan);
            // TODO: This line of code loads data into the 'DS.GD_GOIRUT' table. You can move, or remove it, as needed.
            this.taiKhoanTableAdapter.Connection.ConnectionString = Program.connstr;
            this.gD_GOIRUTTableAdapter.Fill(this.DS.GD_GOIRUT);
            // TODO: This line of code loads data into the 'DS.GD_CHUYENTIEN' table. You can move, or remove it, as needed.
            this.taiKhoanTableAdapter.Connection.ConnectionString = Program.connstr;
            this.gD_CHUYENTIENTableAdapter.Fill(this.DS.GD_CHUYENTIEN);


            if (Program.mGroup == "NGANHANG")
            {
                btn_Them.Enabled = btn_HieuChinh.Enabled = btn_Ghi.Enabled = btn_PhucHoi.Enabled = btn_Reload.Enabled = btn_Xoa.Enabled = false;
                panelControl_TK.Enabled = false;
            }
            else
            {
                btn_Them.Enabled = btn_HieuChinh.Enabled = btn_Ghi.Enabled = btn_PhucHoi.Enabled = btn_Reload.Enabled = btn_Xoa.Enabled = true;
                panelControl_TK.Enabled = false;
            }
        }

        private void btn_Them_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            index = bdsTK.Position;
            panelControl_TK.Enabled = true;
            bdsTK.AddNew();
            if(Program.mChiNhanh == 0)
            {
                txt_MaCN.Text = "BENTHANH";
            }
            else
            {
                txt_MaCN.Text = "TANDINH";
            }
            de_NgayMo.Enabled = false;
            de_NgayMo.Text = DateTime.Now.ToString("dd/MM/yyyy");

            btn_Them.Enabled = btn_HieuChinh.Enabled = btn_Thoat.Enabled = btn_Xoa.Enabled = btn_Reload.Enabled = false;
            btn_Ghi.Enabled = btn_PhucHoi.Enabled = true;
            gcTaiKhoan.Enabled = false;
        }

        private void mACNLabel_Click(object sender, EventArgs e)
        {

        }

        private void btn_Thoat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void btn_PhucHoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bdsTK.CancelEdit();
            if (btn_Them.Enabled == false) bdsTK.Position = index;

            gcTaiKhoan.Enabled = true;
            panelControl_TK.Enabled = false;
            txt_CMND.Enabled = true;

            btn_Them.Enabled = btn_HieuChinh.Enabled = btn_Thoat.Enabled = btn_Xoa.Enabled = btn_Reload.Enabled = true;
            btn_Ghi.Enabled = btn_PhucHoi.Enabled = false;
        }

        private void btn_HieuChinh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            index = bdsTK.Position;
            panelControl_TK.Enabled = true;

            btn_Them.Enabled = btn_HieuChinh.Enabled = btn_Thoat.Enabled = btn_Xoa.Enabled = btn_Reload.Enabled = false;
            btn_Ghi.Enabled = btn_PhucHoi.Enabled = true;
            gcTaiKhoan.Enabled = false;
        }

        private void btn_Reload_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                this.taiKhoanTableAdapter.Fill(this.DS.TaiKhoan);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi Reload: " + ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void btn_Xoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            String soTK = ((DataRowView)bdsTK[bdsTK.Position])["SOTK"].ToString();
            if (bds_GOIRUT.Count > 0)
            {
                MessageBox.Show("Không thể xóa tài khoản này vì đã có giao dịch gởi hoặc rút tiền", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (bds_CHUYENTIEN.Count > 0)
            {
                MessageBox.Show("Không thể xóa tài khoản này vì đã có giao dịch gởi hoặc rút tiền", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (Program.KetNoi() == 0) return;
            int return_value = Program.ExecSqlKiemTra1("sp_KiemTraGiaoDich", soTK);
            if (return_value == 1)
            {
                MessageBox.Show("Không thể xóa tài khoản này vì đã có giao dịch", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (return_value == 2)
            {
                MessageBox.Show("Không thể xóa tài khoản này vì đã có giao dịch bên chi nhánh khác", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (MessageBox.Show("Bạn có thật sự muốn xóa nhân viên?", "Xác nhận", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                try
                {
                    soTK = ((DataRowView)bdsTK[bdsTK.Position])["SOTK"].ToString();
                    bdsTK.RemoveCurrent();
                    this.taiKhoanTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.taiKhoanTableAdapter.Update(this.DS.TaiKhoan);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi xảy ra trong quá trình xóa nhân viên: " + ex.Message, "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.taiKhoanTableAdapter.Fill(this.DS.TaiKhoan);
                    bdsTK.Position = bdsTK.Find("SOTK", soTK);
                }
            }
            if (bdsTK.Count == 0) btn_Xoa.Enabled = false;
        }

        private void btn_Ghi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (ValidateChildren(ValidationConstraints.Enabled))
            {
                String soTk = txt_SoTK.Text.Trim();
                String cmnd = txt_CMND.Text.Trim();
                Double soDU = Double.Parse(txt_SoDu.Text.Trim());
                String maCN = txt_MaCN.Text.Trim();
                String ngayMo = de_NgayMo.Text.Trim();

                if (Program.KetNoi() == 0) return;
                int return_value1 = Program.ExecSqlKiemTra1("sp_TimKH", cmnd);
                if (return_value1 == 0)
                {
                    MessageBox.Show("Số chứng minh nhân dân này chưa có trong danh sách khách hàng. Vui lòng tạo khách hàng!", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                
                if (Program.KetNoi() == 0) return;
                int return_value2 = Program.ExecSqlKiemTra1("sp_TimSoTK", soTk);

                int indexSoTk = bdsTK.Find("SOTK", txt_SoTK.Text);
                int indexCurrent = bdsTK.Position;


                if (return_value2 == 1 && (indexSoTk != indexCurrent))
                {
                    MessageBox.Show("Số tài khoản đã tồn tại!", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (return_value1 == 2)
                {
                    String sql = "EXEC dbo.sp_TaoTaiKhoanKhacChiNhanh " + soTk + ", " + cmnd + ", " + soDU + ", " + maCN + ", " + "'"+ DateTime.ParseExact(ngayMo, "dd/MM/yyyy", null).ToString("yyyy/MM/dd") + "'";
                    Console.WriteLine(sql);
                    Program.myReader = Program.ExecSqlDataReader(sql);
                    if (Program.myReader == null) return;
                    else
                    {
                        MessageBox.Show("Tạo tài khoản thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.taiKhoanTableAdapter.Fill(this.DS.TaiKhoan);
                    }
                }
                else
                {
                    if (MessageBox.Show("Bạn có chắc muốn ghi dữ liệu vào Database?", "Thông báo",
                            MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                    {
                        try
                        {
                            bdsTK.EndEdit();
                            bdsTK.ResetCurrentItem();
                            this.taiKhoanTableAdapter.Connection.ConnectionString = Program.connstr;
                            this.taiKhoanTableAdapter.Update(this.DS.TaiKhoan);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Lỗi ghi nhân viên: " + ex.Message, "", MessageBoxButtons.OK);
                        }
                    }
                }

                gcTaiKhoan.Enabled = true;
                panelControl_TK.Enabled = false;

                btn_Them.Enabled = btn_HieuChinh.Enabled = btn_Thoat.Enabled = btn_Xoa.Enabled = btn_Reload.Enabled = true;
                btn_Ghi.Enabled = btn_PhucHoi.Enabled = false;
            }
        }


        private void txt_SoTK_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_SoTK.Text))
            {
                e.Cancel = true;
                txt_SoTK.Focus();
                errorProvider.SetError(txt_SoTK, "Số tài khoản không được để trống!");
            }
            else if (txt_SoTK.Text.Trim().Length < 9 || txt_SoTK.Text.Trim().Length > 9)
            {
                e.Cancel = true;
                txt_SoTK.Focus();
                errorProvider.SetError(txt_SoTK, "Số tài khoản phải đủ 9 chữ số!");
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

        private void txt_SoDu_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_SoDu.Text))
            {
                e.Cancel = true;
                txt_SoDu.Focus();
                errorProvider.SetError(txt_SoDu, "Số dư không được để trống!");
            }
            else if (Double.Parse(txt_SoDu.Text.Trim()) < 50000)
            {
                e.Cancel = true;
                txt_SoDu.Focus();
                errorProvider.SetError(txt_SoDu, "Số tiền chuyển phải lớn hơn hoặc bằng 50000K");
            }
            else
            {
                e.Cancel = false;
                errorProvider.SetError(txt_SoDu, "");
            }
        }

        private void txt_SoDu_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(e.KeyChar >= '0' && e.KeyChar <= '9' || e.KeyChar == (char)8))
            {
                e.Handled = true;
            }
        }

        private void de_NgayMo_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(de_NgayMo.Text))
            {
                e.Cancel = true;
                de_NgayMo.Focus();
                errorProvider.SetError(de_NgayMo, "Ngày cấp không được để trống!");
            }
            else
            {
                e.Cancel = false;
                errorProvider.SetError(de_NgayMo, "");
            }
        }

        private void txt_SoTK_EditValueChanged(object sender, EventArgs e)
        {

        }
    }
}
