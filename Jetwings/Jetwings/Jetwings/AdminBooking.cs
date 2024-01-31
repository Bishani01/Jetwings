using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static db;

namespace Jetwings
{
    public partial class AdminBooking : Form
    {
        public AdminBooking()
        {
            InitializeComponent();
            loadReport();
        }

        private void loadReport()
        {
            SqlConnection con = dbConnection.GetSqlConnection();

            SqlCommand cmd = new SqlCommand("SELECT * FROM BookingDetails  ", con);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            reportViewer1.LocalReport.DataSources.Clear();
            ReportDataSource ds = new ReportDataSource("DataSet3", dt);
            reportViewer1.LocalReport.ReportPath = @"C:\Users\Bishani Ushara\Documents\dulanjana\Jetwings\Jetwings\Jetwings\Jetwings\bookingDetails.rdlc";
            reportViewer1.LocalReport.DataSources.Add(ds);
            reportViewer1.RefreshReport();



        }
        private void AdminReport_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
            
        }
    }
}
