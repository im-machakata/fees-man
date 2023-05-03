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
			this.SchoolName = new System.Windows.Forms.Label();
			this.panel1 = new System.Windows.Forms.Panel();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(23, 20);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(83, 66);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 0;
			this.pictureBox1.TabStop = false;
			// 
			// SchoolName
			// 
			this.SchoolName.BackColor = System.Drawing.Color.Beige;
			this.SchoolName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.SchoolName.Location = new System.Drawing.Point(-7, 98);
			this.SchoolName.Name = "SchoolName";
			this.SchoolName.Padding = new System.Windows.Forms.Padding(0, 8, 0, 0);
			this.SchoolName.Size = new System.Drawing.Size(132, 90);
			this.SchoolName.TabIndex = 1;
			this.SchoolName.Text = "School Name";
			this.SchoolName.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// panel1
			// 
			this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.panel1.BackColor = System.Drawing.Color.White;
			this.panel1.Controls.Add(this.pictureBox1);
			this.panel1.Controls.Add(this.SchoolName);
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(125, 188);
			this.panel1.TabIndex = 2;
			// 
			// SchoolCard
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.panel1);
			this.Location = new System.Drawing.Point(6, 0);
			this.Name = "SchoolCard";
			this.Size = new System.Drawing.Size(125, 188);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.panel1.ResumeLayout(false);
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label SchoolName;
		private System.Windows.Forms.PictureBox pictureBox1;
	}
}
