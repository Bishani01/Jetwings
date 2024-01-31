using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Jetwings
{
    public partial class yala : Form
    {
        private int id;
        public yala(int id)
        {
            InitializeComponent();
            this.id = id;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btn_BacktoHome_Click(object sender, EventArgs e)
        {
            home1 Home = new home1(id);
            this.Hide();
            Home.Show();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            booking book = new booking(id);
            this.Hide();
            book.Show();
        }

        private void linkLabel_seePackages_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            YalaPackages Yala  = new YalaPackages(id);
            this.Hide();
            Yala.Show();
        }

        private void yala_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            // Specify the URL you want to open
            string url = "https://www.google.com/maps/place/Jetwing+Yala/@6.2506417,81.393197,17z/data=!4m10!3m9!1s0x3ae68477e6d79f69:0x9124ee613ef930c4!5m3!1s2024-05-01!4m1!1i2!8m2!3d6.2506364!4d81.3957719!16s%2Fg%2F11btm80dfm?entry=ttu";

            // Use Process.Start to open the URL in the default web browser
            Process.Start(url);
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
