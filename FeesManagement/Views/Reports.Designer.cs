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
			this.StudentBalance = new System.Windows.Forms.Label();
			this.StudentResults1 = new System.Windows.Forms.Panel();
			this.StudentSurname1 = new System.Windows.Forms.Panel();
			this.StudentName1 = new System.Windows.Forms.Panel();
			this.studentBalanceBtn = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.studentDescription = new System.Windows.Forms.Label();
			this.ClassPage = new System.Windows.Forms.TabPage();
			this.SchoolPage = new System.Windows.Forms.TabPage();
			this.label2 = new System.Windows.Forms.Label();
			this.SchoolCardContainer = new System.Windows.Forms.Panel();
			this.panel3 = new System.Windows.Forms.Panel();
			this.panel4 = new System.Windows.Forms.Panel();
			this.button1 = new System.Windows.Forms.Button();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.panel2 = new System.Windows.Forms.Panel();
			this.panel6 = new System.Windows.Forms.Panel();
			this.button2 = new System.Windows.Forms.Button();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.StudentSchool1 = new System.Windows.Forms.Panel();
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
			this.StudentPage.Controls.Add(this.StudentBalance);
			this.StudentPage.Controls.Add(this.StudentResults1);
			this.StudentPage.Controls.Add(this.StudentSurname1);
			this.StudentPage.Controls.Add(this.StudentSchool1);
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
			// StudentBalance
			// 
			this.StudentBalance.BackColor = System.Drawing.Color.White;
			this.StudentBalance.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.StudentBalance.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.StudentBalance.Location = new System.Drawing.Point(255, 190);
			this.StudentBalance.Name = "StudentBalance";
			this.StudentBalance.Padding = new System.Windows.Forms.Padding(8);
			this.StudentBalance.Size = new System.Drawing.Size(500, 79);
			this.StudentBalance.TabIndex = 11;
			this.StudentBalance.Text = "$0.00";
			this.StudentBalance.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// StudentResults1
			// 
			this.StudentResults1.BackColor = System.Drawing.Color.White;
			this.StudentResults1.Location = new System.Drawing.Point(255, 99);
			this.StudentResults1.Name = "StudentResults1";
			this.StudentResults1.Size = new System.Drawing.Size(500, 80);
			this.StudentResults1.TabIndex = 10;
			// 
			// StudentSurname1
			// 
			this.StudentSurname1.BackColor = System.Drawing.Color.White;
			this.StudentSurname1.Location = new System.Drawing.Point(18, 199);
			this.StudentSurname1.Name = "StudentSurname1";
			this.StudentSurname1.Size = new System.Drawing.Size(210, 39);
			this.StudentSurname1.TabIndex = 9;
			// 
			// StudentName1
			// 
			this.StudentName1.BackColor = System.Drawing.Color.White;
			this.StudentName1.Location = new System.Drawing.Point(18, 149);
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
			this.label1.Text = "Type in a name and surname for the search to be successful";
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
			this.ClassPage.Controls.Add(this.label2);
			this.ClassPage.Controls.Add(this.SchoolCardContainer);
			this.ClassPage.Controls.Add(this.panel3);
			this.ClassPage.Controls.Add(this.panel4);
			this.ClassPage.Controls.Add(this.button1);
			this.ClassPage.Controls.Add(this.label3);
			this.ClassPage.Controls.Add(this.label4);
			this.ClassPage.ForeColor = System.Drawing.Color.White;
			this.ClassPage.Location = new System.Drawing.Point(4, 22);
			this.ClassPage.Name = "ClassPage";
			this.ClassPage.Padding = new System.Windows.Forms.Padding(3);
			this.ClassPage.Size = new System.Drawing.Size(775, 321);
			this.ClassPage.TabIndex = 1;
			this.ClassPage.Text = "Class";
			// 
			// SchoolPage
			// 
			this.SchoolPage.BackColor = System.Drawing.Color.DarkSlateGray;
			this.SchoolPage.Controls.Add(this.label5);
			this.SchoolPage.Controls.Add(this.panel2);
			this.SchoolPage.Controls.Add(this.panel6);
			this.SchoolPage.Controls.Add(this.button2);
			this.SchoolPage.Controls.Add(this.label6);
			this.SchoolPage.Controls.Add(this.label7);
			this.SchoolPage.ForeColor = System.Drawing.Color.White;
			this.SchoolPage.Location = new System.Drawing.Point(4, 22);
			this.SchoolPage.Name = "SchoolPage";
			this.SchoolPage.Padding = new System.Windows.Forms.Padding(3);
			this.SchoolPage.Size = new System.Drawing.Size(775, 321);
			this.SchoolPage.TabIndex = 2;
			this.SchoolPage.Text = "School";
			// 
			// label2
			// 
			this.label2.BackColor = System.Drawing.Color.White;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.label2.Location = new System.Drawing.Point(259, 193);
			this.label2.Name = "label2";
			this.label2.Padding = new System.Windows.Forms.Padding(8);
			this.label2.Size = new System.Drawing.Size(500, 79);
			this.label2.TabIndex = 18;
			this.label2.Text = "$0.00";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// SchoolCardContainer
			// 
			this.SchoolCardContainer.BackColor = System.Drawing.Color.White;
			this.SchoolCardContainer.Location = new System.Drawing.Point(259, 103);
			this.SchoolCardContainer.Name = "SchoolCardContainer";
			this.SchoolCardContainer.Size = new System.Drawing.Size(500, 80);
			this.SchoolCardContainer.TabIndex = 17;
			// 
			// panel3
			// 
			this.panel3.BackColor = System.Drawing.Color.White;
			this.panel3.Location = new System.Drawing.Point(22, 178);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(210, 39);
			this.panel3.TabIndex = 16;
			// 
			// panel4
			// 
			this.panel4.BackColor = System.Drawing.Color.White;
			this.panel4.Location = new System.Drawing.Point(22, 103);
			this.panel4.Name = "panel4";
			this.panel4.Size = new System.Drawing.Size(210, 39);
			this.panel4.TabIndex = 15;
			// 
			// button1
			// 
			this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button1.Location = new System.Drawing.Point(22, 253);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(210, 47);
			this.button1.TabIndex = 14;
			this.button1.Text = "Find Balance";
			this.button1.UseVisualStyleBackColor = true;
			// 
			// label3
			// 
			this.label3.BackColor = System.Drawing.Color.Transparent;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(19, 59);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(514, 23);
			this.label3.TabIndex = 12;
			this.label3.Text = "Type in a class for the search to be successful";
			// 
			// label4
			// 
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(15, 20);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(514, 53);
			this.label4.TabIndex = 13;
			this.label4.Text = "View class balance";
			// 
			// label5
			// 
			this.label5.BackColor = System.Drawing.Color.White;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.label5.Location = new System.Drawing.Point(259, 193);
			this.label5.Name = "label5";
			this.label5.Padding = new System.Windows.Forms.Padding(8);
			this.label5.Size = new System.Drawing.Size(500, 79);
			this.label5.TabIndex = 18;
			this.label5.Text = "$0.00";
			this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.Color.White;
			this.panel2.Location = new System.Drawing.Point(259, 103);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(500, 80);
			this.panel2.TabIndex = 17;
			// 
			// panel6
			// 
			this.panel6.BackColor = System.Drawing.Color.White;
			this.panel6.Location = new System.Drawing.Point(22, 103);
			this.panel6.Name = "panel6";
			this.panel6.Size = new System.Drawing.Size(210, 39);
			this.panel6.TabIndex = 15;
			// 
			// button2
			// 
			this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button2.Location = new System.Drawing.Point(22, 165);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(210, 47);
			this.button2.TabIndex = 14;
			this.button2.Text = "Find Balance";
			this.button2.UseVisualStyleBackColor = true;
			// 
			// label6
			// 
			this.label6.BackColor = System.Drawing.Color.Transparent;
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(19, 59);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(514, 23);
			this.label6.TabIndex = 12;
			this.label6.Text = "Type in the name of the school to calculate its balance";
			// 
			// label7
			// 
			this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.Location = new System.Drawing.Point(15, 20);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(514, 53);
			this.label7.TabIndex = 13;
			this.label7.Text = "View school balance";
			// 
			// StudentSchool1
			// 
			this.StudentSchool1.BackColor = System.Drawing.Color.White;
			this.StudentSchool1.Location = new System.Drawing.Point(18, 99);
			this.StudentSchool1.Name = "StudentSchool1";
			this.StudentSchool1.Size = new System.Drawing.Size(210, 39);
			this.StudentSchool1.TabIndex = 9;
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
		private System.Windows.Forms.Panel StudentSchool1;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Panel panel6;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Panel panel4;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.Panel SchoolCardContainer;
		private System.Windows.Forms.Label StudentBalance;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Panel StudentResults1;
		private System.Windows.Forms.Panel StudentName1;
		private System.Windows.Forms.Panel StudentSurname1;
		private System.Windows.Forms.Label studentDescription;
		private System.Windows.Forms.Button studentBalanceBtn;
		private System.Windows.Forms.TabPage SchoolPage;
		private System.Windows.Forms.TabPage ClassPage;
		private System.Windows.Forms.TabPage StudentPage;
		private System.Windows.Forms.TabControl StudentReport;
		private System.Windows.Forms.Panel panel1;
	}
}
