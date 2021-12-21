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
    public partial class frmRegister : Form
    {
        public static SqlConnection conn = new SqlConnection();
        public static String connstr;

        public String lgname;
        public String pass;
        public String username;
        public String role;
        public String confirm;

        String[] Array = {"NGANHANG", "CHINHANH"};

        public frmRegister()
        {
            InitializeComponent();
        }
        private void LayDSLogin(String cmd)
        {
            DataTable dt = new DataTable();
            if (conn.State == ConnectionState.Closed) conn.Open();
            SqlDataAdapter da = new SqlDataAdapter(cmd, conn);
            da.Fill(dt);
            conn.Close();
            cmb_TT.DataSource = dt;
            cmb_TT.DisplayMember = "HOTEN";
            cmb_TT.ValueMember = "MANV";
        }
        private int KetNoi_CSDLGOC()
        {
            if (conn != null && conn.State == ConnectionState.Open)
            {
                conn.Close();
            }
            try
            {
                conn.ConnectionString = Program.connstr;
                conn.Open();
                return 1;
            }
            catch (Exception e)
            {
                MessageBox.Show("Lỗi kết nối cơ sở dữ liệu.\nBạn xem lại user name và password.\n " + e.Message, "", MessageBoxButtons.OK);
                return 0;
            }
        }
        private void frmRegister_Load(object sender, EventArgs e)
        {

            if (KetNoi_CSDLGOC() == 0) return;
            LayDSLogin("SELECT * FROM LayThongTinLogin");
            cmb_TT.SelectedIndex = 1;
            cmb_TT.SelectedIndex = 0;
        }

        private void bnt_DangKi_Click(object sender, EventArgs e)
        {
            

            lgname = txt_TKDK.Text.Trim();
            pass = txt_MKDK.Text.Trim();
            confirm = txt_NLMK.Text.Trim();
            username = (string)cmb_TT.SelectedValue;

            if (Program.KetNoi() == 0) return;
            int result_value = Program.ExecSqlKiemTra1("sp_KiemTraLogin", username);
            if(result_value == 1)
            {
                MessageBox.Show("Tài khoản này đã được tạo login!", "Cảnh báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            role = Program.mGroup;
            if (String.Compare(pass, confirm, true) != 0)
            {
                MessageBox.Show("Nhập lại mật khẩu không giống ", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (Program.KetNoi() == 0) return;

            String sql = "EXEC dbo.sp_TaoTaiKhoan " + lgname + ", " + pass + ", " + username + ", " + role;
            Console.WriteLine(sql);
            Program.myReader = Program.ExecSqlDataReader(sql);
            if (Program.myReader == null) return;
            Program.myReader.Read();
            Program.myReader.Close();
            Program.conn.Close();
            MessageBox.Show("Nhân viên - Nhóm : " + lgname + " - " + Program.mGroup
               , "Đăng kí thành công!"
               , MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void bnt_Thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
