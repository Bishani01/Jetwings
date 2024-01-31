using Org.BouncyCastle.Asn1.Ocsp;
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
    public partial class editprofile : Form
    {
        private int id;
        public editprofile(int id)
        {
            InitializeComponent();
            this.id = id;
            loadData();
        }

        private void loadData()
        {
            SqlConnection con = dbConnection.GetSqlConnection();

            SqlCommand cmd = new SqlCommand("SELECT * FROM CustomerTable WHERE Cust_ID = '"+id+"' ", con);

            con.Open();

            try
            {

                SqlDataReader reader = cmd.ExecuteReader();
                
                while (reader.Read())
                {

                    txt_FirstName.Text = reader["Cust_FName"].ToString();
                    txt_LastName.Text = reader["Cust_LName"].ToString();
                    txt_Email.Text = reader["Cust_Email"].ToString();
                    txt_Address.Text = reader["Cust_Address"].ToString();

                }


                reader.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error: " + ex.Message);
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

        private void btn_SignUp_Click(object sender, EventArgs e)
        {
            SqlConnection con = dbConnection.GetSqlConnection();

            if (txt_FirstName.Text != "" && txt_LastName.Text != "" && txt_Email.Text != "" && txt_Address.Text != "")
            {
                SqlCommand cmd = new SqlCommand("Update CustomerTable SET Cust_FName = '" + txt_FirstName.Text + "', Cust_LName = '" + txt_LastName.Text + "' ,Cust_Email = '" + txt_Email.Text + "' ,Cust_Address = '" + txt_Address.Text + "' WHERE Cust_ID = '" + id + "' ", con);
                con.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Your Details update Successfully.", " Success" + MessageBoxButtons.OK + MessageBoxIcon.Information);





            }
            else
            {
                MessageBox.Show("No Info entered.", "Error" + MessageBoxButtons.OK + MessageBoxIcon.Warning);
            }
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            EditPassword edit =new EditPassword(id);
            this.Hide();
            edit.Show();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            Profile profile = new Profile(id);
            profile.Show();
            this.Hide();
            
        }
        
private void guna2Button3_Click(object sender, EventArgs e)
        {
          //  txt_FirstName.Clear();
           // txt_LastName.Clear();
          //  txt_Email.Clear();
           //  txt_Address.Clear();
        }

        private void btn_click(object sender, EventArgs e)
        {
            home1 home1 = new home1(id);
            home1.Show();
            this.Hide();

        }
    }
}
