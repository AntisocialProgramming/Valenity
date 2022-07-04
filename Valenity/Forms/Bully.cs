using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using JRPC_Client;
using XDevkit;

namespace Valenity.Forms
{
    public partial class Bully : Form
    {
        public static IXboxConsole Anti;
        Guna.UI2.WinForms.Guna2MessageDialog msg = new Guna.UI2.WinForms.Guna2MessageDialog();

        public Bully()
        {
            InitializeComponent();
            msg.Text = "There was an error, please connect/reconnect!";
            msg.Icon = Guna.UI2.WinForms.MessageDialogIcon.Error;
            msg.Buttons = Guna.UI2.WinForms.MessageDialogButtons.OK;
            msg.Caption = "Oopsie Poopsie!";
            msg.Style = Guna.UI2.WinForms.MessageDialogStyle.Dark;
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            try
            {
                uint ticket;
                ticket = Anti.ReadUInt32(0xC226636C);
                if (ticket == 0)
                {
                    Anti.WriteUInt32(0xC226636C, 1);
                }
                Anti.WriteUInt32(0xC226636C, Anti.ReadUInt32(0xC226636C) * 2);
            }
            catch (Exception ex)
            {
                msg.Show();
                guna2Button9.BorderColor = Color.Red;
                guna2Button9.Text = "Please Connect!";
            }
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            try
            {
                Anti.WriteUInt32(0xC2266370, 1);
            }
            catch (Exception ex)
            {
                msg.Show();
                guna2Button9.BorderColor = Color.Red;
                guna2Button9.Text = "Please Connect!";
            }
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            try
            {
                Anti.WriteUInt32(0xC2266374, 4);
            }
            catch (Exception ex)
            {
                msg.Show();
                guna2Button9.BorderColor = Color.Red;
                guna2Button9.Text = "Please Connect!";
            }
        }

        private async void guna2Button5_Click(object sender, EventArgs e)
        {
            try
            {
                Anti.WriteUInt32(0xC22663D4, 0);
                Anti.WriteUInt32(0xC22663DC, 0);
                Anti.WriteUInt32(0xC22663A0, 0);
                Anti.WriteUInt32(0xC226639C, 0);
                Anti.WriteUInt32(0xC2266358, 0);
                Anti.WriteUInt32(0xC22663A4, 0);
                Anti.WriteUInt32(0xC2266394, 0);
                Anti.WriteUInt32(0xC226637C, 0);
                Anti.WriteUInt32(0xC2266390, 0);
                Anti.WriteUInt32(0xC2266364, 0);
                Anti.WriteUInt32(0xC2266360, 0);
                Anti.WriteUInt32(0xC226635C, 0);
                Anti.WriteUInt32(0xC2266364, 0);
                Anti.WriteUInt32(0xC2266350, 0);
                Anti.WriteUInt32(0xC226634C, 0);
                Anti.WriteUInt32(0xC226636C, 0);
                Anti.WriteUInt32(0xC2266370, 0);
                Anti.WriteUInt32(0xC2266374, 0);
                Anti.WriteUInt32(0xC226632C, 0);
                Anti.WriteUInt32(0xC2266340, 0);
                Anti.WriteUInt32(0xC226633C, 0);
                Anti.WriteUInt32(0xC2266368, 0);
                Anti.WriteUInt32(0xC2266324, 0);
                Anti.WriteUInt32(0xC2266330, 0);
                Anti.WriteUInt32(0xC2266348, 0);
                Anti.WriteUInt32(0xC2266378, 0);
                Anti.WriteUInt32(0xC22663E0, 0);
                Anti.WriteUInt32(0xC22663BC, 0);
            }
            catch (Exception ex)
            {
                msg.Show();
                guna2Button9.BorderColor = Color.Red;
                guna2Button9.Text = "Please Connect!";
            }
        }

        private void guna2Button8_Click(object sender, EventArgs e)
        {
            try
            {
                uint flowers;
                flowers = Anti.ReadUInt32(0xC226631C);
                Anti.WriteUInt32(0xC226631C, flowers + 1);
            }
            catch (Exception ex)
            {
                msg.Show();
                guna2Button9.BorderColor = Color.Red;
                guna2Button9.Text = "Please Connect!";
            }
        }

