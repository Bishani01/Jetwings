using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static db;

namespace Jetwings
{
    public partial class Bill : Form
    {
        private int id;
        private int bookinid;
        private string userEmail;
        string pdfFilePath = @"C:\Users\Bishani Ushara\Documents\dulanjana\new\Jetwings\Temp\BookingReport.pdf";
        public Bill(int bookingid,int id,string email)
        {
            InitializeComponent();
            this.bookinid = bookingid;
            this.id = id;
            loadReport();
            this.userEmail = email;
            
        }
        
        private void loadReport()
        {
            SqlConnection con = dbConnection.GetSqlConnection();

            // Use parameterized query to prevent SQL injection
            SqlCommand cmd = new SqlCommand("SELECT Book_Id,Book_Branch, Book_Packages, Book_TotalPerson, Book_DateIn, Book_DateOut,Amount FROM BookingDetails WHERE Cust_ID = '" + id + "' AND Book_Id='" + bookinid + "'", con);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            reportViewer1.LocalReport.DataSources.Clear();
            ReportDataSource ds = new ReportDataSource("DataSet1", dt);
            reportViewer1.LocalReport.ReportPath = @"C:\Users\Bishani Ushara\Documents\dulanjana\new\Jetwings\Jetwings\Jetwings\BookingReport.rdlc";
            reportViewer1.LocalReport.DataSources.Add(ds);
            reportViewer1.RefreshReport();

            byte[] pdfBytes = reportViewer1.LocalReport.Render("PDF");

            File.WriteAllBytes(pdfFilePath, pdfBytes);
            SmtpClient client = new SmtpClient("smtp-mail.outlook.com");
            client.Port = 587;
            client.DeliveryMethod = SmtpDeliveryMethod.Network;
            client.UseDefaultCredentials = false;
            System.Net.NetworkCredential credential = new System.Net.NetworkCredential("jetwingsbooking@outlook.com", "Jetwings@2024");
            client.EnableSsl = true;
            client.Credentials = credential;

            

            MailMessage mailMessage = new MailMessage("jetwingsbooking@outlook.com", "bishaniusharapersonal@gmail.com");
            mailMessage.Subject = "Verification";
            mailMessage.Body = $"<p>Dear Sir/Madam,</p><br><p>Bill</p>";
            mailMessage.IsBodyHtml = true;
            client.Send(mailMessage);

        }

        private void Bill_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
        }
    }
}
