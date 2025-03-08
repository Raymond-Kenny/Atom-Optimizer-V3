using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using Atom_Optimizer_V3.Properties;

namespace Atom_Optimizer_V3
{
	public class welcome : Form
	{
		private IContainer components;

		private PictureBox pictureBox1;

		private Label label1;

		private Label label2;

		private PictureBox pictureBox2;

		public welcome()
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Atom_Optimizer_V3.welcome));
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)this.pictureBox2).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.pictureBox1).BeginInit();
			base.SuspendLayout();
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Nirmala UI", 20.25f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
			this.label1.ForeColor = System.Drawing.SystemColors.Control;
			this.label1.Location = new System.Drawing.Point(274, 17);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(428, 37);
			this.label1.TabIndex = 18;
			this.label1.Text = "Welcome To Atom Optimizer V3";
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Nirmala UI", 12f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
			this.label2.ForeColor = System.Drawing.SystemColors.Control;
			this.label2.Location = new System.Drawing.Point(129, 177);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(698, 231);
			this.label2.TabIndex = 19;
			this.label2.Text = resources.GetString("label2.Text");
			this.pictureBox2.Image = Atom_Optimizer_V3.Properties.Resources.icons8_info_100;
			this.pictureBox2.Location = new System.Drawing.Point(94, 174);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new System.Drawing.Size(30, 30);
			this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox2.TabIndex = 20;
			this.pictureBox2.TabStop = false;
			this.pictureBox1.Image = Atom_Optimizer_V3.Properties.Resources.icons8_close_100;
			this.pictureBox1.Location = new System.Drawing.Point(918, 12);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(20, 20);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox1.TabIndex = 17;
			this.pictureBox1.TabStop = false;
			this.pictureBox1.Click += new System.EventHandler(pictureBox1_Click);
			base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(7, 7, 7);
			base.ClientSize = new System.Drawing.Size(950, 641);
			base.Controls.Add(this.pictureBox2);
			base.Controls.Add(this.label2);
			base.Controls.Add(this.label1);
			base.Controls.Add(this.pictureBox1);
			base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			base.Name = "welcome";
			this.Text = "welcome";
			((System.ComponentModel.ISupportInitialize)this.pictureBox2).EndInit();
			((System.ComponentModel.ISupportInitialize)this.pictureBox1).EndInit();
			base.ResumeLayout(false);
			base.PerformLayout();
		}
	}
}
