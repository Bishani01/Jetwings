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
using MimeKit;
using System.Net.Mail;

namespace Jetwings
{
    public partial class Profile : Form
    {

        private string userEmail;
        private int id;
        public Profile(int id)
        {
            InitializeComponent();
            this.userEmail = Get.email;
            Profile_Load(this, EventArgs.Empty);
            this.id = id;

        }
        
       

        private void btn_history_Click(object sender, EventArgs e)
        {
            OngoinhAndHistory ongoing = new OngoinhAndHistory();
            this.Hide();
            ongoing.Show();
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
           home1 home  = new home1(id);
            this.Hide();
            home.Show();
        }

        private void Profile_Load(object sender, EventArgs e)
        {
            SqlConnection con = dbConnection.GetSqlConnection();

            try
            {
                con.Open();

                SqlCommand getUserDataCmd = new SqlCommand("SELECT * FROM CustomerTable WHERE Cust_Email = @Email", con);
                getUserDataCmd.Parameters.AddWithValue("@Email", userEmail);

                SqlDataReader reader = getUserDataCmd.ExecuteReader();
                
                if (reader.Read())
                {
                    lbl_id.Text = reader["Cust_ID"].ToString();
                    lbl_FirstName.Text = reader["Cust_FName"].ToString();
                    lbl_LastName.Text = reader["Cust_LName"].ToString();
                    lbl_Email.Text = reader["Cust_Email"].ToString();
                    lbl_Address.Text = reader["Cust_Address"].ToString();
                    lbl_Gender.Text = reader["Cust_Gender"].ToString();

                    // ... Other fields
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading user data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                con.Close();
            }
        }

        private void btn_delete_Click_1(object sender, EventArgs e)
        {
            // Prompt the user for confirmation
            DialogResult result = MessageBox.Show("Are you sure you want to delete your profile?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                // User confirmed, proceed with deletion
                DeleteUserProfile();
            }
        }

        private void DeleteUserProfile()
        {
            SqlConnection con = dbConnection.GetSqlConnection();

            try
            {
                
                SqlCommand cmd = new SqlCommand("DELETE FROM BookingDetails WHERE Cust_ID = '" + lbl_id.Text + "'", con);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                SqlCommand deleteCmd = new SqlCommand("DELETE FROM CustomerTable WHERE Cust_ID = '"+lbl_id.Text+"'", con);
                deleteCmd.Parameters.AddWithValue("@Email", userEmail); // assuming userEmail is the user's email stored in the class
                con.Open();
                int rowsAffected = deleteCmd.ExecuteNonQuery();

               


                if (rowsAffected > 0)
                {
                   
                    

                    MessageBox.Show("Profile deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();

                    SmtpClient client = new SmtpClient("smtp-mail.outlook.com");
                    client.Port = 587;
                    client.DeliveryMethod = SmtpDeliveryMethod.Network;
                    client.UseDefaultCredentials = false;
                    System.Net.NetworkCredential credential = new System.Net.NetworkCredential("jetwingsbooking@outlook.com", "Jetwings@2024");
                    client.EnableSsl = true;
                    client.Credentials = credential;

                    MailMessage mailMessage = new MailMessage("jetwingsbooking@outlook.com", userEmail);
                    mailMessage.Subject = "Account Deletion";
                    mailMessage.Body = "<p>Dear sir/madam,</p><br><br><p>Profile deleted successfully </p>";
                    mailMessage.IsBodyHtml = true;
                    client.Send(mailMessage);

                }
                else
                {
                    MessageBox.Show("No matching record found for deletion.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error deleting user profile: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                LoginNew login = new LoginNew();
                this.Hide();
                login.Show();
            }
        }


        private void btn_edit_Click_1(object sender, EventArgs e)
        {
            editprofile Edit = new editprofile(id);
            this.Hide();
            Edit.Show();

        }
    }
 }