        private void guna2Button9_Click(object sender, EventArgs e)
        {
            Anti.Connect(out Anti);
            guna2Button9.BorderColor = Color.Green;
            guna2Button9.Text = "Successfully Connected!";
        }

        private void guna2Button10_Click(object sender, EventArgs e)
        {
            try
            {
                Anti.WriteUInt32(0xC226632C, 1);
            }
            catch (Exception ex)
            {
                msg.Show();
                guna2Button9.BorderColor = Color.Red;
                guna2Button9.Text = "Please Connect!";
            }
        }

        private void Bully_Load(object sender, EventArgs e)
        {

        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            try
            {
                Anti.WriteUInt32(0xC226633C, 1);
                Anti.WriteUInt32(0xC2266348, 1);
            }
            catch (Exception ex)
            {
                msg.Show();
                guna2Button9.BorderColor = Color.Red;
                guna2Button9.Text = "Please Connect!";
            }
        }

        private void guna2Button6_Click(object sender, EventArgs e)
        {
            try
            {
                Anti.WriteUInt32(0xC2266340, 5);
            }
            catch (Exception ex)
            {
                msg.Show();
                guna2Button9.BorderColor = Color.Red;
                guna2Button9.Text = "Please Connect!";
            }
        }

        private void guna2Button7_Click(object sender, EventArgs e)
        {
            try
            {
                Anti.WriteUInt32(0xC226636C, 1);
            }
            catch (Exception ex)
            {
                msg.Show();
                guna2Button9.BorderColor = Color.Red;
                guna2Button9.Text = "Please Connect!";
            }
        }

        private void guna2Button11_Click(object sender, EventArgs e)
        {
            try
            {
                Anti.WriteUInt32(0xC2266368, 1);
            }
            catch (Exception ex)
            {
                msg.Show();
                guna2Button9.BorderColor = Color.Red;
                guna2Button9.Text = "Please Connect!";
            }
        }

        private void guna2Button12_Click(object sender, EventArgs e)
        {
            try
            {
                Anti.WriteUInt32(0xC2266324, 10);
            }
            catch (Exception ex)
            {
                msg.Show();
                guna2Button9.BorderColor = Color.Red;
                guna2Button9.Text = "Please Connect!";
            }
        }

        private void guna2Button13_Click(object sender, EventArgs e)
        {
            try
            {
                Anti.WriteUInt32(0xC2266330, 1);
            }
            catch (Exception ex)
            {
                msg.Show();
                guna2Button9.BorderColor = Color.Red;
                guna2Button9.Text = "Please Connect!";
            }
        }

        private void guna2Button14_Click(object sender, EventArgs e)
        {
            try
            {
                Anti.WriteUInt32(0xC226634C, 1);
            }
            catch (Exception ex)
            {
                msg.Show();
                guna2Button9.BorderColor = Color.Red;
                guna2Button9.Text = "Please Connect!";
            }
        }

        private void guna2Button15_Click(object sender, EventArgs e)
        {
            try
            {
                Anti.WriteUInt32(0xC2266350, 1);
            }
            catch (Exception ex)
            {
                msg.Show();
                guna2Button9.BorderColor = Color.Red;
                guna2Button9.Text = "Please Connect!";
            }
        }

        private void guna2Button16_Click(object sender, EventArgs e)
        {
            try
            {
                Anti.WriteUInt32(0xC2266358, 1);
            }
            catch (Exception ex)
            {
                msg.Show();
                guna2Button9.BorderColor = Color.Red;
                guna2Button9.Text = "Please Connect!";
            }
        }

        private void guna2Button17_Click(object sender, EventArgs e)
        {
            try
            {
                Anti.WriteUInt32(0xC226635C, 1);
            }
            catch (Exception ex)
            {
                msg.Show();
                guna2Button9.BorderColor = Color.Red;
                guna2Button9.Text = "Please Connect!";
            }
        }

        private void guna2Button18_Click(object sender, EventArgs e)
        {
            try
            {
                Anti.WriteUInt32(0xC2266360, 1);
            }
            catch (Exception ex)
            {
                msg.Show();
                guna2Button9.BorderColor = Color.Red;
                guna2Button9.Text = "Please Connect!";
            }
        }

        private void guna2Button19_Click(object sender, EventArgs e)
        {
            try
            {
                Anti.WriteUInt32(0xC2266364, 1);
            }
            catch (Exception ex)
            {
                msg.Show();
                guna2Button9.BorderColor = Color.Red;
                guna2Button9.Text = "Please Connect!";
            }
        }

