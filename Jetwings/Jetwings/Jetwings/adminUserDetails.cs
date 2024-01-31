using Microsoft.Reporting.WinForms;
using Microsoft.Reporting.WinForms.Internal.Soap.ReportingServices2005.Execution;
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
    public partial class adminUserDetails : Form
    {
        public adminUserDetails()
        {
            InitializeComponent();
            loadData();
        }
        private void loadData()
        {
            SqlConnection con = dbConnection.GetSqlConnection();

            SqlCommand cmd = new SqlCommand("SELECT * FROM CustomerTable  ", con);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            reportViewer1.LocalReport.DataSources.Clear();
            ReportDataSource ds = new ReportDataSource("DataSet2", dt);
            reportViewer1.LocalReport.ReportPath = @"C:\Users\Bishani Ushara\Documents\dulanjana\Jetwings\Jetwings\Jetwings\Jetwings\UserReport.rdlc";
            reportViewer1.LocalReport.DataSources.Add(ds);
            reportViewer1.RefreshReport();
        }

        private void adminUserDetails_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
        }
    }
}
