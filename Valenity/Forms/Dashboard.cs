using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Valenity.Controls;

namespace ValenityDashboard
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();

        }

        private void Dashboard_FormClosing(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(0);
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            guna2Panel3.Controls.Clear();
            guna2Panel3.Controls.Add(new LuaPad());
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            guna2Panel3.Controls.Clear();
            guna2Panel3.Controls.Add(new SimpleAimTrainer());
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            backgroundWorker1.RunWorkerAsync();
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            if (DateTime.UtcNow.ToString("tt") == "AM")
            {
                label2.Text = DateTime.Now.ToString("hh:mm:ss") + " PM";
            }
            else
            {
                label2.Text = DateTime.Now.ToString("hh:mm:ss") + " AM";
            }
        }

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {

        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            backgroundWorker1.RunWorkerAsync();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            guna2Panel3.Controls.Clear();
            guna2Panel3.Controls.Add(new Scrambler());
        }
    }
}