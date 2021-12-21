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
    public partial class frmSaoKeGiaoDichTaiKhoanTrongKhangThoiGian : Form
    {
        public frmSaoKeGiaoDichTaiKhoanTrongKhangThoiGian()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void frmSaoKeGiaoDichTaiKhoanTrongKhangThoiGian_Load(object sender, EventArgs e)
        {

        }

        private void btn_XEM_Click(object sender, EventArgs e)
        {
            String ngayBD = dt_BD.Text;
            String ngayKT = dt_KT.Text;
            String soTK = txt_TK.Text;

            if (!dt_BD.Text.Equals(""))
            {
                ngayBD = DateTime.ParseExact(dt_BD.Text, "dd/MM/yyyy", null).ToString("yyyy/MM/dd");
            }
            else
            {
                ngayBD = DateTime.ParseExact("01/01/2000", "dd/MM/yyyy", null).ToString("yyyy/MM/dd");
            }
            if (!dt_KT.Text.Equals(""))
            {
                ngayKT = DateTime.ParseExact(dt_KT.Text, "dd/MM/yyyy", null).ToString("yyyy/MM/dd");
            }
            else
            {
                ngayKT = DateTime.Now.ToString("yyyy/MM/dd");
            }

            Xrpt_SaoKeGiaoDichMotTaiKhoanTrongMotKhoangThoiGian rpt = new Xrpt_SaoKeGiaoDichMotTaiKhoanTrongMotKhoangThoiGian(soTK, ngayBD, ngayKT);

            rpt.label_SaoKeTK.Text = "SAO KÊ GIAO DỊCH TÀI KHOẢN  " + soTK + " TỪ NGÀY " + DateTime.ParseExact(ngayBD, "yyyy/MM/dd", null).ToString("dd/MM/yyyy") + " ĐẾN NGÀY " + DateTime.ParseExact(ngayKT, "yyyy/MM/dd", null).ToString("dd/MM/yyyy");

            ReportPrintTool print = new ReportPrintTool(rpt);
            print.ShowPreviewDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
