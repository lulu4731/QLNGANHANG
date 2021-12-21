using DevExpress.XtraReports.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLNGANHANG
{
    public partial class frmLietKeKhachHangTheoTungChiNhanh : Form
    {
        public frmLietKeKhachHangTheoTungChiNhanh()
        {
            InitializeComponent();
        }

        private void btn_XEM_Click(object sender, EventArgs e)
        {
            Xrpt_LietKeKhachHangTheoTungChiNhanh rpt = new Xrpt_LietKeKhachHangTheoTungChiNhanh();

            rpt.Xrlabel_CN.Text = "NHỮNG KHÁCH HÀNH THUỘC " + cmb_CN.Text.ToUpper();
            ReportPrintTool print = new ReportPrintTool(rpt);
            print.ShowPreviewDialog();

        }

        private void frmLietKeKhachHangTheoTungChiNhanh_Load(object sender, EventArgs e)
        {
            cmb_CN.DataSource = Program.bds_dspm;
            cmb_CN.DisplayMember = "TENCN";
            cmb_CN.ValueMember = "TENSERVER";
            cmb_CN.SelectedIndex = Program.mChiNhanh;
            cmb_CN.Enabled = false;
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
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
