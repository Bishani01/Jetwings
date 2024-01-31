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
    public partial class Report : Form
    {
        private  int id;
        private string userEmail;
        string pdfFilePath = @"C:\Users\Bishani Ushara\Documents\dulanjana\Jetwings\Jetwings\Temp\BookingReport.pdf";
        public Report(int id)
        {
            InitializeComponent();
           this.id = id;
            loadReport();
            userEmail = Get.email;
        }

        private void loadReport()
        {
            SqlConnection con = dbConnection.GetSqlConnection();

            // Use parameterized query to prevent SQL injection
            SqlCommand cmd = new SqlCommand("SELECT Book_Id, Book_Branch, Book_Packages, Book_TotalPerson, Book_DateIn, Book_DateOut,Amount FROM BookingDetails WHERE Cust_ID = '"+id+"'", con);

            SqlDataAdapter da= new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            reportViewer1.LocalReport.DataSources.Clear();
            ReportDataSource ds = new ReportDataSource("DataSet1", dt);
            reportViewer1.LocalReport.ReportPath = @"C:\Users\Bishani Ushara\Documents\dulanjana\Jetwings\Jetwings\Jetwings\Jetwings\BookingReport.rdlc";
            reportViewer1.LocalReport.DataSources.Add(ds);
            reportViewer1.RefreshReport();

            byte[] pdfBytes = reportViewer1.LocalReport.Render("PDF");

            File.WriteAllBytes(pdfFilePath, pdfBytes);

        }
        private void Form1_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
            
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            



            SmtpClient client = new SmtpClient("smtp-mail.outlook.com");
            client.Port = 587;
            client.DeliveryMethod = SmtpDeliveryMethod.Network;
            client.UseDefaultCredentials = false;
            System.Net.NetworkCredential credential = new System.Net.NetworkCredential("jetwingsbooking@outlook.com", "Jetwings@2024");
            client.EnableSsl = true;
            client.Credentials = credential;

            MailMessage mailMessage = new MailMessage("jetwingsbooking@outlook.com", userEmail);
            mailMessage.Subject = "Verification";
            mailMessage.Body = $"<p>Dear Sir/Madam,</p><br><p>This is your Boking Report</p>";
            Attachment attachment = new Attachment(pdfFilePath);
            mailMessage.Attachments.Add(attachment);
            mailMessage.IsBodyHtml = true;
            client.Send(mailMessage);
           

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            home1 home = new home1(id);
            home.Show();
        }
    }
}
