using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Valenity.Controls
{
    public partial class SimpleAimTrainer : UserControl
    {
        public SimpleAimTrainer()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            if (DoubleHit.Checked)
            {
                Confirmed.Text = (int.Parse(Confirmed.Text) + 2).ToString();
                Possible.Text = (int.Parse(Possible.Text) + 2).ToString();
            }
            else
            {
                Confirmed.Text = (int.Parse(Confirmed.Text) + 1).ToString();
                Possible.Text = (int.Parse(Possible.Text) + 1).ToString();
            }
            Random rnd = new Random();
            label3.Location = new Point(label3.Location.X + rnd.Next(-50, 50), label3.Location.Y + rnd.Next(-50, 50));
            if (label3.Location.Y > guna2GroupBox1.Height - label3.Height)
            {
                label3.Location = new Point(label3.Location.X, guna2GroupBox1.Height - label3.Height);
            }

            if (label3.Location.X > guna2GroupBox1.Width - label3.Width)
            {
                label3.Location = new Point(guna2GroupBox1.Width - label3.Width, label3.Location.Y);
            }
            if (label3.Location.X < 0)
            {
                label3.Location = new Point(0, label3.Location.Y);
            }
            if (label3.Location.Y < 0)
            {
                label3.Location = new Point(label3.Location.X, 0);
            }
        }


        private void guna2GroupBox1_Click(object sender, EventArgs e)
        {
            if (DoubleHit.Checked)
            {
                Misses.Text = (int.Parse(Misses.Text) + 2).ToString();
                Possible.Text = (int.Parse(Possible.Text) + 2).ToString();
            }
            else
            {
                Misses.Text = (int.Parse(Misses.Text) + 1).ToString();
                Possible.Text = (int.Parse(Possible.Text) + 1).ToString();
            }

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            double percent = (double.Parse(Confirmed.Text) / double.Parse(Possible.Text)) * 100;
            Accuracy.Text = percent.ToString("0.00") + "%";
        }

        private void SimpleAimTrainer_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void label10_Click(object sender, EventArgs e)
        {
            if (DoubleHit.Checked)
            {
                Confirmed.Text = (int.Parse(Confirmed.Text) + 2).ToString();
                Possible.Text = (int.Parse(Possible.Text) + 2).ToString();
            }
            else
            {
                Confirmed.Text = (int.Parse(Confirmed.Text) + 1).ToString();
                Possible.Text = (int.Parse(Possible.Text) + 1).ToString();
            }
            Random rnd = new Random();
            label10.Location = new Point(label10.Location.X + rnd.Next(-50, 50), label10.Location.Y + rnd.Next(-50, 50));
            if (label10.Location.Y > guna2GroupBox1.Height - label10.Height)
            {
                label10.Location = new Point(label10.Location.X, guna2GroupBox1.Height - label10.Height);
            }

            if (label10.Location.X > guna2GroupBox1.Width - label10.Width)
            {
                label10.Location = new Point(guna2GroupBox1.Width - label10.Width, label10.Location.Y);
            }
            if (label10.Location.X < 0)
            {
                label10.Location = new Point(0, label10.Location.Y);
            }
            if (label10.Location.Y < 0)
            {
                label10.Location = new Point(label10.Location.X, 0);
            }
        }

        private async void guna2Button1_Click(object sender, EventArgs e)
        {
            if (AddTarget.Checked)
            {
                AddTarget.Text = "Already Bought!";
                AddTarget.FillColor = Color.DarkGreen;
                await Task.Delay(3000);
                AddTarget.Text = "Bought!";
                AddTarget.FillColor = Color.Green;
            }
            else
            if (int.Parse(Confirmed.Text) > 50 )
            {
                label10.Visible = true;
                _ = int.Parse(Confirmed.Text) - 50;
                AddTarget.Text = "Bought!";
                AddTarget.Checked = true;
                AddTarget.FillColor = Color.Green;
            }
            else
            {
                AddTarget.Text = "Can't Afford!";
                AddTarget.FillColor = Color.Red;
                await Task.Delay(3000);
                AddTarget.Text = "Add Another Target - 50 Hits";
                AddTarget.FillColor = Color.Transparent;
            }
        }

        private async void guna2Button2_Click(object sender, EventArgs e)
        {
            double percent = (double.Parse(Confirmed.Text) / double.Parse(Possible.Text)) * 100;
            if (ResetMisses.Checked)
            {
                ResetMisses.Text = "Already Bought!";
                ResetMisses.FillColor = Color.DarkGreen;
                await Task.Delay(3000);
                ResetMisses.Text = "Bought!";
                ResetMisses.FillColor = Color.Green;
            }
            else
            if (percent > 90)
            {
                Misses.Text = "0";
                Possible.Text = Confirmed.Text;
                ResetMisses.Text = "Bought!";
                ResetMisses.FillColor = Color.Green;
                ResetMisses.Checked = true;
            }
            else
            {
                ResetMisses.Text = "Can't Afford!";
                ResetMisses.FillColor = Color.Red;
                await Task.Delay(3000);
                ResetMisses.Text = "Reset Misses - 90+ Accuracy";
                ResetMisses.FillColor = Color.Transparent;
            }
        }

        private async void guna2Button3_Click(object sender, EventArgs e)
        {
            if (DoubleHit.Checked)
            {
                Possible.Text = Confirmed.Text;
                DoubleHit.Text = "Already Bought!";
                DoubleHit.FillColor = Color.DarkGreen;
                await Task.Delay(3000);
                DoubleHit.Text = "Bought!";
                DoubleHit.FillColor = Color.Green;
            }
            else
            if (int.Parse(Confirmed.Text) >= 100)
            {
                Confirmed.Text = (int.Parse(Confirmed.Text) - 100).ToString();
                DoubleHit.Checked = true;
                DoubleHit.Text = "Bought!";
                DoubleHit.FillColor = Color.Green;
            }
            else
            {
                DoubleHit.Text = "Can't Afford!";
                DoubleHit.FillColor = Color.Red;
                await Task.Delay(3000);
                DoubleHit.Text = "Double Hit - 100 Hits";
                DoubleHit.FillColor = Color.Transparent;
            }
        }
    }
}
