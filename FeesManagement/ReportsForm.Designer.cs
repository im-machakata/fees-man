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
			this.studentClass = new System.Windows.Forms.TextBox();
			this.studentBalance = new System.Windows.Forms.Label();
			this.studentName = new System.Windows.Forms.TextBox();
			this.studentBalanceBtn = new System.Windows.Forms.Button();
			this.studentDescription = new System.Windows.Forms.Label();
			this.ClassPage = new System.Windows.Forms.TabPage();
			this.classBalance = new System.Windows.Forms.Label();
			this.className = new System.Windows.Forms.TextBox();
			this.classFilterBtn = new System.Windows.Forms.Button();
			this.classDescription = new System.Windows.Forms.Label();
			this.SchoolPage = new System.Windows.Forms.TabPage();
			this.schoolBalance = new System.Windows.Forms.Label();
			this.schoolName = new System.Windows.Forms.TextBox();
			this.schoolFilterButton = new System.Windows.Forms.Button();
			this.schoolDescription = new System.Windows.Forms.Label();
			this.panel2 = new System.Windows.Forms.Panel();
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
			this.panel1.Size = new System.Drawing.Size(820, 293);
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
			this.StudentReport.Size = new System.Drawing.Size(820, 293);
			this.StudentReport.TabIndex = 0;
			// 
			// StudentPage
			// 
			this.StudentPage.Controls.Add(this.panel2);
			this.StudentPage.Controls.Add(this.studentClass);
			this.StudentPage.Controls.Add(this.studentBalance);
			this.StudentPage.Controls.Add(this.studentName);
			this.StudentPage.Controls.Add(this.studentBalanceBtn);
			this.StudentPage.Controls.Add(this.studentDescription);
			this.StudentPage.Location = new System.Drawing.Point(4, 22);
			this.StudentPage.Name = "StudentPage";
			this.StudentPage.Padding = new System.Windows.Forms.Padding(3);
			this.StudentPage.Size = new System.Drawing.Size(812, 267);
			this.StudentPage.TabIndex = 0;
			this.StudentPage.Text = "Student";
			this.StudentPage.UseVisualStyleBackColor = true;
			// 
			// studentClass
			// 
			this.studentClass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.studentClass.Location = new System.Drawing.Point(18, 136);
			this.studentClass.Name = "studentClass";
			this.studentClass.Size = new System.Drawing.Size(211, 26);
			this.studentClass.TabIndex = 4;
			this.studentClass.Text = "Class";
			// 
			// studentBalance
			// 
			this.studentBalance.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.studentBalance.Location = new System.Drawing.Point(18, 165);
			this.studentBalance.Name = "studentBalance";
			this.studentBalance.Size = new System.Drawing.Size(210, 32);
			this.studentBalance.TabIndex = 3;
			this.studentBalance.Text = "$0.00";
			this.studentBalance.Click += new System.EventHandler(this.Label2Click);
			// 
			// studentName
			// 
			this.studentName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.studentName.Location = new System.Drawing.Point(18, 104);
			this.studentName.Name = "studentName";
			this.studentName.Size = new System.Drawing.Size(211, 26);
			this.studentName.TabIndex = 2;
			this.studentName.Text = "Name";
			// 
			// studentBalanceBtn
			// 
			this.studentBalanceBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.studentBalanceBtn.Location = new System.Drawing.Point(18, 205);
			this.studentBalanceBtn.Name = "studentBalanceBtn";
			this.studentBalanceBtn.Size = new System.Drawing.Size(210, 38);
			this.studentBalanceBtn.TabIndex = 1;
			this.studentBalanceBtn.Text = "Find Balance";
			this.studentBalanceBtn.UseVisualStyleBackColor = true;
			this.studentBalanceBtn.Click += new System.EventHandler(this.StudentBalanceBtnClick);
			// 
			// studentDescription
			// 
			this.studentDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.studentDescription.Location = new System.Drawing.Point(18, 19);
			this.studentDescription.Name = "studentDescription";
			this.studentDescription.Size = new System.Drawing.Size(211, 92);
			this.studentDescription.TabIndex = 0;
			this.studentDescription.Text = "Showing balance for: ";
			// 
			// ClassPage
			// 
			this.ClassPage.Controls.Add(this.classBalance);
			this.ClassPage.Controls.Add(this.className);
			this.ClassPage.Controls.Add(this.classFilterBtn);
			this.ClassPage.Controls.Add(this.classDescription);
			this.ClassPage.Location = new System.Drawing.Point(4, 22);
			this.ClassPage.Name = "ClassPage";
			this.ClassPage.Padding = new System.Windows.Forms.Padding(3);
			this.ClassPage.Size = new System.Drawing.Size(263, 267);
			this.ClassPage.TabIndex = 1;
			this.ClassPage.Text = "Class";
			this.ClassPage.UseVisualStyleBackColor = true;
			// 
			// classBalance
			// 
			this.classBalance.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.classBalance.Location = new System.Drawing.Point(19, 156);
			this.classBalance.Name = "classBalance";
			this.classBalance.Size = new System.Drawing.Size(210, 33);
			this.classBalance.TabIndex = 7;
			this.classBalance.Text = "$0.00";
			// 
			// className
			// 
			this.className.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.className.Location = new System.Drawing.Point(18, 115);
			this.className.Name = "className";
			this.className.Size = new System.Drawing.Size(211, 26);
			this.className.TabIndex = 6;
			// 
			// classFilterBtn
			// 
			this.classFilterBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.classFilterBtn.Location = new System.Drawing.Point(19, 206);
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
			this.classDescription.Location = new System.Drawing.Point(18, 20);
			this.classDescription.Name = "classDescription";
			this.classDescription.Size = new System.Drawing.Size(211, 92);
			this.classDescription.TabIndex = 4;
			this.classDescription.Text = "Showing balance for: ";
			// 
			// SchoolPage
			// 
			this.SchoolPage.Controls.Add(this.schoolBalance);
			this.SchoolPage.Controls.Add(this.schoolName);
			this.SchoolPage.Controls.Add(this.schoolFilterButton);
			this.SchoolPage.Controls.Add(this.schoolDescription);
			this.SchoolPage.Location = new System.Drawing.Point(4, 22);
			this.SchoolPage.Name = "SchoolPage";
			this.SchoolPage.Padding = new System.Windows.Forms.Padding(3);
			this.SchoolPage.Size = new System.Drawing.Size(263, 267);
			this.SchoolPage.TabIndex = 2;
			this.SchoolPage.Text = "School";
			this.SchoolPage.UseVisualStyleBackColor = true;
			// 
			// schoolBalance
			// 
			this.schoolBalance.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.schoolBalance.Location = new System.Drawing.Point(17, 151);
			this.schoolBalance.Name = "schoolBalance";
			this.schoolBalance.Size = new System.Drawing.Size(210, 44);
			this.schoolBalance.TabIndex = 7;
			this.schoolBalance.Text = "$0.00";
			// 
			// schoolName
			// 
			this.schoolName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.schoolName.Location = new System.Drawing.Point(16, 112);
			this.schoolName.Name = "schoolName";
			this.schoolName.Size = new System.Drawing.Size(211, 26);
			this.schoolName.TabIndex = 6;
			// 
			// schoolFilterButton
			// 
			this.schoolFilterButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.schoolFilterButton.Location = new System.Drawing.Point(17, 198);
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
			this.schoolDescription.Location = new System.Drawing.Point(16, 17);
			this.schoolDescription.Name = "schoolDescription";
			this.schoolDescription.Size = new System.Drawing.Size(211, 92);
			this.schoolDescription.TabIndex = 4;
			this.schoolDescription.Text = "Showing balance for: ";
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.Color.DimGray;
			this.panel2.Location = new System.Drawing.Point(289, 6);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(5, 255);
			this.panel2.TabIndex = 5;
			// 
			// ReportsForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(820, 293);
			this.Controls.Add(this.panel1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Name = "ReportsForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Reports";
			this.panel1.ResumeLayout(false);
			this.StudentReport.ResumeLayout(false);
			this.StudentPage.ResumeLayout(false);
			this.StudentPage.PerformLayout();
			this.ClassPage.ResumeLayout(false);
			this.ClassPage.PerformLayout();
			this.SchoolPage.ResumeLayout(false);
			this.SchoolPage.PerformLayout();
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.TextBox studentClass;
		private System.Windows.Forms.Label schoolDescription;
		private System.Windows.Forms.Button schoolFilterButton;
		private System.Windows.Forms.TextBox schoolName;
		private System.Windows.Forms.Label schoolBalance;
		private System.Windows.Forms.Label classDescription;
		private System.Windows.Forms.Button classFilterBtn;
		private System.Windows.Forms.TextBox className;
		private System.Windows.Forms.Label classBalance;
		private System.Windows.Forms.TextBox studentName;
		private System.Windows.Forms.Label studentBalance;
		private System.Windows.Forms.Label studentDescription;
		private System.Windows.Forms.Button studentBalanceBtn;
		private System.Windows.Forms.TabPage SchoolPage;
		private System.Windows.Forms.TabPage ClassPage;
		private System.Windows.Forms.TabPage StudentPage;
		private System.Windows.Forms.TabControl StudentReport;
		private System.Windows.Forms.Panel panel1;
	}
}
