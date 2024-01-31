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
    public partial class Sigiriya : Form
    {
        private int id;
        public Sigiriya(int id)
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

        private void linkLabel_VilPackages_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SigiriyaPackagecs sigiri = new SigiriyaPackagecs(id);
            this.Hide();
            sigiri.Show();

        }

        private void btn_GetDirection_Click(object sender, EventArgs e)
        {
            // Specify the URL you want to open
            string url = "https://www.google.com/maps/place/Jetwing+Vil+Uyana/@7.9306317,80.7181695,17z/data=!3m1!4b1!4m10!3m9!1s0x3afca41d7265d791:0x37bf43fdb003dfd4!5m3!1s2024-05-01!4m1!1i2!8m2!3d7.9306264!4d80.7207444!16s%2Fg%2F1td6dxhj?entry=ttu";

            // Use Process.Start to open the URL in the default web browser
            Process.Start(url);
        }
    }
}
