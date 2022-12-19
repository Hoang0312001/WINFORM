using ManagerFoodGUI.DTO;
using ManagerFoodGUI.service;
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

namespace ManagerFoodGUI
{
    public partial class FReport : Form
    {
        public FReport()
        {
            InitializeComponent();
        }

        private void FReport_Load(object sender, EventArgs e)
        {
            List<RpBillDTO> list = ReportService.FindAll(53);
            
            reportViewer1.LocalReport.ReportPath = "ReportBill.rdlc";
            var source = new ReportDataSource("DSBILL", list);
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(source);
            ReportParameterCollection reportParameters = new ReportParameterCollection();
            reportParameters.Add(new ReportParameter("TotalPrice","Xin chao"));
            this.reportViewer1.LocalReport.SetParameters(reportParameters);
            this.reportViewer1.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
