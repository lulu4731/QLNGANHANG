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
    public partial class frmChuyenChiNhanh : Form
    {
        public delegate void getDATA(String maNVNew, int index);
        public getDATA data;
        public static SqlConnection conn = new SqlConnection();
        public frmChuyenChiNhanh()
        {
            InitializeComponent();
        }
        private void LayDSPM(String cmd)
        {
            DataTable dt = new DataTable();
            if (conn.State == ConnectionState.Closed) conn.Open();
            SqlDataAdapter da = new SqlDataAdapter(cmd, conn);
            da.Fill(dt);
            conn.Close();
            cmb_CN.DataSource = dt;
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
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void frmChuyenChiNhanh_Load(object sender, EventArgs e)
        {

            if (KetNoi_CSDLGOC() == 0) return;
            LayDSPM("SELECT * FROM Lay_DS_ChiNhanh");
            cmb_CN.SelectedIndex = 1;
            cmb_CN.SelectedIndex = 0;
        }

        private void btn_Chuyen_Click(object sender, EventArgs e)
        {
            int index = cmb_CN.SelectedIndex;
            String txt_ma = txt_maNVNew.Text.Trim();

            if (Program.KetNoi() == 0) return;
            int result_value = Program.ExecSqlKiemTra1("sp_TimNV", txt_ma);
            if (result_value == 1)
            {
                MessageBox.Show("Mã nhân viên đã tồn tại!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            data(txt_ma, index);
        }
    }
}
