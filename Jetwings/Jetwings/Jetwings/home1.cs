using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Jetwings
{
    public partial class home1 : Form
    {
        public home1()
        {
            InitializeComponent();
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
            booking book = new booking();
            this.Hide();
            book.Show();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            colombo Colombo = new colombo();
            this.Hide();
            Colombo.Show();
        }

        private void btn_moreHotels_Click(object sender, EventArgs e)
        {
            hotels Hotels = new hotels();
            this.Hide();
            Hotels.Show();
        }

        private void profile_btn_click(object sender, EventArgs e)
        {
            Profile profile = new Profile();
            this.Hide();
            profile.Show();
        }

        private void btn_profile_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_verify_Click(object sender, EventArgs e)
        {
            this.Hide();
            verifyOTP verifyOTP = new verifyOTP();
            verifyOTP.Show();
        }
    }
}
