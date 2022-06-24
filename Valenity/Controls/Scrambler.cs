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

namespace Valenity.Controls
{
    public partial class Scrambler : UserControl
    {
        OpenFileDialog openFileDialog1 = new OpenFileDialog();
        public Scrambler()
        {
            InitializeComponent();
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            string text = guna2TextBox1.Text;
            string scrambledText = "";
            foreach (char c in text)
            {
                scrambledText += (char)(c + guna2NumericUpDown2.Value);
            }

            guna2TextBox1.Text = scrambledText;
            
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            string text = guna2TextBox1.Text;
            string scrambledText = "";
            foreach (char c in text)
            {
                scrambledText += (char)(c - guna2NumericUpDown1.Value);
            }

            guna2TextBox1.Text = scrambledText;

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Text Files|*.txt|Valenity Text Files|*.val";
            openFileDialog1.Title = "Open a Text File";
            openFileDialog1.ShowDialog();
            string path = openFileDialog1.FileName;
            if (path != "")
            {
                using (StreamReader sr = File.OpenText(path))
                {
                    guna2TextBox1.Text = sr.ReadToEnd();
                }
            }
        }

        private void Scrambler_Load(object sender, EventArgs e)
        {

        }
    }
}
