using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;

namespace QLNGANHANG
{
    public partial class Xrpt_LietKeKhachHangTheoTungChiNhanh : DevExpress.XtraReports.UI.XtraReport
    {
        public Xrpt_LietKeKhachHangTheoTungChiNhanh()
        {
            InitializeComponent();
            this.sqlDataSource1.Connection.ConnectionString = Program.connstr;
        }

    }
}
