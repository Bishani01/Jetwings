using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.Common;
using System.Data.Odbc;
using static db;


namespace Jetwings
{
    public partial class LoginNew : Form
    {
        public LoginNew()
        {
            InitializeComponent();
            txt_PWD.UseSystemPasswordChar = true;
        }
       




        private void chk_remember_CheckedChanged(object sender, EventArgs e)
        {
            if(chk_remember.Checked )
            {
                txt_PWD.UseSystemPasswordChar = false;
            }
            else
            {
                txt_PWD.UseSystemPasswordChar= true;
            }
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            if (txt_UserName.Text == "")
            {
                MessageBox.Show("Email Cannot be blank", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txt_PWD.Text == "")
            {
                MessageBox.Show("Password Cannot be blank", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                SqlConnection con = dbConnection.GetSqlConnection();

                // Use parameterized query to prevent SQL injection
                SqlCommand cmd = new SqlCommand("SELECT * FROM CustomerTable WHERE Cust_Email = @Email AND Cust_Password = @Password", con);
                cmd.Parameters.AddWithValue("@Email", txt_UserName.Text);
                cmd.Parameters.AddWithValue("@Password", txt_PWD.Text);

                con.Open();

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                if (dt.Rows.Count != 0)
                {
                    home1 Home = new home1();
                    Get.email = txt_UserName.Text;//Text Box eke design name eka meh thiyenne.
                    this.Hide();
                    Home.Show();
                    MessageBox.Show("Success", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Wrong Email or Password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


        private void btn_signUp_Click(object sender, EventArgs e)
        {
            this.Hide();
            SignUp signUp = new SignUp();
            signUp.Show();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Admin_login  admin = new Admin_login();
            admin.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
    }

