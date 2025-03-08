using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using Atom_Optimizer_V3.Properties;
using Guna.UI2.WinForms;

namespace Atom_Optimizer_V3
{
	public class general : Form
	{
		private IContainer components;

		private Label label1;

		private PictureBox pictureBox1;

		private Guna2Button guna2Button1;

		private Guna2Button guna2Button2;

		private Guna2Button guna2Button3;

		private Guna2Button guna2Button4;

		private Guna2Button guna2Button5;

		private Guna2Button guna2Button6;

		private Guna2Button guna2Button7;

		private Guna2Button guna2Button8;

		private Guna2Button guna2Button9;

		private Guna2Button guna2Button10;

		private Guna2Button guna2Button11;

		private Guna2Button guna2Button12;

		private Guna2Button guna2Button13;

		private Guna2Button guna2Button14;

		private Guna2Button guna2Button15;

		public general()
		{
			InitializeComponent();
		}

		private void pictureBox1_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		private void guna2Button2_Click(object sender, EventArgs e)
		{
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button2 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button3 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button4 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button5 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button6 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button7 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button8 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button9 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button10 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button11 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button12 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button13 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button14 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button15 = new Guna.UI2.WinForms.Guna2Button();
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
            this.label1.Size = new System.Drawing.Size(217, 37);
            this.label1.TabIndex = 5;
            this.label1.Text = "General Tweaks";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(918, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(20, 20);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // guna2Button1
            // 
            this.guna2Button1.Animated = true;
            this.guna2Button1.AutoRoundedCorners = true;
            this.guna2Button1.BorderColor = System.Drawing.Color.Gray;
            this.guna2Button1.BorderRadius = 31;
            this.guna2Button1.BorderThickness = 3;
            this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(14)))), ((int)(((byte)(14)))));
            this.guna2Button1.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.Location = new System.Drawing.Point(25, 111);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.Size = new System.Drawing.Size(280, 65);
            this.guna2Button1.TabIndex = 7;
            this.guna2Button1.Text = "System Resource Optimization";
            // 
            // guna2Button2
            // 
            this.guna2Button2.Animated = true;
            this.guna2Button2.AutoRoundedCorners = true;
            this.guna2Button2.BorderColor = System.Drawing.Color.Gray;
            this.guna2Button2.BorderRadius = 31;
            this.guna2Button2.BorderThickness = 3;
            this.guna2Button2.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button2.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(14)))), ((int)(((byte)(14)))));
            this.guna2Button2.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button2.ForeColor = System.Drawing.Color.White;
            this.guna2Button2.Location = new System.Drawing.Point(642, 111);
            this.guna2Button2.Name = "guna2Button2";
            this.guna2Button2.Size = new System.Drawing.Size(280, 65);
            this.guna2Button2.TabIndex = 8;
            this.guna2Button2.Text = "Disable Background Apps";
            this.guna2Button2.Click += new System.EventHandler(this.guna2Button2_Click);
            // 
            // guna2Button3
            // 
            this.guna2Button3.Animated = true;
            this.guna2Button3.AutoRoundedCorners = true;
            this.guna2Button3.BorderColor = System.Drawing.Color.Gray;
            this.guna2Button3.BorderRadius = 31;
            this.guna2Button3.BorderThickness = 3;
            this.guna2Button3.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button3.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button3.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button3.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button3.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(14)))), ((int)(((byte)(14)))));
            this.guna2Button3.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button3.ForeColor = System.Drawing.Color.White;
            this.guna2Button3.Location = new System.Drawing.Point(333, 111);
            this.guna2Button3.Name = "guna2Button3";
            this.guna2Button3.Size = new System.Drawing.Size(280, 65);
            this.guna2Button3.TabIndex = 8;
            this.guna2Button3.Text = "Disable Automatic Updates";
            this.guna2Button3.Click += new System.EventHandler(this.guna2Button3_Click);
            // 
            // guna2Button4
            // 
            this.guna2Button4.Animated = true;
            this.guna2Button4.AutoRoundedCorners = true;
            this.guna2Button4.BorderColor = System.Drawing.Color.Gray;
            this.guna2Button4.BorderRadius = 31;
            this.guna2Button4.BorderThickness = 3;
            this.guna2Button4.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button4.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button4.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button4.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button4.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(14)))), ((int)(((byte)(14)))));
            this.guna2Button4.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button4.ForeColor = System.Drawing.Color.White;
            this.guna2Button4.Location = new System.Drawing.Point(333, 212);
            this.guna2Button4.Name = "guna2Button4";
            this.guna2Button4.Size = new System.Drawing.Size(280, 65);
            this.guna2Button4.TabIndex = 11;
            this.guna2Button4.Text = "Disable Hibernation Mode";
            // 
            // guna2Button5
            // 
            this.guna2Button5.Animated = true;
            this.guna2Button5.AutoRoundedCorners = true;
            this.guna2Button5.BorderColor = System.Drawing.Color.Gray;
            this.guna2Button5.BorderRadius = 31;
            this.guna2Button5.BorderThickness = 3;
            this.guna2Button5.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button5.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button5.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button5.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button5.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(14)))), ((int)(((byte)(14)))));
            this.guna2Button5.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button5.ForeColor = System.Drawing.Color.White;
            this.guna2Button5.Location = new System.Drawing.Point(642, 212);
            this.guna2Button5.Name = "guna2Button5";
            this.guna2Button5.Size = new System.Drawing.Size(280, 65);
            this.guna2Button5.TabIndex = 10;
            this.guna2Button5.Text = "Disable Fullscreen Optimizations ";
            // 
            // guna2Button6
            // 
            this.guna2Button6.Animated = true;
            this.guna2Button6.AutoRoundedCorners = true;
            this.guna2Button6.BorderColor = System.Drawing.Color.Gray;
            this.guna2Button6.BorderRadius = 31;
            this.guna2Button6.BorderThickness = 3;
            this.guna2Button6.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button6.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button6.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button6.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button6.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(14)))), ((int)(((byte)(14)))));
            this.guna2Button6.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button6.ForeColor = System.Drawing.Color.White;
            this.guna2Button6.Location = new System.Drawing.Point(25, 212);
            this.guna2Button6.Name = "guna2Button6";
            this.guna2Button6.Size = new System.Drawing.Size(280, 65);
            this.guna2Button6.TabIndex = 9;
            this.guna2Button6.Text = "Disable Windows Search Indexing\n";
            // 
            // guna2Button7
            // 
            this.guna2Button7.Animated = true;
            this.guna2Button7.AutoRoundedCorners = true;
            this.guna2Button7.BorderColor = System.Drawing.Color.Gray;
            this.guna2Button7.BorderRadius = 31;
            this.guna2Button7.BorderThickness = 3;
            this.guna2Button7.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button7.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button7.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button7.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button7.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(14)))), ((int)(((byte)(14)))));
            this.guna2Button7.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button7.ForeColor = System.Drawing.Color.White;
            this.guna2Button7.Location = new System.Drawing.Point(333, 311);
            this.guna2Button7.Name = "guna2Button7";
            this.guna2Button7.Size = new System.Drawing.Size(280, 65);
            this.guna2Button7.TabIndex = 14;
            this.guna2Button7.Text = "Disable Microsoft Store";
            // 
            // guna2Button8
            // 
            this.guna2Button8.Animated = true;
            this.guna2Button8.AutoRoundedCorners = true;
            this.guna2Button8.BorderColor = System.Drawing.Color.Gray;
            this.guna2Button8.BorderRadius = 31;
            this.guna2Button8.BorderThickness = 3;
            this.guna2Button8.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button8.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button8.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button8.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button8.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(14)))), ((int)(((byte)(14)))));
            this.guna2Button8.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button8.ForeColor = System.Drawing.Color.White;
            this.guna2Button8.Location = new System.Drawing.Point(642, 311);
            this.guna2Button8.Name = "guna2Button8";
            this.guna2Button8.Size = new System.Drawing.Size(280, 65);
            this.guna2Button8.TabIndex = 13;
            this.guna2Button8.Text = "Disable Notifications";
            // 
            // guna2Button9
            // 
            this.guna2Button9.Animated = true;
            this.guna2Button9.AutoRoundedCorners = true;
            this.guna2Button9.BorderColor = System.Drawing.Color.Gray;
            this.guna2Button9.BorderRadius = 31;
            this.guna2Button9.BorderThickness = 3;
            this.guna2Button9.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button9.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button9.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button9.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button9.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(14)))), ((int)(((byte)(14)))));
            this.guna2Button9.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button9.ForeColor = System.Drawing.Color.White;
            this.guna2Button9.Location = new System.Drawing.Point(25, 311);
            this.guna2Button9.Name = "guna2Button9";
            this.guna2Button9.Size = new System.Drawing.Size(280, 65);
            this.guna2Button9.TabIndex = 12;
            this.guna2Button9.Text = "Disable Windows Defender\n";
            // 
            // guna2Button10
            // 
            this.guna2Button10.Animated = true;
            this.guna2Button10.AutoRoundedCorners = true;
            this.guna2Button10.BorderColor = System.Drawing.Color.Gray;
            this.guna2Button10.BorderRadius = 31;
            this.guna2Button10.BorderThickness = 3;
            this.guna2Button10.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button10.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button10.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button10.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button10.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(14)))), ((int)(((byte)(14)))));
            this.guna2Button10.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button10.ForeColor = System.Drawing.Color.White;
            this.guna2Button10.Location = new System.Drawing.Point(333, 409);
            this.guna2Button10.Name = "guna2Button10";
            this.guna2Button10.Size = new System.Drawing.Size(280, 65);
            this.guna2Button10.TabIndex = 17;
            this.guna2Button10.Text = "Clear Cache";
            // 
            // guna2Button11
            // 
            this.guna2Button11.Animated = true;
            this.guna2Button11.AutoRoundedCorners = true;
            this.guna2Button11.BorderColor = System.Drawing.Color.Gray;
            this.guna2Button11.BorderRadius = 31;
            this.guna2Button11.BorderThickness = 3;
            this.guna2Button11.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button11.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button11.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button11.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button11.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(14)))), ((int)(((byte)(14)))));
            this.guna2Button11.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button11.ForeColor = System.Drawing.Color.White;
            this.guna2Button11.Location = new System.Drawing.Point(642, 409);
            this.guna2Button11.Name = "guna2Button11";
            this.guna2Button11.Size = new System.Drawing.Size(280, 65);
            this.guna2Button11.TabIndex = 16;
            this.guna2Button11.Text = "Disable Superfetch and Prefetch";
            // 
            // guna2Button12
            // 
            this.guna2Button12.Animated = true;
            this.guna2Button12.AutoRoundedCorners = true;
            this.guna2Button12.BorderColor = System.Drawing.Color.Gray;
            this.guna2Button12.BorderRadius = 31;
            this.guna2Button12.BorderThickness = 3;
            this.guna2Button12.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button12.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button12.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button12.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button12.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(14)))), ((int)(((byte)(14)))));
            this.guna2Button12.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button12.ForeColor = System.Drawing.Color.White;
            this.guna2Button12.Location = new System.Drawing.Point(25, 409);
            this.guna2Button12.Name = "guna2Button12";
            this.guna2Button12.Size = new System.Drawing.Size(280, 65);
            this.guna2Button12.TabIndex = 15;
            this.guna2Button12.Text = "Win32 Priority Separation";
            // 
            // guna2Button13
            // 
            this.guna2Button13.Animated = true;
            this.guna2Button13.AutoRoundedCorners = true;
            this.guna2Button13.BorderColor = System.Drawing.Color.Gray;
            this.guna2Button13.BorderRadius = 31;
            this.guna2Button13.BorderThickness = 3;
            this.guna2Button13.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button13.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button13.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button13.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button13.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(14)))), ((int)(((byte)(14)))));
            this.guna2Button13.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button13.ForeColor = System.Drawing.Color.White;
            this.guna2Button13.Location = new System.Drawing.Point(333, 507);
            this.guna2Button13.Name = "guna2Button13";
            this.guna2Button13.Size = new System.Drawing.Size(280, 65);
            this.guna2Button13.TabIndex = 20;
            this.guna2Button13.Text = "USB Optimizations";
            // 
            // guna2Button14
            // 
            this.guna2Button14.Animated = true;
            this.guna2Button14.AutoRoundedCorners = true;
            this.guna2Button14.BorderColor = System.Drawing.Color.Gray;
            this.guna2Button14.BorderRadius = 31;
            this.guna2Button14.BorderThickness = 3;
            this.guna2Button14.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button14.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button14.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button14.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button14.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(14)))), ((int)(((byte)(14)))));
            this.guna2Button14.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button14.ForeColor = System.Drawing.Color.White;
            this.guna2Button14.Location = new System.Drawing.Point(642, 507);
            this.guna2Button14.Name = "guna2Button14";
            this.guna2Button14.Size = new System.Drawing.Size(280, 65);
            this.guna2Button14.TabIndex = 19;
            this.guna2Button14.Text = "DirectX Tweaks";
            // 
            // guna2Button15
            // 
            this.guna2Button15.Animated = true;
            this.guna2Button15.AutoRoundedCorners = true;
            this.guna2Button15.BorderColor = System.Drawing.Color.Gray;
            this.guna2Button15.BorderRadius = 31;
            this.guna2Button15.BorderThickness = 3;
            this.guna2Button15.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button15.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button15.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button15.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button15.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(14)))), ((int)(((byte)(14)))));
            this.guna2Button15.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button15.ForeColor = System.Drawing.Color.White;
            this.guna2Button15.Location = new System.Drawing.Point(25, 507);
            this.guna2Button15.Name = "guna2Button15";
            this.guna2Button15.Size = new System.Drawing.Size(280, 65);
            this.guna2Button15.TabIndex = 18;
            this.guna2Button15.Text = "Explorer Tweaks";
            // 
            // general
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(7)))), ((int)(((byte)(7)))));
            this.ClientSize = new System.Drawing.Size(950, 641);
            this.Controls.Add(this.guna2Button13);
            this.Controls.Add(this.guna2Button14);
            this.Controls.Add(this.guna2Button15);
            this.Controls.Add(this.guna2Button10);
            this.Controls.Add(this.guna2Button11);
            this.Controls.Add(this.guna2Button12);
            this.Controls.Add(this.guna2Button7);
            this.Controls.Add(this.guna2Button8);
            this.Controls.Add(this.guna2Button9);
            this.Controls.Add(this.guna2Button4);
            this.Controls.Add(this.guna2Button5);
            this.Controls.Add(this.guna2Button6);
            this.Controls.Add(this.guna2Button3);
            this.Controls.Add(this.guna2Button2);
            this.Controls.Add(this.guna2Button1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "general";
            this.Text = "general";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

        private void guna2Button3_Click(object sender, EventArgs e)
        {

        }
    }
}
