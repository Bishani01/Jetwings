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
    public partial class hotels : Form
    {
        private int id;
        public hotels(int id)
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

        private void linkLabel_kandy_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            kandy Kandy = new kandy(id);
            this.Hide();
            Kandy.Show();
        }

        private void linkLabel_jafffna_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
           Jafna Jaffna = new Jafna(id);
            this.Hide();
            Jaffna.Show();
        }

        private void linkLabel_negambo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            negombo Negambo= new negombo(id);
            this.Hide();
            Negambo.Show();
        }

        private void linkLabel_sigiriya_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Sigiriya sigiriya = new Sigiriya(id);
            this.Hide();
            sigiriya.Show();
        }

        private void linkLabel_yala_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            yala Yala = new yala(id);
            this.Hide();
            Yala.Show();
        }

        private void linkLabel_dambulla_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Dambulla dambulla = new Dambulla(id);
            this.Hide();
            dambulla.Show();
        }
    }
}
