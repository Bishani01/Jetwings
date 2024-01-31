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
    public partial class KandyPackage : Form
    {
        private int id;
        public KandyPackage(int id)
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
            kandy H = new kandy(id);
            this.Hide();
            H.Show();
        }
    }
}
