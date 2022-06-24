namespace Valenity.Controls
{
    partial class SimpleAimTrainer
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Confirmed = new System.Windows.Forms.Label();
            this.Accuracy = new System.Windows.Forms.Label();
            this.Misses = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.guna2Separator1 = new Guna.UI2.WinForms.Guna2Separator();
            this.guna2GroupBox1 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label8 = new System.Windows.Forms.Label();
            this.Possible = new System.Windows.Forms.Label();
            this.AddTarget = new Guna.UI2.WinForms.Guna2Button();
            this.ResetMisses = new Guna.UI2.WinForms.Guna2Button();
            this.DoubleHit = new Guna.UI2.WinForms.Guna2Button();
            this.guna2GroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.ForeColor = System.Drawing.Color.Lime;
            this.label3.Location = new System.Drawing.Point(291, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(25, 23);
            this.label3.TabIndex = 3;
            this.label3.Text = "X";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semilight", 11F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(459, 323);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Hits:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semilight", 11F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(459, 373);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "Accuracy: ";
            // 
            // Confirmed
            // 
            this.Confirmed.BackColor = System.Drawing.Color.Transparent;
            this.Confirmed.Font = new System.Drawing.Font("Segoe UI Semilight", 11F);
            this.Confirmed.ForeColor = System.Drawing.Color.Red;
            this.Confirmed.Location = new System.Drawing.Point(545, 325);
            this.Confirmed.Name = "Confirmed";
            this.Confirmed.Size = new System.Drawing.Size(42, 23);
            this.Confirmed.TabIndex = 6;
            this.Confirmed.Text = "0";
            this.Confirmed.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Accuracy
            // 
            this.Accuracy.BackColor = System.Drawing.Color.Transparent;
            this.Accuracy.Font = new System.Drawing.Font("Segoe UI Semilight", 11F);
            this.Accuracy.ForeColor = System.Drawing.Color.Lime;
            this.Accuracy.Location = new System.Drawing.Point(560, 374);
            this.Accuracy.Name = "Accuracy";
            this.Accuracy.Size = new System.Drawing.Size(74, 23);
            this.Accuracy.TabIndex = 7;
            this.Accuracy.Text = "0%";
            this.Accuracy.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Misses
            // 
            this.Misses.BackColor = System.Drawing.Color.Transparent;
            this.Misses.Font = new System.Drawing.Font("Segoe UI Semilight", 11F);
            this.Misses.ForeColor = System.Drawing.Color.Lime;
            this.Misses.Location = new System.Drawing.Point(560, 351);
            this.Misses.Name = "Misses";
            this.Misses.Size = new System.Drawing.Size(74, 23);
            this.Misses.TabIndex = 9;
            this.Misses.Text = "0";
            this.Misses.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semilight", 11F);
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(459, 348);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 25);
            this.label7.TabIndex = 8;
            this.label7.Text = "Misses: ";
            // 
            // guna2Separator1
            // 
            this.guna2Separator1.BackColor = System.Drawing.Color.Transparent;
            this.guna2Separator1.Location = new System.Drawing.Point(0, 312);
            this.guna2Separator1.Name = "guna2Separator1";
            this.guna2Separator1.Size = new System.Drawing.Size(647, 10);
            this.guna2Separator1.TabIndex = 10;
            this.guna2Separator1.UseTransparentBackground = true;
            // 
            // guna2GroupBox1
            // 
            this.guna2GroupBox1.BorderThickness = 0;
            this.guna2GroupBox1.Controls.Add(this.label10);
            this.guna2GroupBox1.Controls.Add(this.label3);
            this.guna2GroupBox1.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.guna2GroupBox1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.guna2GroupBox1.Font = new System.Drawing.Font("Segoe UI Semilight", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2GroupBox1.ForeColor = System.Drawing.Color.White;
            this.guna2GroupBox1.Location = new System.Drawing.Point(0, 0);
            this.guna2GroupBox1.Name = "guna2GroupBox1";
            this.guna2GroupBox1.Size = new System.Drawing.Size(647, 276);
            this.guna2GroupBox1.TabIndex = 11;
            this.guna2GroupBox1.Text = "Simple Aim Trainer";
            this.guna2GroupBox1.Click += new System.EventHandler(this.guna2GroupBox1_Click);
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.ForeColor = System.Drawing.Color.Lime;
            this.label10.Location = new System.Drawing.Point(332, 104);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(25, 23);
            this.label10.TabIndex = 4;
            this.label10.Text = "X";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label10.Visible = false;
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Segoe UI Semilight", 11F);
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(584, 324);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(20, 23);
            this.label8.TabIndex = 12;
            this.label8.Text = "/";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Possible
            // 
            this.Possible.BackColor = System.Drawing.Color.Transparent;
            this.Possible.Font = new System.Drawing.Font("Segoe UI Semilight", 11F);
            this.Possible.ForeColor = System.Drawing.Color.Lime;
            this.Possible.Location = new System.Drawing.Point(604, 325);
            this.Possible.Name = "Possible";
            this.Possible.Size = new System.Drawing.Size(38, 23);
            this.Possible.TabIndex = 13;
            this.Possible.Text = "0";
            this.Possible.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // AddTarget
            // 
            this.AddTarget.Animated = true;
            this.AddTarget.BorderColor = System.Drawing.Color.White;
            this.AddTarget.BorderThickness = 1;
            this.AddTarget.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.AddTarget.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.AddTarget.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.AddTarget.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.AddTarget.FillColor = System.Drawing.Color.Transparent;
            this.AddTarget.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.AddTarget.ForeColor = System.Drawing.Color.White;
            this.AddTarget.Location = new System.Drawing.Point(20, 334);
            this.AddTarget.Name = "AddTarget";
            this.AddTarget.Size = new System.Drawing.Size(423, 27);
            this.AddTarget.TabIndex = 14;
            this.AddTarget.Text = "Add Another Target - 50 Hits";
            this.AddTarget.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // ResetMisses
            // 
            this.ResetMisses.Animated = true;
            this.ResetMisses.BorderColor = System.Drawing.Color.White;
            this.ResetMisses.BorderThickness = 1;
            this.ResetMisses.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.ResetMisses.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.ResetMisses.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.ResetMisses.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.ResetMisses.FillColor = System.Drawing.Color.Transparent;
            this.ResetMisses.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ResetMisses.ForeColor = System.Drawing.Color.White;
            this.ResetMisses.Location = new System.Drawing.Point(226, 364);
            this.ResetMisses.Name = "ResetMisses";
            this.ResetMisses.Size = new System.Drawing.Size(217, 27);
            this.ResetMisses.TabIndex = 15;
            this.ResetMisses.Text = "Reset Misses - 90+ Accuracy";
            this.ResetMisses.Click += new System.EventHandler(this.guna2Button2_Click);
            // 
            // DoubleHit
            // 
            this.DoubleHit.Animated = true;
            this.DoubleHit.BorderColor = System.Drawing.Color.White;
            this.DoubleHit.BorderThickness = 1;
            this.DoubleHit.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.DoubleHit.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.DoubleHit.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.DoubleHit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.DoubleHit.FillColor = System.Drawing.Color.Transparent;
            this.DoubleHit.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.DoubleHit.ForeColor = System.Drawing.Color.White;
            this.DoubleHit.Location = new System.Drawing.Point(20, 364);
            this.DoubleHit.Name = "DoubleHit";
            this.DoubleHit.Size = new System.Drawing.Size(203, 27);
            this.DoubleHit.TabIndex = 16;
            this.DoubleHit.Text = "Double Hit - 100 Hits";
            this.DoubleHit.Click += new System.EventHandler(this.guna2Button3_Click);
            // 
            // SimpleAimTrainer
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.Controls.Add(this.DoubleHit);
            this.Controls.Add(this.ResetMisses);
            this.Controls.Add(this.AddTarget);
            this.Controls.Add(this.Possible);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.guna2GroupBox1);
            this.Controls.Add(this.guna2Separator1);
            this.Controls.Add(this.Misses);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.Accuracy);
            this.Controls.Add(this.Confirmed);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI Semilight", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "SimpleAimTrainer";
            this.Size = new System.Drawing.Size(647, 400);
            this.Load += new System.EventHandler(this.SimpleAimTrainer_Load);
            this.guna2GroupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Confirmed;
        private System.Windows.Forms.Label Accuracy;
        private System.Windows.Forms.Label Misses;
        private System.Windows.Forms.Label label7;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator1;
        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label Possible;
        private System.Windows.Forms.Label label10;
        private Guna.UI2.WinForms.Guna2Button AddTarget;
        private Guna.UI2.WinForms.Guna2Button ResetMisses;
        private Guna.UI2.WinForms.Guna2Button DoubleHit;
    }
}
