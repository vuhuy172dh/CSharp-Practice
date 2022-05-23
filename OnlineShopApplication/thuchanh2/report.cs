using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace thuchanh2
{
    public partial class report : Form
    {
        public report()
        {
            InitializeComponent();
            
        }

        private void report_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
        }

        public void Load_data()
        {
            reportViewer1.ProcessingMode = Microsoft.Reporting.WinForms.ProcessingMode.Local;
            reportViewer1.LocalReport.ReportPath = @"E:\PERSONAL\C#\thuchanh2\thuchanh2\ReportBill.rdlc";

            /*ReportDataSource dts = new ReportDataSource();
            dts.Name = "dsReportBill";
            dts.Value = table;
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(dts);

            ReportParameter para1 = new ReportParameter();
            para1.Name = "Name";
            para1.Values.Add(table.Rows[0]["Name"].ToString());*/


        }
    }
}
