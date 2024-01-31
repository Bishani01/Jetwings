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
    public partial class Admin_login : Form
    {
        public Admin_login()
        {
            InitializeComponent();
        }

        private void Admin_login_Load(object sender, EventArgs e)
        {

        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            if (txt_Adm_UserName.Text == "")
            {
                MessageBox.Show("Username Cannot be blank", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else if (txt_Adm_PWD.Text == "")
            {
                MessageBox.Show("Password Cannot be blank", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            
            else
            {

                SqlConnection con = dbConnection.GetSqlConnection();

                SqlCommand cmd = new SqlCommand("Select * from AdminTable where Adm_Username='" + txt_Adm_UserName.Text + "' and Adm_Password ='" + txt_Adm_PWD.Text + "' ", con);

                con.Open();


                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                if (dt.Rows.Count != 0)
                {

                    AdminDashboard dashboard = new AdminDashboard();
                    Get.email = txt_Adm_UserName.Text;
                    this.Hide();
                    dashboard.Show();

                    MessageBox.Show("Success", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }

                else
                {
                    MessageBox.Show("Wrong Username OR Password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void checkBox_ShowPWD_CheckedChanged(object sender, EventArgs e)
        {
            if (txt_Adm_UserName.Text == "")
            {
                MessageBox.Show("Username Cannot be blank", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else if (txt_Adm_PWD.Text == "")
            {
                MessageBox.Show("Password Cannot be blank", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
    }
}
    

