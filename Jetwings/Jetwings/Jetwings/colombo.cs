using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;


namespace Jetwings
{
    public partial class colombo : Form
    {
        private int id;
        public colombo(int id)
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

        private void btn_BackToHome_Click(object sender, EventArgs e)
        {
            home1 Home = new home1(id);
            this.Hide();
            Home.Show();
        }

        private void btn_BookNow_Click(object sender, EventArgs e)
        {
            booking book = new booking(id);
            this.Hide();
            book.Show();
        }

        private void linkLabel_ColomboPackages_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ColomboPackage colombo = new ColomboPackage(id);
            this.Hide();
            colombo.Show();
        }

        private void btn_GetDirections_Click(object sender, EventArgs e)
        {
            // Specify the URL you want to open
            string url = "https://www.google.com/maps/place/Jetwing+Colombo+Seven/@6.916399,79.8676404,17z/data=!3m1!4b1!4m9!3m8!1s0x3ae2597469f068fb:0x43b14316f67e3c8a!5m2!4m1!1i2!8m2!3d6.9163937!4d79.8702153!16s%2Fg%2F11cmrwls4l?entry=ttu";

            // Use Process.Start to open the URL in the default web browser
            Process.Start(url);

        }
    }
}
