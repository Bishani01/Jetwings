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
    public partial class negombo : Form
    {
        private int id;
        public negombo(int id)
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

        private void linkLabel_seePackages_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void linkLabel_negamboPackages_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            NegamboPackage negambo = new NegamboPackage(id);
            this.Hide();
            negambo.Show();
        }

        private void btn_GetDirection_Click(object sender, EventArgs e)
        {
            // Specify the URL you want to open
            string url = "https://www.google.com/maps/place/Jetwing+Beach/@7.2446709,79.8391187,17z/data=!4m10!3m9!1s0x3ae2ee93b81bfe0f:0xed44bdcb739b0509!5m3!1s2024-05-01!4m1!1i2!8m2!3d7.2446656!4d79.8416936!16s%2Fg%2F1tk66386?entry=ttu";

            // Use Process.Start to open the URL in the default web browser
            Process.Start(url);
        }
    }
}
