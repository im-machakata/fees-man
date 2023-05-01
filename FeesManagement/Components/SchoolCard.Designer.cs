/*
 * Created by SharpDevelop.
 * User: Caasi
 * Date: 5/1/2023
 * Time: 7:25 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace FeesManagement.Components
{
	partial class SchoolCard
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the control.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SchoolCard));
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.Name = new System.Windows.Forms.Label();
			this.panel1 = new System.Windows.Forms.Panel();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(35, 20);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(83, 66);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 0;
			this.pictureBox1.TabStop = false;
			// 
			// Name
			// 
			this.Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Name.Location = new System.Drawing.Point(3, 74);
			this.Name.Name = "Name";
			this.Name.Size = new System.Drawing.Size(147, 103);
			this.Name.TabIndex = 1;
			this.Name.Text = "School Name";
			this.Name.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.White;
			this.panel1.Controls.Add(this.pictureBox1);
			this.panel1.Controls.Add(this.Name);
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(153, 177);
			this.panel1.TabIndex = 2;
			// 
			// SchoolCard
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.panel1);
			this.Location = new System.Drawing.Point(6, 0);
			this.Name = "SchoolCard";
			this.Size = new System.Drawing.Size(154, 177);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.panel1.ResumeLayout(false);
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label Name;
		private System.Windows.Forms.PictureBox pictureBox1;
	}
}
