/*
 * Created by SharpDevelop.
 * User: Caasi
 * Date: 4/24/2023
 * Time: 3:18 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace FeesManagement.Views
{
	partial class Reports
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
			this.StudentResults1 = new System.Windows.Forms.Panel();
			this.StudentSurname1 = new System.Windows.Forms.Panel();
			this.StudentName1 = new System.Windows.Forms.Panel();
			this.studentBalanceBtn = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.studentDescription = new System.Windows.Forms.Label();
			this.ClassPage = new System.Windows.Forms.TabPage();
			this.classFilterBtn = new System.Windows.Forms.Button();
			this.classDescription = new System.Windows.Forms.Label();
			this.SchoolPage = new System.Windows.Forms.TabPage();
			this.schoolFilterButton = new System.Windows.Forms.Button();
			this.schoolDescription = new System.Windows.Forms.Label();
			this.panel1.SuspendLayout();
			this.StudentReport.SuspendLayout();
			this.StudentPage.SuspendLayout();
			this.ClassPage.SuspendLayout();
			this.SchoolPage.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.StudentReport);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(783, 347);
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
			this.StudentReport.Size = new System.Drawing.Size(783, 347);
			this.StudentReport.TabIndex = 0;
			// 
			// StudentPage
			// 
			this.StudentPage.BackColor = System.Drawing.Color.DarkSlateGray;
			this.StudentPage.Controls.Add(this.StudentResults1);
			this.StudentPage.Controls.Add(this.StudentSurname1);
			this.StudentPage.Controls.Add(this.StudentName1);
			this.StudentPage.Controls.Add(this.studentBalanceBtn);
			this.StudentPage.Controls.Add(this.label1);
			this.StudentPage.Controls.Add(this.studentDescription);
			this.StudentPage.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.StudentPage.Location = new System.Drawing.Point(4, 22);
			this.StudentPage.Name = "StudentPage";
			this.StudentPage.Padding = new System.Windows.Forms.Padding(3);
			this.StudentPage.Size = new System.Drawing.Size(775, 321);
			this.StudentPage.TabIndex = 0;
			this.StudentPage.Text = "Student";
			// 
			// StudentResults1
			// 
			this.StudentResults1.BackColor = System.Drawing.Color.White;
			this.StudentResults1.Location = new System.Drawing.Point(255, 100);
			this.StudentResults1.Name = "StudentResults1";
			this.StudentResults1.Size = new System.Drawing.Size(500, 80);
			this.StudentResults1.TabIndex = 10;
			// 
			// StudentSurname1
			// 
			this.StudentSurname1.BackColor = System.Drawing.Color.White;
			this.StudentSurname1.Location = new System.Drawing.Point(18, 175);
			this.StudentSurname1.Name = "StudentSurname1";
			this.StudentSurname1.Size = new System.Drawing.Size(210, 39);
			this.StudentSurname1.TabIndex = 9;
			// 
			// StudentName1
			// 
			this.StudentName1.BackColor = System.Drawing.Color.White;
			this.StudentName1.Location = new System.Drawing.Point(18, 100);
			this.StudentName1.Name = "StudentName1";
			this.StudentName1.Size = new System.Drawing.Size(210, 39);
			this.StudentName1.TabIndex = 9;
			// 
			// studentBalanceBtn
			// 
			this.studentBalanceBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.studentBalanceBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.studentBalanceBtn.Location = new System.Drawing.Point(18, 250);
			this.studentBalanceBtn.Name = "studentBalanceBtn";
			this.studentBalanceBtn.Size = new System.Drawing.Size(210, 47);
			this.studentBalanceBtn.TabIndex = 1;
			this.studentBalanceBtn.Text = "Find Balance";
			this.studentBalanceBtn.UseVisualStyleBackColor = true;
			this.studentBalanceBtn.Click += new System.EventHandler(this.StudentBalanceBtnClick);
			// 
			// label1
			// 
			this.label1.BackColor = System.Drawing.Color.Transparent;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(15, 56);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(514, 23);
			this.label1.TabIndex = 0;
			this.label1.Text = "Types in a name and a surname for the search to be successful";
			// 
			// studentDescription
			// 
			this.studentDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.studentDescription.Location = new System.Drawing.Point(11, 17);
			this.studentDescription.Name = "studentDescription";
			this.studentDescription.Size = new System.Drawing.Size(514, 53);
			this.studentDescription.TabIndex = 0;
			this.studentDescription.Text = "View student balance";
			// 
			// ClassPage
			// 
			this.ClassPage.BackColor = System.Drawing.Color.DarkSlateGray;
			this.ClassPage.Controls.Add(this.classFilterBtn);
			this.ClassPage.Controls.Add(this.classDescription);
			this.ClassPage.Location = new System.Drawing.Point(4, 22);
			this.ClassPage.Name = "ClassPage";
			this.ClassPage.Padding = new System.Windows.Forms.Padding(3);
			this.ClassPage.Size = new System.Drawing.Size(775, 321);
			this.ClassPage.TabIndex = 1;
			this.ClassPage.Text = "Class";
			// 
			// classFilterBtn
			// 
			this.classFilterBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.classFilterBtn.Location = new System.Drawing.Point(18, 254);
			this.classFilterBtn.Name = "classFilterBtn";
			this.classFilterBtn.Size = new System.Drawing.Size(210, 39);
			this.classFilterBtn.TabIndex = 5;
			this.classFilterBtn.Text = "Find Balance";
			this.classFilterBtn.UseVisualStyleBackColor = true;
			this.classFilterBtn.Click += new System.EventHandler(this.ClassFilterBtnClick);
			// 
			// classDescription
			// 
			this.classDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.classDescription.Location = new System.Drawing.Point(19, 17);
			this.classDescription.Name = "classDescription";
			this.classDescription.Size = new System.Drawing.Size(211, 92);
			this.classDescription.TabIndex = 4;
			this.classDescription.Text = "Showing balance for: ";
			// 
			// SchoolPage
			// 
			this.SchoolPage.BackColor = System.Drawing.Color.DarkSlateGray;
			this.SchoolPage.Controls.Add(this.schoolFilterButton);
			this.SchoolPage.Controls.Add(this.schoolDescription);
			this.SchoolPage.Location = new System.Drawing.Point(4, 22);
			this.SchoolPage.Name = "SchoolPage";
			this.SchoolPage.Padding = new System.Windows.Forms.Padding(3);
			this.SchoolPage.Size = new System.Drawing.Size(775, 321);
			this.SchoolPage.TabIndex = 2;
			this.SchoolPage.Text = "School";
			// 
			// schoolFilterButton
			// 
			this.schoolFilterButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.schoolFilterButton.Location = new System.Drawing.Point(19, 251);
			this.schoolFilterButton.Name = "schoolFilterButton";
			this.schoolFilterButton.Size = new System.Drawing.Size(210, 42);
			this.schoolFilterButton.TabIndex = 5;
			this.schoolFilterButton.Text = "Find Balance";
			this.schoolFilterButton.UseVisualStyleBackColor = true;
			this.schoolFilterButton.Click += new System.EventHandler(this.SchoolFilterButtonClick);
			// 
			// schoolDescription
			// 
			this.schoolDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.schoolDescription.Location = new System.Drawing.Point(18, 18);
			this.schoolDescription.Name = "schoolDescription";
			this.schoolDescription.Size = new System.Drawing.Size(211, 92);
			this.schoolDescription.TabIndex = 4;
			this.schoolDescription.Text = "Showing balance for: ";
			// 
			// Reports
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(783, 347);
			this.Controls.Add(this.panel1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Name = "Reports";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Reports";
			this.panel1.ResumeLayout(false);
			this.StudentReport.ResumeLayout(false);
			this.StudentPage.ResumeLayout(false);
			this.ClassPage.ResumeLayout(false);
			this.SchoolPage.ResumeLayout(false);
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Panel StudentResults1;
		private System.Windows.Forms.Panel StudentName1;
		private System.Windows.Forms.Panel StudentSurname1;
		private System.Windows.Forms.Label schoolDescription;
		private System.Windows.Forms.Button schoolFilterButton;
		private System.Windows.Forms.Label classDescription;
		private System.Windows.Forms.Button classFilterBtn;
		private System.Windows.Forms.Label studentDescription;
		private System.Windows.Forms.Button studentBalanceBtn;
		private System.Windows.Forms.TabPage SchoolPage;
		private System.Windows.Forms.TabPage ClassPage;
		private System.Windows.Forms.TabPage StudentPage;
		private System.Windows.Forms.TabControl StudentReport;
		private System.Windows.Forms.Panel panel1;
	}
}
