using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using Atom_Optimizer_V3.Properties;
using Guna.UI2.WinForms;
using Guna.UI2.WinForms.Enums;

namespace Atom_Optimizer_V3
{
	public class game : Form
	{
		private IContainer components;

		private Label label1;

		private PictureBox pictureBox1;

		private Guna2CircleButton guna2CircleButton1;

		private Guna2CircleButton guna2CircleButton2;

		private Guna2CircleButton guna2CircleButton3;

		private Guna2CircleButton guna2CircleButton4;

		private Guna2CircleButton guna2CircleButton5;

		private Guna2CircleButton guna2CircleButton6;

		public game()
		{
			InitializeComponent();
		}

		private void pictureBox1_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		protected override void Dispose(bool disposing)
		{
			if (disposing && components != null)
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		private void InitializeComponent()
		{
            this.label1 = new System.Windows.Forms.Label();
            this.guna2CircleButton4 = new Guna.UI2.WinForms.Guna2CircleButton();
            this.guna2CircleButton5 = new Guna.UI2.WinForms.Guna2CircleButton();
            this.guna2CircleButton6 = new Guna.UI2.WinForms.Guna2CircleButton();
            this.guna2CircleButton3 = new Guna.UI2.WinForms.Guna2CircleButton();
            this.guna2CircleButton2 = new Guna.UI2.WinForms.Guna2CircleButton();
            this.guna2CircleButton1 = new Guna.UI2.WinForms.Guna2CircleButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(192, 37);
            this.label1.TabIndex = 15;
            this.label1.Text = "Game Tweaks";
            // 
            // guna2CircleButton4
            // 
            this.guna2CircleButton4.Animated = true;
            this.guna2CircleButton4.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.guna2CircleButton4.BorderThickness = 3;
            this.guna2CircleButton4.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2CircleButton4.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2CircleButton4.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2CircleButton4.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2CircleButton4.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(14)))), ((int)(((byte)(14)))));
            this.guna2CircleButton4.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold);
            this.guna2CircleButton4.ForeColor = System.Drawing.Color.White;
            this.guna2CircleButton4.ImageSize = new System.Drawing.Size(45, 45);
            this.guna2CircleButton4.Location = new System.Drawing.Point(630, 328);
            this.guna2CircleButton4.Name = "guna2CircleButton4";
            this.guna2CircleButton4.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CircleButton4.Size = new System.Drawing.Size(184, 177);
            this.guna2CircleButton4.TabIndex = 22;
            this.guna2CircleButton4.Text = "Call of Duty Black Ops 6";
            // 
            // guna2CircleButton5
            // 
            this.guna2CircleButton5.Animated = true;
            this.guna2CircleButton5.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.guna2CircleButton5.BorderThickness = 3;
            this.guna2CircleButton5.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2CircleButton5.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2CircleButton5.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2CircleButton5.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2CircleButton5.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(14)))), ((int)(((byte)(14)))));
            this.guna2CircleButton5.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold);
            this.guna2CircleButton5.ForeColor = System.Drawing.Color.White;
            this.guna2CircleButton5.ImageSize = new System.Drawing.Size(47, 47);
            this.guna2CircleButton5.Location = new System.Drawing.Point(384, 328);
            this.guna2CircleButton5.Name = "guna2CircleButton5";
            this.guna2CircleButton5.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CircleButton5.Size = new System.Drawing.Size(184, 177);
            this.guna2CircleButton5.TabIndex = 21;
            this.guna2CircleButton5.Text = "Marvel Rivals";
            // 
            // guna2CircleButton6
            // 
            this.guna2CircleButton6.Animated = true;
            this.guna2CircleButton6.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.guna2CircleButton6.BorderThickness = 3;
            this.guna2CircleButton6.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2CircleButton6.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2CircleButton6.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2CircleButton6.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2CircleButton6.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(14)))), ((int)(((byte)(14)))));
            this.guna2CircleButton6.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold);
            this.guna2CircleButton6.ForeColor = System.Drawing.Color.White;
            this.guna2CircleButton6.ImageSize = new System.Drawing.Size(45, 45);
            this.guna2CircleButton6.Location = new System.Drawing.Point(140, 328);
            this.guna2CircleButton6.Name = "guna2CircleButton6";
            this.guna2CircleButton6.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CircleButton6.Size = new System.Drawing.Size(184, 177);
            this.guna2CircleButton6.TabIndex = 20;
            this.guna2CircleButton6.Text = "Minecraft";
            // 
            // guna2CircleButton3
            // 
            this.guna2CircleButton3.Animated = true;
            this.guna2CircleButton3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.guna2CircleButton3.BorderThickness = 3;
            this.guna2CircleButton3.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2CircleButton3.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2CircleButton3.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2CircleButton3.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2CircleButton3.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(14)))), ((int)(((byte)(14)))));
            this.guna2CircleButton3.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold);
            this.guna2CircleButton3.ForeColor = System.Drawing.Color.White;
            this.guna2CircleButton3.ImageSize = new System.Drawing.Size(45, 45);
            this.guna2CircleButton3.Location = new System.Drawing.Point(630, 123);
            this.guna2CircleButton3.Name = "guna2CircleButton3";
            this.guna2CircleButton3.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CircleButton3.Size = new System.Drawing.Size(184, 177);
            this.guna2CircleButton3.TabIndex = 19;
            this.guna2CircleButton3.Text = "Fortnite";
            // 
            // guna2CircleButton2
            // 
            this.guna2CircleButton2.Animated = true;
            this.guna2CircleButton2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.guna2CircleButton2.BorderThickness = 3;
            this.guna2CircleButton2.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2CircleButton2.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2CircleButton2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2CircleButton2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2CircleButton2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(14)))), ((int)(((byte)(14)))));
            this.guna2CircleButton2.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold);
            this.guna2CircleButton2.ForeColor = System.Drawing.Color.White;
            this.guna2CircleButton2.ImageSize = new System.Drawing.Size(47, 47);
            this.guna2CircleButton2.Location = new System.Drawing.Point(384, 123);
            this.guna2CircleButton2.Name = "guna2CircleButton2";
            this.guna2CircleButton2.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CircleButton2.Size = new System.Drawing.Size(184, 177);
            this.guna2CircleButton2.TabIndex = 18;
            this.guna2CircleButton2.Text = "CS2";
            // 
            // guna2CircleButton1
            // 
            this.guna2CircleButton1.Animated = true;
            this.guna2CircleButton1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.guna2CircleButton1.BorderThickness = 3;
            this.guna2CircleButton1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2CircleButton1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2CircleButton1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2CircleButton1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2CircleButton1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(14)))), ((int)(((byte)(14)))));
            this.guna2CircleButton1.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold);
            this.guna2CircleButton1.ForeColor = System.Drawing.Color.White;
            this.guna2CircleButton1.ImageSize = new System.Drawing.Size(45, 45);
            this.guna2CircleButton1.Location = new System.Drawing.Point(140, 123);
            this.guna2CircleButton1.Name = "guna2CircleButton1";
            this.guna2CircleButton1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CircleButton1.Size = new System.Drawing.Size(184, 177);
            this.guna2CircleButton1.TabIndex = 17;
            this.guna2CircleButton1.Text = "Valorant";
            this.guna2CircleButton1.Click += new System.EventHandler(this.guna2CircleButton1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(918, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(20, 20);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(7)))), ((int)(((byte)(7)))));
            this.ClientSize = new System.Drawing.Size(950, 641);
            this.Controls.Add(this.guna2CircleButton4);
            this.Controls.Add(this.guna2CircleButton5);
            this.Controls.Add(this.guna2CircleButton6);
            this.Controls.Add(this.guna2CircleButton3);
            this.Controls.Add(this.guna2CircleButton2);
            this.Controls.Add(this.guna2CircleButton1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "game";
            this.Text = "game";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

        private void guna2CircleButton1_Click(object sender, EventArgs e)
        {

        }
    }
}
