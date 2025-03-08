using System;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Atom_Optimizer_V3.Properties;
using Guna.UI2.WinForms;

namespace Atom_Optimizer_V3
{
	public class Form2 : Form
	{
		private IContainer components;

		private Panel panel1;

		private PictureBox pictureBox1;

		private Guna2Button guna2Button1;

		private Guna2Button guna2Button7;

		private Guna2Button guna2Button6;

		private Guna2Button guna2Button5;

		private Guna2Button guna2Button4;

		private Guna2Button guna2Button3;

		private Guna2Button guna2Button2;

		private Guna2AnimateWindow guna2AnimateWindow1;

		private Guna2DragControl guna2DragControl1;

		private Panel mainpnl;

		[DllImport("Gdi32.dll")]
		private static extern IntPtr CreateRoundRectRgn(int nLeftRect, int nTopRect, int nRightRect, int nBottomRect, int nWidthEllipse, int nHeightEllipse);

		public Form2()
		{
			InitializeComponent();
			base.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, base.Width, base.Height, 25, 25));
			mainpnl.Controls.Clear();
			welcome welcome2 = new welcome
			{
				Dock = DockStyle.Fill,
				TopLevel = false,
				TopMost = true
			};
			welcome2.FormBorderStyle = FormBorderStyle.None;
			mainpnl.Controls.Add(welcome2);
			welcome2.Show();
		}

		private void guna2Button1_Click(object sender, EventArgs e)
		{
			mainpnl.Controls.Clear();
			general general2 = new general
			{
				Dock = DockStyle.Fill,
				TopLevel = false,
				TopMost = true
			};
			general2.FormBorderStyle = FormBorderStyle.None;
			mainpnl.Controls.Add(general2);
			general2.Show();
		}

		private void guna2Button2_Click(object sender, EventArgs e)
		{
			mainpnl.Controls.Clear();
			windows windows2 = new windows
			{
				Dock = DockStyle.Fill,
				TopLevel = false,
				TopMost = true
			};
			windows2.FormBorderStyle = FormBorderStyle.None;
			mainpnl.Controls.Add(windows2);
			windows2.Show();
		}

		private void guna2Button3_Click(object sender, EventArgs e)
		{
			mainpnl.Controls.Clear();
			cpu cpu2 = new cpu
			{
				Dock = DockStyle.Fill,
				TopLevel = false,
				TopMost = true
			};
			cpu2.FormBorderStyle = FormBorderStyle.None;
			mainpnl.Controls.Add(cpu2);
			cpu2.Show();
		}

		private void guna2Button4_Click(object sender, EventArgs e)
		{
			mainpnl.Controls.Clear();
			gpu gpu2 = new gpu
			{
				Dock = DockStyle.Fill,
				TopLevel = false,
				TopMost = true
			};
			gpu2.FormBorderStyle = FormBorderStyle.None;
			mainpnl.Controls.Add(gpu2);
			gpu2.Show();
		}

		private void guna2Button5_Click(object sender, EventArgs e)
		{
			mainpnl.Controls.Clear();
			power power2 = new power
			{
				Dock = DockStyle.Fill,
				TopLevel = false,
				TopMost = true
			};
			power2.FormBorderStyle = FormBorderStyle.None;
			mainpnl.Controls.Add(power2);
			power2.Show();
		}

		private void guna2Button6_Click(object sender, EventArgs e)
		{
			mainpnl.Controls.Clear();
			debloat debloat2 = new debloat
			{
				Dock = DockStyle.Fill,
				TopLevel = false,
				TopMost = true
			};
			debloat2.FormBorderStyle = FormBorderStyle.None;
			mainpnl.Controls.Add(debloat2);
			debloat2.Show();
		}

		private void guna2Button7_Click(object sender, EventArgs e)
		{
			mainpnl.Controls.Clear();
			game game2 = new game
			{
				Dock = DockStyle.Fill,
				TopLevel = false,
				TopMost = true
			};
			game2.FormBorderStyle = FormBorderStyle.None;
			mainpnl.Controls.Add(game2);
			game2.Show();
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
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Atom_Optimizer_V3.Form2));
			this.panel1 = new System.Windows.Forms.Panel();
			this.guna2AnimateWindow1 = new Guna.UI2.WinForms.Guna2AnimateWindow(this.components);
			this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
			this.mainpnl = new System.Windows.Forms.Panel();
			this.guna2Button7 = new Guna.UI2.WinForms.Guna2Button();
			this.guna2Button6 = new Guna.UI2.WinForms.Guna2Button();
			this.guna2Button5 = new Guna.UI2.WinForms.Guna2Button();
			this.guna2Button4 = new Guna.UI2.WinForms.Guna2Button();
			this.guna2Button3 = new Guna.UI2.WinForms.Guna2Button();
			this.guna2Button2 = new Guna.UI2.WinForms.Guna2Button();
			this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)this.pictureBox1).BeginInit();
			base.SuspendLayout();
			this.panel1.BackColor = System.Drawing.Color.FromArgb(14, 14, 14);
			this.panel1.Controls.Add(this.guna2Button7);
			this.panel1.Controls.Add(this.guna2Button6);
			this.panel1.Controls.Add(this.guna2Button5);
			this.panel1.Controls.Add(this.guna2Button4);
			this.panel1.Controls.Add(this.guna2Button3);
			this.panel1.Controls.Add(this.guna2Button2);
			this.panel1.Controls.Add(this.guna2Button1);
			this.panel1.Controls.Add(this.pictureBox1);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(106, 641);
			this.panel1.TabIndex = 0;
			this.guna2AnimateWindow1.AnimationType = Guna.UI2.WinForms.Guna2AnimateWindow.AnimateWindowType.AW_VER_POSITIVE;
			this.guna2AnimateWindow1.TargetForm = this;
			this.guna2DragControl1.DockIndicatorTransparencyValue = 0.6;
			this.guna2DragControl1.DragStartTransparencyValue = 1.0;
			this.guna2DragControl1.TargetControl = this.panel1;
			this.guna2DragControl1.UseTransparentDrag = true;
			this.mainpnl.Dock = System.Windows.Forms.DockStyle.Fill;
			this.mainpnl.Location = new System.Drawing.Point(106, 0);
			this.mainpnl.Name = "mainpnl";
			this.mainpnl.Size = new System.Drawing.Size(950, 641);
			this.mainpnl.TabIndex = 1;
			this.guna2Button7.Animated = true;
			this.guna2Button7.AutoRoundedCorners = true;
			this.guna2Button7.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
			this.guna2Button7.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
			this.guna2Button7.DisabledState.FillColor = System.Drawing.Color.FromArgb(169, 169, 169);
			this.guna2Button7.DisabledState.ForeColor = System.Drawing.Color.FromArgb(141, 141, 141);
			this.guna2Button7.FillColor = System.Drawing.Color.FromArgb(7, 7, 7);
			this.guna2Button7.Font = new System.Drawing.Font("Segoe UI", 9f);
			this.guna2Button7.ForeColor = System.Drawing.Color.White;
			this.guna2Button7.Image = Atom_Optimizer_V3.Properties.Resources.icons8_games_100__1_;
			this.guna2Button7.ImageSize = new System.Drawing.Size(25, 25);
			this.guna2Button7.Location = new System.Drawing.Point(24, 528);
			this.guna2Button7.Name = "guna2Button7";
			this.guna2Button7.Size = new System.Drawing.Size(59, 51);
			this.guna2Button7.TabIndex = 7;
			this.guna2Button7.Click += new System.EventHandler(guna2Button7_Click);
			this.guna2Button6.Animated = true;
			this.guna2Button6.AutoRoundedCorners = true;
			this.guna2Button6.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
			this.guna2Button6.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
			this.guna2Button6.DisabledState.FillColor = System.Drawing.Color.FromArgb(169, 169, 169);
			this.guna2Button6.DisabledState.ForeColor = System.Drawing.Color.FromArgb(141, 141, 141);
			this.guna2Button6.FillColor = System.Drawing.Color.FromArgb(7, 7, 7);
			this.guna2Button6.Font = new System.Drawing.Font("Segoe UI", 9f);
			this.guna2Button6.ForeColor = System.Drawing.Color.White;
			this.guna2Button6.Image = Atom_Optimizer_V3.Properties.Resources.icons8_trash_100;
			this.guna2Button6.ImageSize = new System.Drawing.Size(30, 30);
			this.guna2Button6.Location = new System.Drawing.Point(24, 458);
			this.guna2Button6.Name = "guna2Button6";
			this.guna2Button6.Size = new System.Drawing.Size(59, 51);
			this.guna2Button6.TabIndex = 6;
			this.guna2Button6.Click += new System.EventHandler(guna2Button6_Click);
			this.guna2Button5.Animated = true;
			this.guna2Button5.AutoRoundedCorners = true;
			this.guna2Button5.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
			this.guna2Button5.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
			this.guna2Button5.DisabledState.FillColor = System.Drawing.Color.FromArgb(169, 169, 169);
			this.guna2Button5.DisabledState.ForeColor = System.Drawing.Color.FromArgb(141, 141, 141);
			this.guna2Button5.FillColor = System.Drawing.Color.FromArgb(7, 7, 7);
			this.guna2Button5.Font = new System.Drawing.Font("Segoe UI", 9f);
			this.guna2Button5.ForeColor = System.Drawing.Color.White;
			this.guna2Button5.Image = Atom_Optimizer_V3.Properties.Resources.icons8_power_100;
			this.guna2Button5.ImageSize = new System.Drawing.Size(25, 25);
			this.guna2Button5.Location = new System.Drawing.Point(24, 387);
			this.guna2Button5.Name = "guna2Button5";
			this.guna2Button5.Size = new System.Drawing.Size(59, 51);
			this.guna2Button5.TabIndex = 5;
			this.guna2Button5.Click += new System.EventHandler(guna2Button5_Click);
			this.guna2Button4.Animated = true;
			this.guna2Button4.AutoRoundedCorners = true;
			this.guna2Button4.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
			this.guna2Button4.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
			this.guna2Button4.DisabledState.FillColor = System.Drawing.Color.FromArgb(169, 169, 169);
			this.guna2Button4.DisabledState.ForeColor = System.Drawing.Color.FromArgb(141, 141, 141);
			this.guna2Button4.FillColor = System.Drawing.Color.FromArgb(7, 7, 7);
			this.guna2Button4.Font = new System.Drawing.Font("Segoe UI", 9f);
			this.guna2Button4.ForeColor = System.Drawing.Color.White;
			this.guna2Button4.Image = Atom_Optimizer_V3.Properties.Resources.icons8_video_card_100;
			this.guna2Button4.ImageSize = new System.Drawing.Size(29, 29);
			this.guna2Button4.Location = new System.Drawing.Point(24, 321);
			this.guna2Button4.Name = "guna2Button4";
			this.guna2Button4.Size = new System.Drawing.Size(59, 51);
			this.guna2Button4.TabIndex = 4;
			this.guna2Button4.Click += new System.EventHandler(guna2Button4_Click);
			this.guna2Button3.Animated = true;
			this.guna2Button3.AutoRoundedCorners = true;
			this.guna2Button3.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
			this.guna2Button3.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
			this.guna2Button3.DisabledState.FillColor = System.Drawing.Color.FromArgb(169, 169, 169);
			this.guna2Button3.DisabledState.ForeColor = System.Drawing.Color.FromArgb(141, 141, 141);
			this.guna2Button3.FillColor = System.Drawing.Color.FromArgb(7, 7, 7);
			this.guna2Button3.Font = new System.Drawing.Font("Segoe UI", 9f);
			this.guna2Button3.ForeColor = System.Drawing.Color.White;
			this.guna2Button3.Image = Atom_Optimizer_V3.Properties.Resources.icons8_cpu_100;
			this.guna2Button3.ImageSize = new System.Drawing.Size(31, 31);
			this.guna2Button3.Location = new System.Drawing.Point(24, 250);
			this.guna2Button3.Name = "guna2Button3";
			this.guna2Button3.Size = new System.Drawing.Size(59, 51);
			this.guna2Button3.TabIndex = 3;
			this.guna2Button3.Click += new System.EventHandler(guna2Button3_Click);
			this.guna2Button2.Animated = true;
			this.guna2Button2.AutoRoundedCorners = true;
			this.guna2Button2.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
			this.guna2Button2.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
			this.guna2Button2.DisabledState.FillColor = System.Drawing.Color.FromArgb(169, 169, 169);
			this.guna2Button2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(141, 141, 141);
			this.guna2Button2.FillColor = System.Drawing.Color.FromArgb(7, 7, 7);
			this.guna2Button2.Font = new System.Drawing.Font("Segoe UI", 9f);
			this.guna2Button2.ForeColor = System.Drawing.Color.White;
			this.guna2Button2.Image = Atom_Optimizer_V3.Properties.Resources.icons8_windows_100;
			this.guna2Button2.ImageSize = new System.Drawing.Size(25, 25);
			this.guna2Button2.Location = new System.Drawing.Point(24, 182);
			this.guna2Button2.Name = "guna2Button2";
			this.guna2Button2.Size = new System.Drawing.Size(59, 51);
			this.guna2Button2.TabIndex = 2;
			this.guna2Button2.Click += new System.EventHandler(guna2Button2_Click);
			this.guna2Button1.Animated = true;
			this.guna2Button1.AutoRoundedCorners = true;
			this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
			this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
			this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(169, 169, 169);
			this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(141, 141, 141);
			this.guna2Button1.FillColor = System.Drawing.Color.FromArgb(7, 7, 7);
			this.guna2Button1.Font = new System.Drawing.Font("Segoe UI", 9f);
			this.guna2Button1.ForeColor = System.Drawing.Color.White;
			this.guna2Button1.Image = Atom_Optimizer_V3.Properties.Resources.icons8_settings_1001;
			this.guna2Button1.ImageSize = new System.Drawing.Size(25, 25);
			this.guna2Button1.Location = new System.Drawing.Point(24, 113);
			this.guna2Button1.Name = "guna2Button1";
			this.guna2Button1.Size = new System.Drawing.Size(59, 51);
			this.guna2Button1.TabIndex = 1;
			this.guna2Button1.Click += new System.EventHandler(guna2Button1_Click);
			this.pictureBox1.Image = Atom_Optimizer_V3.Properties.Resources.logo;
			this.pictureBox1.Location = new System.Drawing.Point(0, 17);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(106, 50);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox1.TabIndex = 0;
			this.pictureBox1.TabStop = false;
			base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(7, 7, 7);
			base.ClientSize = new System.Drawing.Size(1056, 641);
			base.Controls.Add(this.mainpnl);
			base.Controls.Add(this.panel1);
			base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			base.Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
			base.Name = "Form2";
			base.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Atom Optimizer V3";
			this.panel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)this.pictureBox1).EndInit();
			base.ResumeLayout(false);
		}
	}
}