        private void guna2Button20_Click(object sender, EventArgs e)
        {
            try
            {
                Anti.WriteUInt32(0xC2266378, 1);
            }
            catch (Exception ex)
            {
                msg.Show();
                guna2Button9.BorderColor = Color.Red;
                guna2Button9.Text = "Please Connect!";
            }
        }

        private void guna2Button21_Click(object sender, EventArgs e)
        {
            try
            {
                Anti.WriteUInt32(0xC226637C, 1);
            }
            catch (Exception ex)
            {
                msg.Show();
                guna2Button9.BorderColor = Color.Red;
                guna2Button9.Text = "Please Connect!";
            }
        }

        private void guna2Button22_Click(object sender, EventArgs e)
        {
            try
            {
                Anti.WriteUInt32(0xC2266390, 1);
            }
            catch (Exception ex)
            {
                msg.Show();
                guna2Button9.BorderColor = Color.Red;
                guna2Button9.Text = "Please Connect!";
            }
        }

        private void guna2Button23_Click(object sender, EventArgs e)
        {
            try
            {
                Anti.WriteUInt32(0xC2266394, 1);
            }
            catch (Exception ex)
            {
                msg.Show();
                guna2Button9.BorderColor = Color.Red;
                guna2Button9.Text = "Please Connect!";
            }
        }

        private void guna2Button24_Click(object sender, EventArgs e)
        {
            try
            {
                Anti.WriteUInt32(0xC226639C, 1);
            }
            catch (Exception ex)
            {
                msg.Show();
                guna2Button9.BorderColor = Color.Red;
                guna2Button9.Text = "Please Connect!";
            }
        }

        private void guna2Button25_Click(object sender, EventArgs e)
        {
            try
            {
                Anti.WriteUInt32(0xC22663A0, 1);
            }
            catch (Exception ex)
            {
                msg.Show();
                guna2Button9.BorderColor = Color.Red;
                guna2Button9.Text = "Please Connect!";
            }
        }

        private void guna2Button26_Click(object sender, EventArgs e)
        {
            try
            {
                Anti.WriteUInt32(0xC22663A4, 1);
            }
            catch (Exception ex)
            {
                msg.Show();
                guna2Button9.BorderColor = Color.Red;
                guna2Button9.Text = "Please Connect!";
            }
        }

        private void guna2Button27_Click(object sender, EventArgs e)
        {
            try
            {
                Anti.WriteUInt32(0xC22663BC, 1);
            }
            catch (Exception ex)
            {
                msg.Show();
                guna2Button9.BorderColor = Color.Red;
                guna2Button9.Text = "Please Connect!";
            }

        }

        private void guna2Button28_Click(object sender, EventArgs e)
        {
            try
            {
                Anti.WriteUInt32(0xC22663D4, 1);
            }
            catch (Exception ex)
            {
                msg.Show();
                guna2Button9.BorderColor = Color.Red;
                guna2Button9.Text = "Please Connect!";
            }
        }

        private void guna2Button29_Click(object sender, EventArgs e)
        {
            try
            {
                Anti.WriteUInt32(0xC22663DC, 6);
            }
            catch (Exception ex)
            {
                msg.Show();
                guna2Button9.BorderColor = Color.Red;
                guna2Button9.Text = "Please Connect!";
            }
        }

        private void guna2Button30_Click(object sender, EventArgs e)
        {
            try
            {
                Anti.WriteUInt32(0xC22663E0, 1);
            }
            catch (Exception ex)
            {
                msg.Show();
                guna2Button9.BorderColor = Color.Red;
                guna2Button9.Text = "Please Connect!";
            }
        }

        private void guna2Button31_Click(object sender, EventArgs e)
        {
            
        }

        private void guna2Button32_Click(object sender, EventArgs e)
        {
            try
            {
                Anti.WriteUInt32(0xC22663E4, 1);
            }
            catch (Exception ex)
            {
                msg.Show();
                guna2Button9.BorderColor = Color.Red;
                guna2Button9.Text = "Please Connect!";
            }
        }

        private void guna2Button31_Click_1(object sender, EventArgs e)
        {
            try
            {
                Anti.WriteUInt32(0xC22663E8, 1);
            }
            catch (Exception ex)
            {
                msg.Show();
                guna2Button9.BorderColor = Color.Red;
                guna2Button9.Text = "Please Connect!";
            }   
        }

