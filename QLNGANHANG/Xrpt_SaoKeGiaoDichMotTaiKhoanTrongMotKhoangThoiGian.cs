using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;

namespace QLNGANHANG
{
    public partial class Xrpt_SaoKeGiaoDichMotTaiKhoanTrongMotKhoangThoiGian : DevExpress.XtraReports.UI.XtraReport
    {
        public Xrpt_SaoKeGiaoDichMotTaiKhoanTrongMotKhoangThoiGian(String soTK, String ngayBD, String ngayKT)
        {
            InitializeComponent();
            this.sqlDataSource1.Connection.ConnectionString = Program.connstr;
            this.sqlDataSource1.Queries[0].Parameters[0].Value = soTK;
            this.sqlDataSource1.Queries[0].Parameters[1].Value = ngayBD;
            this.sqlDataSource1.Queries[0].Parameters[2].Value = ngayKT;
            this.sqlDataSource1.Fill();
        }
    }
}
