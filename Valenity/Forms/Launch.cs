using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ValenityDashboard;

namespace Valenity
{
    public partial class Launch : Form
    {
        Dashboard dash = new Dashboard();

        public Launch()
        {
            InitializeComponent();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            guna2ProgressBar1.Value += 1;
            if (guna2ProgressBar1.Value == 100)
            {
                timer1.Enabled = false;
                    this.Hide();
                    dash.Show();
            }
        }
    }
}
