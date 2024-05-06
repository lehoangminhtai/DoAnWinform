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

namespace StudentManagement.GUI.ReportGUI
{
    public partial class Report : Form
    {
        public string reportpath { get; set; }
        public string dataset { get; set; }
        public DataTable dataTable { get; set; }
        public Report()
        {
            InitializeComponent();
        }

        private void Report_Load(object sender, EventArgs e)
        {
            this.reportViewer1.LocalReport.ReportPath = reportpath;

            this.reportViewer1.LocalReport.DataSources.Clear();
            var dataSource = new ReportDataSource(dataset, dataTable);

            this.reportViewer1.LocalReport.DataSources.Clear();
            this.reportViewer1.LocalReport.DataSources.Add(dataSource);
            this.reportViewer1.LocalReport.EnableExternalImages = true;


            this.reportViewer1.RefreshReport();

        }
    }
}
