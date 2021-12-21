using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;

namespace QLNGANHANG
{
    public partial class Xrpt_LietKeTaiKhoanTrongMotKhoangThoiGian : DevExpress.XtraReports.UI.XtraReport
    {
        public Xrpt_LietKeTaiKhoanTrongMotKhoangThoiGian(String ngayBD, String ngayKT)
        {
            InitializeComponent();
            this.sqlDataSource1.Connection.ConnectionString = Program.connstr;
            this.sqlDataSource1.Connection.ConnectionString = Program.connstr;
            this.sqlDataSource1.Queries[0].Parameters[0].Value = ngayBD;
            this.sqlDataSource1.Queries[0].Parameters[1].Value = ngayKT;
            this.sqlDataSource1.Fill();
        }

    }
}
