using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Jetwings
{
    public partial class verifyOTP : Form
    {
        private string userEmail;
        private object randomNumber;

        public verifyOTP()
        {
            InitializeComponent();
            this.userEmail = Get.email;
            loadEmail();
        }

        private void loadEmail()
        {
            lbl_email2.Text = userEmail;

            
        }

        private void button1_Click(object sender, EventArgs e)
        {

            Random random = new Random();
            randomNumber = (random.Next(999999)).ToString();
            MessageBox.Show("OTP Send Success .", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            

            SmtpClient client = new SmtpClient("smtp-mail.outlook.com");
            client.Port = 587;
            client.DeliveryMethod = SmtpDeliveryMethod.Network;
            client.UseDefaultCredentials = false;
            System.Net.NetworkCredential credential = new System.Net.NetworkCredential("jetwingsbooking@outlook.com", "Jetwings@2024");
            client.EnableSsl = true;
            client.Credentials = credential;

            MailMessage mailMessage = new MailMessage("jetwingsbooking@outlook.com", userEmail);
            mailMessage.Subject = "Verification";
            mailMessage.Body = $"<p>Dear Sir/Madam,</p><br><p>Your Otp is : {randomNumber} </p>";
            mailMessage.IsBodyHtml = true;
            client.Send(mailMessage);
        }

        private void btn_verify_Click(object sender, EventArgs e)
        {
           int r = Convert.ToInt32(randomNumber);
            int otp= Convert.ToInt32(txt_OTP.Text);

            if (r == otp )
            {
                MessageBox.Show("Verification successful.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                SmtpClient client = new SmtpClient("smtp-mail.outlook.com");
                client.Port = 587;
                client.DeliveryMethod = SmtpDeliveryMethod.Network;
                client.UseDefaultCredentials = false;
                System.Net.NetworkCredential credential = new System.Net.NetworkCredential("jetwingsbooking@outlook.com", "Jetwings@2024");
                client.EnableSsl = true;
                client.Credentials = credential;

                MailMessage mailMessage = new MailMessage("jetwingsbooking@outlook.com", userEmail);
                mailMessage.Subject = "Verification";
                mailMessage.Body = $"<p>Dear Sir/Madam,</p><br><p>Your Account is Verified!</p>";
                mailMessage.IsBodyHtml = true;
                client.Send(mailMessage);
            }
            else
            {
                MessageBox.Show("Failed.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            home1 h = new home1();
            h.Show();
        }
    }
}
