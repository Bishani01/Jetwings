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
    public partial class kandy : Form
    {
        private int id;
        public kandy(int id)
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

        private void btn_backToHome_Click(object sender, EventArgs e)
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

        private void linkLabel_KandyPackages_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            KandyPackage kandy = new KandyPackage(id);
            this.Hide();
            kandy.Show();
        }

        private void btn_GetDirection_Click(object sender, EventArgs e)
        {
            // Specify the URL you want to open
            string url = "https://www.google.com/maps/place/Jetwing+Kandy+Gallery/@7.2663264,80.7047503,17z/data=!4m10!3m9!1s0x3ae3670709e8624f:0xbfb0a100b2434291!5m3!1s2024-05-01!4m1!1i2!8m2!3d7.2663211!4d80.7096212!16s%2Fg%2F11fmc00d7z?entry=ttu";

            // Use Process.Start to open the URL in the default web browser
            Process.Start(url);
        }
    }
}
