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
    public partial class Dambulla : Form
    {
        private int id;
        public Dambulla(int id)
        {
            InitializeComponent();
            this.id = id;
        }

        private void label1_Click(object sender, EventArgs e)
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

        private void linkLabel_LakePackages_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DambullaPackage Dambulla = new DambullaPackage(id);
            this.Hide();
            Dambulla.Show();

        }

        private void btn_GetDirection_Click(object sender, EventArgs e)
        {
            // Specify the URL you want to open
            string url = "https://www.google.com/maps/place/Jetwing+Lake/@7.839768,80.646453,17z/data=!3m1!4b1!4m9!3m8!1s0x3afca1469fcf09c9:0xf1f80bc7dc3de0b!5m2!4m1!1i2!8m2!3d7.8397627!4d80.6490279!16s%2Fg%2F11c5bv_xt_?entry=ttu";

            // Use Process.Start to open the URL in the default web browser
            Process.Start(url);
        }
    }
}
