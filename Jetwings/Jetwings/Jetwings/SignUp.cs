using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.Common;
using static db;
using System.Net.Mail;

namespace Jetwings
{
    public partial class SignUp : Form
    {
        private string userEmail;
        private object randomNumber;
        public SignUp()
        {
            InitializeComponent();
            txt_PWD.UseSystemPasswordChar = true;
            txt_CPWD.UseSystemPasswordChar = true;


        }
        


        private void guna2Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_SignUp_Click(object sender, EventArgs e)
        {
            SqlConnection con = dbConnection.GetSqlConnection();


            try
            {
                if (txt_FirstName.Text.Length == 0)
                {
                    MessageBox.Show("First Name Connt Be Blank", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (txt_FirstName.Text.Any(char.IsDigit))
                {
                    MessageBox.Show("Name Connt Have Numbers", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (txt_LastName.Text.Length == 0)
                {
                    MessageBox.Show("Last Name Connt Be Blank", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (txt_LastName.Text.Any(char.IsDigit))
                {
                    MessageBox.Show("Last Name Connt Have Numbers", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (!Regex.IsMatch(txt_Email.Text, @"^[a-zA-Z][\w\.-]*[a-zA-Z0-9]@[a-zA-Z0-9][\w\.-]*[a-zA-Z0-9]\.[a-zA-Z][a-zA-Z\.]*[a-zA-Z]$"))
                {
                    MessageBox.Show("Please Enter a Valid Email", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (txt_Address.Text.Length == 0)
                {
                    MessageBox.Show("Address Cannot Be Blank", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (txt_PWD.Text.Length <= 6)
                {
                    MessageBox.Show("Pasword Must Be Greater Than 6 Characters", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (txt_PWD.Text != txt_CPWD.Text)
                {

                    MessageBox.Show("Pasword Does Not Match", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (txt_CPWD.Text.Length == 0)
                {
                    MessageBox.Show("Pasword Cannot Be Blank", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                   

                    SqlCommand cmd = new SqlCommand("INSERT INTO CustomerTable (Cust_FName, Cust_LName, Cust_Email, Cust_Address, Cust_Gender, Cust_Password,Cust_SecurityQuestion, Cust_QuestionAnswer) VALUES ('" + txt_FirstName.Text + "','" + txt_LastName.Text + "','" + txt_Email.Text + "','" + txt_Address.Text + "','" + cmb_Gender.Text + "','" + txt_PWD.Text + "','" + cmb_Security.Text + "','" + txt_Answer.Text + "')",con);
                    con.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Registration Successfully.", " Success" + MessageBoxButtons.OK + MessageBoxIcon.Information);



                    LoginNew loginNew = new LoginNew();
                    loginNew.Show();
                    this.Hide();

                  

                  
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("FormatException", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            
        }

        private void linkLabel_LogInHere_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            LoginNew loginNew = new LoginNew();
            loginNew.Show();  
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            userEmail = txt_Email.Text;

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

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            int r = Convert.ToInt32(randomNumber);
            int otp = Convert.ToInt32(txt_OTP.Text);
            userEmail= txt_Email.Text;

            if (r == otp)
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
    }
}
