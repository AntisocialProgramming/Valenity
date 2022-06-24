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
    public partial class LuaPad : UserControl
    {
        public Guna.UI2.WinForms.Guna2MessageDialog dialog = new Guna.UI2.WinForms.Guna2MessageDialog();
        OpenFileDialog openFileDialog1 = new OpenFileDialog();
        SaveFileDialog saveFileDialog1 = new SaveFileDialog();

        public LuaPad()
        {
            InitializeComponent();
            dialog.Style = Guna.UI2.WinForms.MessageDialogStyle.Dark;
            dialog.Caption = "Valenity Notepad";
            dialog.Buttons = Guna.UI2.WinForms.MessageDialogButtons.OK;
            dialog.Icon = Guna.UI2.WinForms.MessageDialogIcon.Information;
        }

        private void LuaPad_Load(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            guna2TextBox1.Clear();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "Text Files|*.txt|Valenity Text Files|*.val";
            saveFileDialog1.Title = "Save a Text File";
            saveFileDialog1.ShowDialog();
            string path = saveFileDialog1.FileName;
            if (path != "")
            {
                using (StreamWriter sw = File.CreateText(path))
                {
                    sw.WriteLine(guna2TextBox1.Text);
                }
            }
            dialog.Text = "Note Saved!";
            dialog.Show();
        }

        private void guna2Button3_Click(object sender, EventArgs e)
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
            dialog.Text = "Note Opened!";
            dialog.Show();
        }
    }
}
