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
    public partial class Jafna : Form
    {
        private int id;
        public Jafna(int id)
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

        private void btn_BackToHome_Click(object sender, EventArgs e)
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

        private void linkLabel_JaffnaPackages_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            JaffnaPackage jaffna  = new JaffnaPackage(id);
            this.Hide();
            jaffna.Show();
        }

        private void btn_GetDirection_Click(object sender, EventArgs e)
        {
            // Specify the URL you want to open
            string url = "https://www.google.com/maps/place/Jetwing+Jaffna/@9.6646971,80.0110796,17z/data=!4m10!3m9!1s0x3afe56aa3b5ed5d1:0x833c08ea7eb5685e!5m3!1s2024-05-01!4m1!1i2!8m2!3d9.6646918!4d80.0136545!16s%2Fg%2F11cny2__y1?entry=ttu";

            // Use Process.Start to open the URL in the default web browser
            Process.Start(url);
        }
    }
}
