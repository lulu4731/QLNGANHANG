﻿using DevExpress.Skins;
using DevExpress.UserSkins;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;

namespace QLNGANHANG
{
    static class Program
    {
        public static String conn_publisher = "Data Source=LAPTOP-C7T0SN0V;Initial Catalog=NGANHANG;Integrated Security=true";
        public static SqlConnection conn = new SqlConnection();
        public static String connstr;

        public static SqlDataReader myReader;

        public static String servername = "";
        public static String username = "";
        public static String password = "";
        public static String database = "NGANHANG";
        public static String remoteLogin = "HTKN";
        public static String remotePassword = "123";

        public static String mlogin;
        public static String mGroup;
        public static String mHoten;
        public static int mChiNhanh;

        public static frmMain frmChinh;

        public static BindingSource bds_dspm = new BindingSource();
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        public static int KetNoi()
        {
            if (Program.conn != null && Program.conn.State == ConnectionState.Open)
                Program.conn.Close();
            try
            {
                Program.connstr = "Data Source=" + Program.servername + ";Initial Catalog=" +
                      Program.database + ";User ID=" +
                      Program.mlogin + ";password=" + Program.password;
                Program.conn.ConnectionString = Program.connstr;
                Program.conn.Open();
                return 1;

            }

            catch (Exception e)
            {
                MessageBox.Show("Lỗi kết nối cơ sở dữ liệu.\nBạn xem lại user name và password.\n " + e.Message, "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 0;
            }
        }
        public static SqlDataReader ExecSqlDataReader(String strLenh)
        {
            SqlDataReader myreader;
            SqlCommand sqlcmd = new SqlCommand(strLenh, Program.conn);
            sqlcmd.CommandType = CommandType.Text;
            if (Program.conn.State == ConnectionState.Closed) Program.conn.Open();
            try
            {
                myreader = sqlcmd.ExecuteReader(); return myreader;

            }
            catch (SqlException ex)
            {
                Program.conn.Close();
                MessageBox.Show(ex.Message);
                return null;
            }
        }
        public static DataTable ExecSqlDataTable(String cmd)
        {
            DataTable dt = new DataTable();
            if (Program.conn.State == ConnectionState.Closed) Program.conn.Open();
            SqlDataAdapter da = new SqlDataAdapter(cmd, conn);
            da.Fill(dt);
            conn.Close();
            return dt;
        }
        public static int ExecSqlNonQuery1(String cmd, String connectionstring)
        {
            conn = new SqlConnection(connectionstring);
            SqlCommand Sqlcmd = new SqlCommand();
            Sqlcmd.Connection = conn;
            Sqlcmd.CommandText = cmd;
            Sqlcmd.CommandType = CommandType.Text;
            Sqlcmd.CommandTimeout = 300;
            if (conn.State == ConnectionState.Closed) conn.Open();
            try
            {
                Sqlcmd.ExecuteNonQuery(); conn.Close(); return 1;
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
                conn.Close();
                return 0;
            }
        }
        public static int ExecSqlGiaoDichCT(String tenSP, String tkn, String tkc, Double st)
        {
            String sql = "DECLARE @return_value int " +
                         "EXEC @return_value = [dbo].[" + tenSP + "] " +
                         "@a, @b, @c " +
                         "SELECT 'Return Value' = @return_value";

            SqlCommand sqlCommand = new SqlCommand(sql, Program.conn);
            if (Program.conn.State == ConnectionState.Closed) Program.conn.Open();
            sqlCommand.Parameters.AddWithValue("@a", tkn);
            sqlCommand.Parameters.AddWithValue("@b", tkc);
            sqlCommand.Parameters.AddWithValue("@c", st);
            SqlDataReader dataReader = null;
            try
            {
                dataReader = sqlCommand.ExecuteReader();
                dataReader.Read();
                int result_value = int.Parse(dataReader.GetValue(0).ToString());
                conn.Close();
                return result_value;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                conn.Close();
                return 0;
            }
        }
        public static int ExecSqlGiaoDichGR(String tenSP, String type, Double st, String stk)
        {
            String sql = "DECLARE @return_value int " +
                         "EXEC @return_value = [dbo].[" + tenSP + "] " +
                         "@a, @b, @c " +
                         "SELECT 'Return Value' = @return_value";

            SqlCommand sqlCommand = new SqlCommand(sql, Program.conn);
            if (Program.conn.State == ConnectionState.Closed) Program.conn.Open();
            sqlCommand.Parameters.AddWithValue("@a", type);
            sqlCommand.Parameters.AddWithValue("@b", st);
            sqlCommand.Parameters.AddWithValue("@c", stk);
            SqlDataReader dataReader = null;
            try
            {
                dataReader = sqlCommand.ExecuteReader();
                dataReader.Read();
                int result_value = int.Parse(dataReader.GetValue(0).ToString());
                conn.Close();
                return result_value;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                conn.Close();
                return 0;
            }
        }
        public static int ExecSqlKiemTra1(String tenSP, String a)
        {
            String sql = "DECLARE @return_value int " +
                         "EXEC @return_value = [dbo].[" + tenSP + "] " +
                         "@a " +
                         "SELECT 'Return Value' = @return_value";

            SqlCommand sqlCommand = new SqlCommand(sql, Program.conn);
            if (Program.conn.State == ConnectionState.Closed) Program.conn.Open();
            sqlCommand.Parameters.AddWithValue("@a", a);
            SqlDataReader dataReader = null;
            try
            {
                dataReader = sqlCommand.ExecuteReader();
                dataReader.Read();
                int result_value = int.Parse(dataReader.GetValue(0).ToString());
                conn.Close();
                return result_value;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                conn.Close();
                return 5;
            }
        }
        public static int ExecSqlKiemTra2(String tenSP, String a, Double b)
        {
            String sql = "DECLARE @return_value int " +
                         "EXEC @return_value = [dbo].[" + tenSP + "] " +
                         "@a, @b " +
                         "SELECT 'Return Value' = @return_value";

            SqlCommand sqlCommand = new SqlCommand(sql, Program.conn);
            if (Program.conn.State == ConnectionState.Closed) Program.conn.Open();
            sqlCommand.Parameters.AddWithValue("@a", a);
            sqlCommand.Parameters.AddWithValue("@b", b);
            SqlDataReader dataReader = null;
            try
            {
                dataReader = sqlCommand.ExecuteReader();
                dataReader.Read();
                int result_value = int.Parse(dataReader.GetValue(0).ToString());
                conn.Close();
                return result_value;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                conn.Close();
                return 0;
            }
        }
        public static void SetEnableOfButton(Form frm, Boolean Active)
        {

            foreach (Control ctl in frm.Controls)
                if ((ctl) is Button)
                    ctl.Enabled = Active;
        }
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            frmChinh = new frmMain();
            Application.Run(frmChinh);
        }
    }
}
