/*
 * Created by SharpDevelop.
 * User: Caasi
 * Date: 4/28/2023
 * Time: 5:17 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace FeesManagement.Components
{
	partial class StudentCard
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StudentCard));
			this.panel1 = new System.Windows.Forms.Panel();
			this.StudentSurname = new System.Windows.Forms.Label();
			this.StudentName = new System.Windows.Forms.Label();
			this.Icon = new System.Windows.Forms.PictureBox();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.Icon)).BeginInit();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.White;
			this.panel1.Controls.Add(this.StudentSurname);
			this.panel1.Controls.Add(this.StudentName);
			this.panel1.Controls.Add(this.Icon);
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(500, 80);
			this.panel1.TabIndex = 0;
			// 
			// StudentSurname
			// 
			this.StudentSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.StudentSurname.Location = new System.Drawing.Point(80, 41);
			this.StudentSurname.Name = "StudentSurname";
			this.StudentSurname.Size = new System.Drawing.Size(169, 23);
			this.StudentSurname.TabIndex = 2;
			this.StudentSurname.Text = "Doe";
			// 
			// StudentName
			// 
			this.StudentName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.StudentName.Location = new System.Drawing.Point(80, 21);
			this.StudentName.Name = "StudentName";
			this.StudentName.Size = new System.Drawing.Size(170, 24);
			this.StudentName.TabIndex = 1;
			this.StudentName.Text = "John";
			// 
			// Icon
			// 
			this.Icon.Image = ((System.Drawing.Image)(resources.GetObject("Icon.Image")));
			this.Icon.Location = new System.Drawing.Point(20, 15);
			this.Icon.Name = "Icon";
			this.Icon.Size = new System.Drawing.Size(50, 50);
			this.Icon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.Icon.TabIndex = 0;
			this.Icon.TabStop = false;
			// 
			// StudentCard
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.panel1);
			this.Name = "StudentCard";
			this.Size = new System.Drawing.Size(500, 80);
			this.panel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.Icon)).EndInit();
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.PictureBox Icon;
		private System.Windows.Forms.Label StudentName;
		private System.Windows.Forms.Label StudentSurname;
		private System.Windows.Forms.Panel panel1;
	}
}
