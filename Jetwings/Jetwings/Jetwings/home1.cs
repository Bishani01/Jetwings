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
    public partial class home1 : Form
    {
        private int id;
        public home1(int id)
        {
            InitializeComponent();
            this.id = id;
            getName(id);

        }

        public void getName(int id)
        {
            SqlConnection con = dbConnection.GetSqlConnection();

            SqlCommand cmd = new SqlCommand("SELECT Cust_FName FROM CustomerTable WHERE Cust_ID = '" + id + "' ", con);

            con.Open();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count > 0)
            {

                label3.Text = dt.Rows[0]["Cust_FName"].ToString();
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

        private void btn_bookNow_Click(object sender, EventArgs e)
        {
            booking book = new booking(id);
            this.Hide();
            book.Show();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            colombo Colombo = new colombo(id);
            this.Hide();
            Colombo.Show();
        }

        private void btn_moreHotels_Click(object sender, EventArgs e)
        {
            hotels Hotels = new hotels(id);
            this.Hide();
            Hotels.Show();
        }

        private void profile_btn_click(object sender, EventArgs e)
        {
            Profile profile = new Profile(id);
            this.Hide();
            profile.Show();
        }

        private void btn_profile_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Report r = new Report(id);
            r.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {
           
        }

        private void guna2CircleButton1_Click(object sender, EventArgs e)
        {
            LoginNew loginNew = new LoginNew();
            this.Close();
            loginNew.Show();
        }
    }
}
