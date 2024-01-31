﻿using System;
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
   
    public partial class DambullaPackage : Form
    {
        private int id;
        public DambullaPackage(int id)
        {
            InitializeComponent();
            this.id = id;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btn_BackToHome_Click(object sender, EventArgs e)
        {
            Dambulla H = new Dambulla(id);
            this.Hide();
            H.Show();
        }
    }
}
