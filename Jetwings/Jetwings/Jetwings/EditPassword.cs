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
    public partial class EditPassword : Form
    {
        private int id;
        private string password;
        public EditPassword(int id)
        {
            InitializeComponent();
            this.id = id;
            getPassword();
        }

        private void getPassword()
        {
            SqlConnection con = dbConnection.GetSqlConnection();

            SqlCommand cmd = new SqlCommand("SELECT * FROM CustomerTable WHERE Cust_ID = '" + id + "' ", con);

            con.Open();
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                password = reader["Cust_Password"].ToString();
                
                

            }


            reader.Close();
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btn_SignUp_Click(object sender, EventArgs e)
        {
            SqlConnection con = dbConnection.GetSqlConnection();

            if (txt_crrntpass.Text == "" && txt_new.Text == "" && txt_con.Text == "")
            {
                MessageBox.Show("No Info entered.", "Error" + MessageBoxButtons.OK + MessageBoxIcon.Warning);
                
            }
            else if(txt_crrntpass.Text != password)
            {
                MessageBox.Show("Current Password is incorrect!.", "Error" + MessageBoxButtons.OK + MessageBoxIcon.Warning);
            }
            else if(txt_new.Text != txt_con.Text)
            {
                MessageBox.Show("Password Mismatch.", "Error" + MessageBoxButtons.OK + MessageBoxIcon.Warning);
            }
            else
            {
                SqlCommand cmd = new SqlCommand("Update CustomerTable SET Cust_Password = '" + txt_new.Text + "' WHERE Cust_ID = '" + id + "' ", con);
                con.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Your Password update Successfully.", " Success" + MessageBoxButtons.OK + MessageBoxIcon.Information);
                txt_crrntpass.Text = "";
                txt_new.Text = "";
                txt_con.Text = "";
            }
        }
    }
}
