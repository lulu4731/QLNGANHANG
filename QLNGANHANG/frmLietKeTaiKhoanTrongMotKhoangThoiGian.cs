using DevExpress.XtraReports.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLNGANHANG
{
    public partial class frmLietKeTaiKhoanTrongMotKhoangThoiGian : Form
    {
        public frmLietKeTaiKhoanTrongMotKhoangThoiGian()
        {
            InitializeComponent();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btn_Xem_Click(object sender, EventArgs e)
        {
            String ngayBD = dateEdit_BD.Text;
            String ngayKT = dateEdit_KT.Text;

            if (!dateEdit_BD.Text.Equals(""))
            {
                ngayBD = DateTime.ParseExact(dateEdit_BD.Text, "dd/MM/yyyy", null).ToString("yyyy/MM/dd");
            }
            else
            {
                ngayBD = DateTime.ParseExact("01/01/2000", "dd/MM/yyyy", null).ToString("yyyy/MM/dd");
            }
            if (!dateEdit_KT.Text.Equals(""))
            {
                ngayKT = DateTime.ParseExact(dateEdit_KT.Text, "dd/MM/yyyy", null).ToString("yyyy/MM/dd");
            }
            else
            {
                ngayKT = DateTime.Now.ToString("yyyy/MM/dd");
            }



            Xrpt_LietKeTaiKhoanTrongMotKhoangThoiGian rpt = new Xrpt_LietKeTaiKhoanTrongMotKhoangThoiGian(ngayBD, ngayKT);

            rpt.XRlabel_TieuDe.Text = "TẤT CẢ CÁC TÀI KHOẢN ĐƯỢC MỞ TỪ NGÀY " + DateTime.ParseExact(ngayBD, "yyyy/MM/dd", null).ToString("dd/MM/yyyy") + " ĐẾN NGÀY " + DateTime.ParseExact(ngayKT, "yyyy/MM/dd", null).ToString("dd/MM/yyyy");

            ReportPrintTool print = new ReportPrintTool(rpt);
            print.ShowPreviewDialog();

        }

        private void dateEdit_BD_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void frmLietKeTaiKhoanTrongMotKhoangThoiGian_Load(object sender, EventArgs e)
        {
            //cmb_CN.DataSource = Program.bds_dspm;
            //cmb_CN.DisplayMember = "TENCN";
            //cmb_CN.ValueMember = "TENSERVER";
            //cmb_CN.SelectedIndex = Program.mChiNhanh;
            //cmb_CN.Enabled = false;
        }

        //private void cmb_CN_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    if (cmb_CN.SelectedValue.ToString() == "System.Data.DataRowView") return;

        //    Program.servername = cmb_CN.SelectedValue.ToString();
        //    Console.WriteLine(cmb_CN.SelectedValue.ToString());
        //    if (cmb_CN.SelectedIndex != Program.mChiNhanh)
        //    {
        //        Program.mlogin = Program.remoteLogin;
        //        Program.password = Program.remotePassword;
        //    }
        //    if (Program.KetNoi() == 0)
        //    {
        //        MessageBox.Show("Lỗi kết nối chi nhánh mới", "", MessageBoxButtons.OK);
        //    }
        //}

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
