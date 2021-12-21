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
    public partial class frmLogin : Form
    {
        public static SqlConnection conn = new SqlConnection();
        public static frmMain frm;
        public frmLogin()
        {
            InitializeComponent();
        }
        public frmLogin(string m) : this()
        {
            txt_MK.Text = m;
        }
        private void LayDSPM(String cmd)
        {
            DataTable dt = new DataTable();
            if (conn.State == ConnectionState.Closed) conn.Open();
            SqlDataAdapter da = new SqlDataAdapter(cmd, conn);
            da.Fill(dt);
            conn.Close();
            Program.bds_dspm.DataSource = dt;
            cmb_CN.DataSource = Program.bds_dspm;
            cmb_CN.DisplayMember = "TENCN";
            cmb_CN.ValueMember = "TENSERVER";
        }
        private int KetNoi_CSDLGOC()
        {
            if (conn != null && conn.State == ConnectionState.Open)
            {
                conn.Close();
            }
            try
            {
                conn.ConnectionString = Program.conn_publisher;
                conn.Open();
                return 1;
            }
            catch (Exception e)
            {
                MessageBox.Show("Lỗi kết nối cơ sở dữ liệu.\nBạn xem lại user name và password.\n " + e.Message, "", MessageBoxButtons.OK);
                return 0;
            }
        }
        private void frmLogin_Load(object sender, EventArgs e)
        {
            if (KetNoi_CSDLGOC() == 0) return;
            LayDSPM("SELECT * FROM Lay_DS_ChiNhanh");
            cmb_CN.SelectedIndex = 1;
            cmb_CN.SelectedIndex = 0;
        }
        private void btn_DangNhap_Click(object sender, EventArgs e)
        {
            Program.servername = cmb_CN.SelectedValue.ToString();
            Program.mChiNhanh = cmb_CN.SelectedIndex;
            Program.mlogin = txt_TK.Text;
            Program.password = txt_MK.Text;
            if (Program.KetNoi() == 0) return;

            String sql = "EXEC dbo.sp_Lay_Thong_Tin_NV_Tu_Login " + Program.mlogin;
            Program.myReader = Program.ExecSqlDataReader(sql);
            if (Program.myReader == null) return;
            Program.myReader.Read();
            Program.username = Program.myReader.GetString(0);  
            if (Convert.IsDBNull(Program.username))
            {
                MessageBox.Show("Nhân viên không tồn tại.", "", MessageBoxButtons.OK);
                return;
            }
            Program.mHoten = Program.myReader.GetString(1);
            Program.mGroup = Program.myReader.GetString(2);
            Program.myReader.Close();
            Program.conn.Close();
            MessageBox.Show("Nhân viên - Nhóm : " + Program.mHoten + " - " + Program.mGroup
               , "Đăng nhập thành công!"
               , MessageBoxButtons.OK, MessageBoxIcon.Information);

            Program.frmChinh.HienThiMenu();
            this.Close();
            frm = new frmMain();
            Program.frmChinh.setLogin();
            
        }
        public void btn_Thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmb_CN_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

