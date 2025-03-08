using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using Atom_Optimizer_V3.Properties;
using Guna.UI2.WinForms;

namespace Atom_Optimizer_V3
{
	public class debloat : Form
	{
		private IContainer components;

		private PictureBox pictureBox1;

		private Label label1;

		private Guna2Button guna2Button9;

		public debloat()
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
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.label1 = new System.Windows.Forms.Label();
			this.guna2Button9 = new Guna.UI2.WinForms.Guna2Button();
			((System.ComponentModel.ISupportInitialize)this.pictureBox1).BeginInit();
			base.SuspendLayout();
			this.pictureBox1.Image = Atom_Optimizer_V3.Properties.Resources.icons8_close_100;
			this.pictureBox1.Location = new System.Drawing.Point(918, 12);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(20, 20);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox1.TabIndex = 13;
			this.pictureBox1.TabStop = false;
			this.pictureBox1.Click += new System.EventHandler(pictureBox1_Click);
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Nirmala UI", 20.25f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
			this.label1.ForeColor = System.Drawing.SystemColors.Control;
			this.label1.Location = new System.Drawing.Point(12, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(120, 37);
			this.label1.TabIndex = 14;
			this.label1.Text = "Debloat";
			this.guna2Button9.Animated = true;
			this.guna2Button9.AutoRoundedCorners = true;
			this.guna2Button9.BorderColor = System.Drawing.Color.Gray;
			this.guna2Button9.BorderRadius = 31;
			this.guna2Button9.BorderThickness = 3;
			this.guna2Button9.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
			this.guna2Button9.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
			this.guna2Button9.DisabledState.FillColor = System.Drawing.Color.FromArgb(169, 169, 169);
			this.guna2Button9.DisabledState.ForeColor = System.Drawing.Color.FromArgb(141, 141, 141);
			this.guna2Button9.FillColor = System.Drawing.Color.FromArgb(14, 14, 14);
			this.guna2Button9.Font = new System.Drawing.Font("Nirmala UI", 12f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
			this.guna2Button9.ForeColor = System.Drawing.Color.White;
			this.guna2Button9.Location = new System.Drawing.Point(181, 288);
			this.guna2Button9.Name = "guna2Button9";
			this.guna2Button9.Size = new System.Drawing.Size(588, 65);
			this.guna2Button9.TabIndex = 32;
			this.guna2Button9.Text = "Remove All Bloatwares";
			base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(7, 7, 7);
			base.ClientSize = new System.Drawing.Size(950, 641);
			base.Controls.Add(this.guna2Button9);
			base.Controls.Add(this.label1);
			base.Controls.Add(this.pictureBox1);
			base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			base.Name = "debloat";
			this.Text = "debloat";
			((System.ComponentModel.ISupportInitialize)this.pictureBox1).EndInit();
			base.ResumeLayout(false);
			base.PerformLayout();
		}
	}
}
