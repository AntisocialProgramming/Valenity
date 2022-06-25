using Memory;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Input;

namespace Valenity.Forms
{
    public partial class Borderlands2 : Form
    {
        public Mem mem = new Mem();
        public string name;
        string heh;
        public Borderlands2()
        {
            InitializeComponent();
            mem.OpenProcess("Borderlands2");

            name = mem.ReadString("Borderlands2.exe+016B1C30,1A4");
            StartPosition = FormStartPosition.Manual;
            Location = new Point(15, 15);
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void guna2CheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (guna2CheckBox1.Checked)
            {
                float health;
                health = mem.ReadFloat("Borderlands2.exe+016949D8,24,3A4,1AC,28,1B0,6C");
                mem.FreezeValue("Borderlands2.exe+016949D8,24,3A4,1AC,28,1B0,6C", "float", health.ToString());
            }
            else
            {
                mem.UnfreezeValue("Borderlands2.exe+016949D8,24,3A4,1AC,28,1B0,6C");
            }
        }

        private void Borderlands2_Load(object sender, EventArgs e)
        {
            label1.Text = $"Welcome, {Environment.UserName}";
            heh = mem.Read2Byte("Borderlands2.exe+01652F54,58,1AC,B8,4,C60").ToString();
        }


        private async void guna2CheckBox3_CheckedChanged(object sender, EventArgs e)
        {
            while (guna2CheckBox3.Checked)
            {
                float money = mem.ReadFloat("Borderlands2.exe+016535F8,134,0,28,2A8,3C,2A0");
                mem.WriteMemory("Borderlands2.exe+016535F8,134,0,28,2A8,3C,2A0", "float", $"{money * 1.1}");
                await Task.Delay(100);
            }
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {

        }

        private void guna2CheckBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (guna2CheckBox2.Checked)
            {
                mem.FreezeValue("Borderlands2.exe+01652F54,58,1AC,B8,4,C60", "2bytes", $"2");
            }
            else
            {
                mem.UnfreezeValue("Borderlands2.exe+016537EC,188,9C8,1AC,28,1B0,6C");
                mem.WriteMemory("Borderlands2.exe+01652F54,58,1AC,B8,4,C60", "2bytes", $"{heh}");
            }
        }
    }
}
