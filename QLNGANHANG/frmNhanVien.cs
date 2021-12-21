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
    public partial class frmNhanVien : Form
    {
        int index = 0;
        String maCN = "";
        public frmNhanVien()
        {
            InitializeComponent();
        }

        private void frmNhanVien_Load(object sender, EventArgs e)
        {
            DS.EnforceConstraints = false;
            // TODO: This line of code loads data into the 'dS.NhanVien' table. You can move, or remove it, as needed.
            this.nhanVienTableAdapter.Connection.ConnectionString = Program.connstr;
            this.nhanVienTableAdapter.Fill(this.DS.NhanVien);
            // TODO: This line of code loads data into the 'DS.GD_GOIRUT' table. You can move, or remove it, as needed.
            this.gD_GOIRUTTableAdapter.Connection.ConnectionString = Program.connstr;
            this.gD_GOIRUTTableAdapter.Fill(this.DS.GD_GOIRUT);
            // TODO: This line of code loads data into the 'DS.GD_CHUYENTIEN' table. You can move, or remove it, as needed.
            this.gD_CHUYENTIENTableAdapter.Connection.ConnectionString = Program.connstr;
            this.gD_CHUYENTIENTableAdapter.Fill(this.DS.GD_CHUYENTIEN);


            //maCN = ((DataRowView)bdsNV[0])["MACN"].ToString();
            if (Program.mChiNhanh == 0)
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
                btn_Them.Enabled = btn_HieuChinh.Enabled = btn_Ghi.Enabled = btn_PhucHoi.Enabled = btn_Reload.Enabled = btn_Xoa.Enabled = btn_DanhSach.Enabled = false;
                panelControl_NV.Enabled = false;
            }
            else
            {
                cmb_CN.Enabled = false;
                btn_Them.Enabled = btn_HieuChinh.Enabled = btn_Ghi.Enabled = btn_PhucHoi.Enabled = btn_Reload.Enabled = btn_Xoa.Enabled = btn_DanhSach.Enabled = true;
                panelControl_NV.Enabled = false;
            }

        }

        private void btn_Them_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            index = bdsNV.Position;
            panelControl_NV.Enabled = true;
            bdsNV.AddNew();
            cb_TTX.Enabled = false;
            txt_maCN.Text = maCN;
            cb_TTX.Checked = false;
            cmb_Phai.SelectedIndex = 0;

            btn_Them.Enabled = btn_HieuChinh.Enabled = btn_Thoat.Enabled = btn_Xoa.Enabled = btn_Reload.Enabled = false;
            btn_Ghi.Enabled = btn_PhucHoi.Enabled = true;
            gcNhanVien.Enabled = false;

        }

        private void nhanVienBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bdsNV.EndEdit();
            this.tableAdapterManager.UpdateAll(this.DS);

        }

        private void nhanVienGridControl_Click(object sender, EventArgs e)
        {

        }

        private void panelControl2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_Thoat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void btn_PhucHoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bdsNV.CancelEdit();
            if (btn_Them.Enabled == false) bdsNV.Position = index;

            gcNhanVien.Enabled = true;
            panelControl_NV.Enabled = false;
            txt_MaNV.Enabled = true;

            btn_Them.Enabled = btn_HieuChinh.Enabled = btn_Thoat.Enabled = btn_Xoa.Enabled = btn_Reload.Enabled = true;
            btn_Ghi.Enabled = btn_PhucHoi.Enabled = false;
        }

        private void btn_HieuChinh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            index = bdsNV.Position;
            panelControl_NV.Enabled = true;
            txt_MaNV.Enabled = false;

            btn_Them.Enabled = btn_HieuChinh.Enabled = btn_Thoat.Enabled = btn_Xoa.Enabled = btn_Reload.Enabled = false;
            btn_Ghi.Enabled = btn_PhucHoi.Enabled = true;
            gcNhanVien.Enabled = false;
        }

        private void btn_Reload_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                this.nhanVienTableAdapter.Fill(this.DS.NhanVien);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi Reload: " + ex.Message, "", MessageBoxButtons.OK);
                return;
            }
        }

        private void btn_Xoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            String manv = "";
            if (cb_TTX.Checked == true)
            {
                MessageBox.Show("Nhân viên đã được chuyển sang chi nhánh khác", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (bds_GOIRUT.Count > 0)
            {
                MessageBox.Show("Không thể xóa nhân viên này vì đã có giao dịch gởi tiền hoặc rút tiền", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (bds_CHUYENTIEN.Count > 0)
            {
                MessageBox.Show("Không thể xóa nhân viên này vì đã có giao dịch chuyển tiền", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (MessageBox.Show("Bạn có thật sự muốn xóa nhân viên?", "Xác nhận", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                try
                {
                    manv = ((DataRowView)bdsNV[bdsNV.Position])["MANV"].ToString();
                    bdsNV.RemoveCurrent();
                    if (Program.KetNoi() == 0) return;
                    String sql = "EXEC dbo.sp_XoaLogin " + manv;
                    Program.myReader = Program.ExecSqlDataReader(sql);
                    if (Program.myReader == null)
                    {

                        MessageBox.Show("Lỗi xóa login", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                    this.nhanVienTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.nhanVienTableAdapter.Update(this.DS.NhanVien);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi xảy ra trong quá trình xóa nhân viên: " + ex.Message, "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.nhanVienTableAdapter.Fill(this.DS.NhanVien);
                    bdsNV.Position = bdsNV.Find("MANV", manv);
                }
            }
            if (bdsNV.Count == 0) btn_Xoa.Enabled = false;
        }

        private void btn_Ghi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (ValidateChildren(ValidationConstraints.Enabled))
            {
                String maNV = txt_MaNV.Text.Trim();

                if (Program.KetNoi() == 0) return;
                int result_value = Program.ExecSqlKiemTra1("sp_TimNV", maNV);

                int indexMaNV = bdsNV.Find("MANV", txt_MaNV.Text);
                int indexCurrent = bdsNV.Position;

                if (result_value == 1 && (indexMaNV != indexCurrent))
                {
                    MessageBox.Show("Mã nhân viên đã tồn tại!", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    if (MessageBox.Show("Bạn có chắc muốn ghi dữ liệu vào Database?", "Thông báo",
                            MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                    {
                        try
                        {
                            bdsNV.EndEdit();
                            bdsNV.ResetCurrentItem();
                            this.nhanVienTableAdapter.Connection.ConnectionString = Program.connstr;
                            this.nhanVienTableAdapter.Update(this.DS.NhanVien);
                            gcNhanVien.Enabled = true;
                            panelControl_NV.Enabled = false;

                            btn_Them.Enabled = btn_HieuChinh.Enabled = btn_Thoat.Enabled = btn_Xoa.Enabled = btn_Reload.Enabled = true;
                            btn_Ghi.Enabled = btn_PhucHoi.Enabled = false;
                        }
                        catch (Exception ex)
                        {
                            bdsNV.RemoveCurrent();
                            MessageBox.Show("Lỗi ghi nhân viên: " + ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                // TODO: This line of code loads data into the 'dS.NhanVien' table. You can move, or remove it, as needed.
                this.nhanVienTableAdapter.Connection.ConnectionString = Program.connstr;
                this.nhanVienTableAdapter.Fill(this.DS.NhanVien);
                // TODO: This line of code loads data into the 'DS.GD_GOIRUT' table. You can move, or remove it, as needed.
                this.gD_GOIRUTTableAdapter.Connection.ConnectionString = Program.connstr;
                this.gD_GOIRUTTableAdapter.Fill(this.DS.GD_GOIRUT);
                // TODO: This line of code loads data into the 'DS.GD_CHUYENTIEN' table. You can move, or remove it, as needed.
                this.gD_CHUYENTIENTableAdapter.Connection.ConnectionString = Program.connstr;
                this.gD_CHUYENTIENTableAdapter.Fill(this.DS.GD_CHUYENTIEN);
            }
        }

        private void maCN_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void txt_MaNV_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_MaNV.Text))
            {
                e.Cancel = true;
                txt_MaNV.Focus();
                errorProvider.SetError(txt_MaNV, "Mã nhân viên không được để trống!");
            }
            else if (txt_MaNV.Text.Trim().Length > 10)
            {
                e.Cancel = true;
                txt_MaNV.Focus();
                errorProvider.SetError(txt_MaNV, "Mã nhân viên không được lớn hơn 10 kí tự!");
            }
            else
            {
                e.Cancel = false;
                errorProvider.SetError(txt_MaNV, "");
            }
        }

        private void txt_Ten_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_Ten.Text))
            {
                e.Cancel = true;
                txt_Ten.Focus();
                errorProvider.SetError(txt_Ten, "Tên nhân viên không được để trống!");
            }
            else
            {
                e.Cancel = false;
                errorProvider.SetError(txt_Ten, "");
            }
        }

        private void txt_Ho_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_Ho.Text))
            {
                e.Cancel = true;
                txt_Ho.Focus();
                errorProvider.SetError(txt_Ho, "Tên nhân viên không được để trống!");
            }
            else
            {
                e.Cancel = false;
                errorProvider.SetError(txt_Ho, "");
            }
        }

        private void txt_DiaChi_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_DiaChi.Text))
            {
                e.Cancel = true;
                txt_DiaChi.Focus();
                errorProvider.SetError(txt_DiaChi, "Địa chỉ không được để trống!");
            }
            else
            {
                e.Cancel = false;
                errorProvider.SetError(txt_DiaChi, "");
            }
        }

        private void txt_Ho_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txt_SDT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(e.KeyChar >= '0' && e.KeyChar <= '9' || e.KeyChar == (char)8))
            {
                e.Handled = true;
            }
        }

        private void txt_Ten_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void txt_SDT_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_SDT.Text))
            {
                e.Cancel = true;
                txt_SDT.Focus();
                errorProvider.SetError(txt_SDT, "Số điện thoại nhân viên không được để trống!");
            }
            else if (txt_SDT.Text.Trim().Length < 10 || txt_SDT.Text.Trim().Length > 10)
            {
                e.Cancel = true;
                txt_SDT.Focus();
                errorProvider.SetError(txt_SDT, "Số điện thoại phải có 10 chữ số!");
            }
            else if (!txt_SDT.Text.Trim().Substring(0, 1).Equals("0"))
            {
                e.Cancel = true;
                txt_SDT.Focus();
                errorProvider.SetError(txt_SDT, "Số điện thoại phải chưa đúng định dạng!");
            }
            else
            {
                e.Cancel = false;
                errorProvider.SetError(txt_SDT, "");
            }
        }

        public void getDATA(String maNVNew, int index)
        {
            if (index != Program.mChiNhanh)
            {
                String maCN = "";
                if (index == 1) maCN = "TANDINH";
                else if (index == 0) maCN = "BENTHANH";

                String maNV = ((DataRowView)bdsNV[bdsNV.Position])["MANV"].ToString();
                String sql = "EXEC dbo.sp_ChuyenNhanVien " + maNV + ", " + maCN + ", " + maNVNew;
                Program.myReader = Program.ExecSqlDataReader(sql);
                if (Program.myReader == null) return;
                else
                {
                    MessageBox.Show("Chuyển nhân viên thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.nhanVienTableAdapter.Fill(this.DS.NhanVien);
                }
                Program.myReader.Read();
                Program.myReader.Close();
                Program.conn.Close();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn chi nhánh khách chi nhánh hiện tại", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void btn_DanhSach_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            int trangThaiXoa = int.Parse(((DataRowView)bdsNV[bdsNV.Position])["TrangThaiXoa"].ToString());
            if (trangThaiXoa == 0)
            {
                frmChuyenChiNhanh ccn = new frmChuyenChiNhanh();
                ccn.data = new frmChuyenChiNhanh.getDATA(getDATA);
                ccn.ShowDialog();
            }
            else
            {
                MessageBox.Show("Nhân viên hiện không có ở chi nhánh này", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

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

        private void txt_MaNV_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!((e.KeyChar >= 'a' && e.KeyChar <= 'z') || (e.KeyChar >= 'A' && e.KeyChar <= 'Z') || (e.KeyChar >= '0' && e.KeyChar <= '9') || e.KeyChar == (char)8))
            {
                e.Handled = true;
            }
        }
    }
}
