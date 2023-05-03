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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Reports));
			this.panel1 = new System.Windows.Forms.Panel();
			this.StudentReport = new System.Windows.Forms.TabControl();
			this.StudentPage = new System.Windows.Forms.TabPage();
			this.StudentBalance = new System.Windows.Forms.Label();
			this.StudentResults1 = new System.Windows.Forms.Panel();
			this.StudentSurname1 = new System.Windows.Forms.Panel();
			this.StudentSchool1 = new System.Windows.Forms.Panel();
			this.StudentName1 = new System.Windows.Forms.Panel();
			this.studentBalanceBtn = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.studentDescription = new System.Windows.Forms.Label();
			this.ClassPage = new System.Windows.Forms.TabPage();
			this.ClassTotal = new System.Windows.Forms.Label();
			this.ClassCardContainer = new System.Windows.Forms.Panel();
			this.ClassFilterClass = new System.Windows.Forms.Panel();
			this.ClassFilterSchool = new System.Windows.Forms.Panel();
			this.ClassFilterBtn = new System.Windows.Forms.Button();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.SchoolPage = new System.Windows.Forms.TabPage();
			this.SchoolTotal = new System.Windows.Forms.Label();
			this.School_Card_Container = new System.Windows.Forms.Panel();
			this.SchoolFilterSchool = new System.Windows.Forms.Panel();
			this.SchoolFilterButton = new System.Windows.Forms.Button();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.SchoolName = new System.Windows.Forms.Label();
			this.panel1.SuspendLayout();
			this.StudentReport.SuspendLayout();
			this.StudentPage.SuspendLayout();
			this.ClassPage.SuspendLayout();
			this.SchoolPage.SuspendLayout();
			this.School_Card_Container.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
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
			this.StudentBalance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
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
			// StudentSchool1
			// 
			this.StudentSchool1.BackColor = System.Drawing.Color.White;
			this.StudentSchool1.Location = new System.Drawing.Point(18, 99);
			this.StudentSchool1.Name = "StudentSchool1";
			this.StudentSchool1.Size = new System.Drawing.Size(210, 39);
			this.StudentSchool1.TabIndex = 9;
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
			this.ClassPage.Controls.Add(this.ClassTotal);
			this.ClassPage.Controls.Add(this.ClassCardContainer);
			this.ClassPage.Controls.Add(this.ClassFilterClass);
			this.ClassPage.Controls.Add(this.ClassFilterSchool);
			this.ClassPage.Controls.Add(this.ClassFilterBtn);
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
			// ClassTotal
			// 
			this.ClassTotal.BackColor = System.Drawing.Color.White;
			this.ClassTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ClassTotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.ClassTotal.Location = new System.Drawing.Point(259, 180);
			this.ClassTotal.Name = "ClassTotal";
			this.ClassTotal.Padding = new System.Windows.Forms.Padding(8);
			this.ClassTotal.Size = new System.Drawing.Size(480, 99);
			this.ClassTotal.TabIndex = 18;
			this.ClassTotal.Text = "$0.00";
			this.ClassTotal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// ClassCardContainer
			// 
			this.ClassCardContainer.BackColor = System.Drawing.Color.White;
			this.ClassCardContainer.Location = new System.Drawing.Point(259, 108);
			this.ClassCardContainer.Name = "ClassCardContainer";
			this.ClassCardContainer.Size = new System.Drawing.Size(480, 59);
			this.ClassCardContainer.TabIndex = 17;
			// 
			// ClassFilterClass
			// 
			this.ClassFilterClass.BackColor = System.Drawing.Color.White;
			this.ClassFilterClass.Location = new System.Drawing.Point(19, 169);
			this.ClassFilterClass.Name = "ClassFilterClass";
			this.ClassFilterClass.Size = new System.Drawing.Size(210, 39);
			this.ClassFilterClass.TabIndex = 16;
			// 
			// ClassFilterSchool
			// 
			this.ClassFilterSchool.BackColor = System.Drawing.Color.White;
			this.ClassFilterSchool.Location = new System.Drawing.Point(19, 108);
			this.ClassFilterSchool.Name = "ClassFilterSchool";
			this.ClassFilterSchool.Size = new System.Drawing.Size(210, 39);
			this.ClassFilterSchool.TabIndex = 15;
			// 
			// ClassFilterBtn
			// 
			this.ClassFilterBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.ClassFilterBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ClassFilterBtn.Location = new System.Drawing.Point(19, 232);
			this.ClassFilterBtn.Name = "ClassFilterBtn";
			this.ClassFilterBtn.Size = new System.Drawing.Size(210, 47);
			this.ClassFilterBtn.TabIndex = 14;
			this.ClassFilterBtn.Text = "Find Balance";
			this.ClassFilterBtn.UseVisualStyleBackColor = true;
			this.ClassFilterBtn.Click += new System.EventHandler(this.ClassFilterBtnClick);
			// 
			// label3
			// 
			this.label3.BackColor = System.Drawing.Color.Transparent;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(14, 59);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(514, 23);
			this.label3.TabIndex = 12;
			this.label3.Text = "Type in a class for the search to be successful";
			// 
			// label4
			// 
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(10, 20);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(514, 53);
			this.label4.TabIndex = 13;
			this.label4.Text = "View class balance";
			// 
			// SchoolPage
			// 
			this.SchoolPage.BackColor = System.Drawing.Color.DarkSlateGray;
			this.SchoolPage.Controls.Add(this.SchoolTotal);
			this.SchoolPage.Controls.Add(this.School_Card_Container);
			this.SchoolPage.Controls.Add(this.SchoolFilterSchool);
			this.SchoolPage.Controls.Add(this.SchoolFilterButton);
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
			// SchoolTotal
			// 
			this.SchoolTotal.BackColor = System.Drawing.Color.White;
			this.SchoolTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.SchoolTotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.SchoolTotal.Location = new System.Drawing.Point(249, 104);
			this.SchoolTotal.Name = "SchoolTotal";
			this.SchoolTotal.Padding = new System.Windows.Forms.Padding(8);
			this.SchoolTotal.Size = new System.Drawing.Size(350, 104);
			this.SchoolTotal.TabIndex = 18;
			this.SchoolTotal.Text = "$0.00";
			this.SchoolTotal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// School_Card_Container
			// 
			this.School_Card_Container.BackColor = System.Drawing.Color.White;
			this.School_Card_Container.Controls.Add(this.SchoolName);
			this.School_Card_Container.Controls.Add(this.pictureBox1);
			this.School_Card_Container.Location = new System.Drawing.Point(620, 20);
			this.School_Card_Container.Name = "School_Card_Container";
			this.School_Card_Container.Size = new System.Drawing.Size(125, 188);
			this.School_Card_Container.TabIndex = 17;
			// 
			// SchoolFilterSchool
			// 
			this.SchoolFilterSchool.BackColor = System.Drawing.Color.White;
			this.SchoolFilterSchool.Location = new System.Drawing.Point(19, 104);
			this.SchoolFilterSchool.Name = "SchoolFilterSchool";
			this.SchoolFilterSchool.Size = new System.Drawing.Size(210, 39);
			this.SchoolFilterSchool.TabIndex = 15;
			// 
			// SchoolFilterButton
			// 
			this.SchoolFilterButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.SchoolFilterButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.SchoolFilterButton.Location = new System.Drawing.Point(19, 162);
			this.SchoolFilterButton.Name = "SchoolFilterButton";
			this.SchoolFilterButton.Size = new System.Drawing.Size(210, 47);
			this.SchoolFilterButton.TabIndex = 14;
			this.SchoolFilterButton.Text = "Find Balance";
			this.SchoolFilterButton.UseVisualStyleBackColor = true;
			this.SchoolFilterButton.Click += new System.EventHandler(this.SchoolFilterButtonClick);
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
			// pictureBox1
			// 
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(13, 14);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(100, 82);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox1.TabIndex = 0;
			this.pictureBox1.TabStop = false;
			// 
			// SchoolName
			// 
			this.SchoolName.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
			this.SchoolName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.SchoolName.Location = new System.Drawing.Point(3, 113);
			this.SchoolName.Name = "SchoolName";
			this.SchoolName.Size = new System.Drawing.Size(119, 73);
			this.SchoolName.TabIndex = 1;
			this.SchoolName.Text = "Junior High";
			this.SchoolName.TextAlign = System.Drawing.ContentAlignment.TopCenter;
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
			this.School_Card_Container.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Label SchoolName;
		private System.Windows.Forms.Panel StudentSchool1;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Button SchoolFilterButton;
		private System.Windows.Forms.Panel SchoolFilterSchool;
		private System.Windows.Forms.Panel School_Card_Container;
		private System.Windows.Forms.Label SchoolTotal;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Button ClassFilterBtn;
		private System.Windows.Forms.Panel ClassFilterSchool;
		private System.Windows.Forms.Panel ClassFilterClass;
		private System.Windows.Forms.Panel ClassCardContainer;
		private System.Windows.Forms.Label StudentBalance;
		private System.Windows.Forms.Label ClassTotal;
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
