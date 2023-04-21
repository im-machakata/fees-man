/*
 * Created by SharpDevelop.
 * User: Caasi
 * Date: 4/20/2023
 * Time: 9:07 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace FeesManagement
{
	partial class ReportsForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
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
			this.panel1 = new System.Windows.Forms.Panel();
			this.StudentReport = new System.Windows.Forms.TabControl();
			this.StudentPage = new System.Windows.Forms.TabPage();
			this.ClassPage = new System.Windows.Forms.TabPage();
			this.SchoolPage = new System.Windows.Forms.TabPage();
			this.panel1.SuspendLayout();
			this.StudentReport.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.StudentReport);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(708, 350);
			this.panel1.TabIndex = 0;
			// 
			// StudentReport
			// 
			this.StudentReport.Controls.Add(this.StudentPage);
			this.StudentReport.Controls.Add(this.ClassPage);
			this.StudentReport.Controls.Add(this.SchoolPage);
			this.StudentReport.Dock = System.Windows.Forms.DockStyle.Fill;
			this.StudentReport.Location = new System.Drawing.Point(0, 0);
			this.StudentReport.Name = "StudentReport";
			this.StudentReport.SelectedIndex = 0;
			this.StudentReport.Size = new System.Drawing.Size(708, 350);
			this.StudentReport.TabIndex = 0;
			// 
			// StudentPage
			// 
			this.StudentPage.Location = new System.Drawing.Point(4, 22);
			this.StudentPage.Name = "StudentPage";
			this.StudentPage.Padding = new System.Windows.Forms.Padding(3);
			this.StudentPage.Size = new System.Drawing.Size(700, 324);
			this.StudentPage.TabIndex = 0;
			this.StudentPage.Text = "Student";
			this.StudentPage.UseVisualStyleBackColor = true;
			// 
			// ClassPage
			// 
			this.ClassPage.Location = new System.Drawing.Point(4, 22);
			this.ClassPage.Name = "ClassPage";
			this.ClassPage.Padding = new System.Windows.Forms.Padding(3);
			this.ClassPage.Size = new System.Drawing.Size(667, 283);
			this.ClassPage.TabIndex = 1;
			this.ClassPage.Text = "Class";
			this.ClassPage.UseVisualStyleBackColor = true;
			// 
			// SchoolPage
			// 
			this.SchoolPage.Location = new System.Drawing.Point(4, 22);
			this.SchoolPage.Name = "SchoolPage";
			this.SchoolPage.Padding = new System.Windows.Forms.Padding(3);
			this.SchoolPage.Size = new System.Drawing.Size(667, 283);
			this.SchoolPage.TabIndex = 2;
			this.SchoolPage.Text = "School";
			this.SchoolPage.UseVisualStyleBackColor = true;
			// 
			// ReportsForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(708, 350);
			this.Controls.Add(this.panel1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Name = "ReportsForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Reports";
			this.panel1.ResumeLayout(false);
			this.StudentReport.ResumeLayout(false);
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.TabPage SchoolPage;
		private System.Windows.Forms.TabPage ClassPage;
		private System.Windows.Forms.TabPage StudentPage;
		private System.Windows.Forms.TabControl StudentReport;
		private System.Windows.Forms.Panel panel1;
	}
}