        private void guna2Button33_Click(object sender, EventArgs e)
        {
            try
            {
                Anti.WriteUInt32(0xC22663F3, 1);
            }
            catch (Exception ex)
            {
                msg.Show();
                guna2Button9.BorderColor = Color.Red;
                guna2Button9.Text = "Please Connect!";
            }
        }

        private void guna2Button34_Click(object sender, EventArgs e)
        {
            try
            {
                Anti.WriteUInt32(0xC2319200, Convert.ToUInt32(MainGreeting.Value));
            }
            catch (Exception ex)
            {
                msg.Show();
                guna2Button9.BorderColor = Color.Red;
                guna2Button9.Text = "Please Connect!";
            }
        }

        private void guna2Button35_Click(object sender, EventArgs e)
        {
            try
            {
                Anti.WriteUInt32(0xC231907C, Convert.ToUInt32(guna2NumericUpDown1.Value));
            }
            catch (Exception ex)
            {
                msg.Show();
                guna2Button9.BorderColor = Color.Red;
                guna2Button9.Text = "Please Connect!";
            }
        }

        private void guna2Button36_Click(object sender, EventArgs e)
        {
            try
            {
                Anti.WriteUInt32(0xC2319080, Convert.ToUInt32(guna2NumericUpDown2.Value));
            }
            catch (Exception ex)
            {
                msg.Show();
                guna2Button9.BorderColor = Color.Red;
                guna2Button9.Text = "Please Connect!";
            }
        }

        private void guna2Button37_Click(object sender, EventArgs e)
        {
            try
            {
                Anti.WriteUInt32(0xC2319084, Convert.ToUInt32(guna2NumericUpDown3.Value));
            }
            catch (Exception ex)
            {
                msg.Show();
                guna2Button9.BorderColor = Color.Red;
                guna2Button9.Text = "Please Connect!";
            }
        }

        private void guna2Button38_Click(object sender, EventArgs e)
        {
            try
            {
                Anti.WriteUInt32(0xC2319088, Convert.ToUInt32(guna2NumericUpDown4.Value));
            }
            catch (Exception ex)
            {
                msg.Show();
                guna2Button9.BorderColor = Color.Red;
                guna2Button9.Text = "Please Connect!";
            }
        }

        private void guna2Button40_Click(object sender, EventArgs e)
        {
            try
            {
                Anti.WriteUInt32(0xC231908C, Convert.ToUInt32(guna2NumericUpDown6.Value));
            }
            catch (Exception ex)
            {
                msg.Show();
                guna2Button9.BorderColor = Color.Red;
                guna2Button9.Text = "Please Connect!";
            }
        }

        private void guna2Button39_Click(object sender, EventArgs e)
        {
            try
            {
                Anti.WriteUInt32(0xC2319090, Convert.ToUInt32(guna2NumericUpDown5.Value));
            }
            catch (Exception ex)
            {
                msg.Show();
                guna2Button9.BorderColor = Color.Red;
                guna2Button9.Text = "Please Connect!";
            }
        }

        private void guna2Button41_Click(object sender, EventArgs e)
        {
            try
            {
                Anti.WriteUInt32(0xC2319204, Convert.ToUInt32(guna2NumericUpDown7.Value));
            }
            catch (Exception ex)
            {
                msg.Show();
                guna2Button9.BorderColor = Color.Red;
                guna2Button9.Text = "Please Connect!";
            }
        }

        private void guna2Button42_Click(object sender, EventArgs e)
        {
            try
            {
                Anti.WriteUInt32(0xC2319208, Convert.ToUInt32(guna2NumericUpDown8.Value));
            }
            catch (Exception ex)
            {
                msg.Show();
                guna2Button9.BorderColor = Color.Red;
                guna2Button9.Text = "Please Connect!";
            }
        }

        private void guna2Button43_Click(object sender, EventArgs e)
        {
            try
            {
                Anti.WriteUInt32(0xC2319210, Convert.ToUInt32(guna2NumericUpDown9.Value));
            }
            catch (Exception ex)
            {
                msg.Show();
                guna2Button9.BorderColor = Color.Red;
                guna2Button9.Text = "Please Connect!";
            }
        }
    }
}
