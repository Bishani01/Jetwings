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
    public partial class ColomboPackages : Form
    {
        public ColomboPackages()
        {
            InitializeComponent();
        }
        private void AddUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
        }


        private void btn_standard_Click(object sender, EventArgs e)
        {

        }
    }
}
