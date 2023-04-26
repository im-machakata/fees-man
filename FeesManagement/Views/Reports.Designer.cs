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
			this.button6 = new System.Windows.Forms.Button();
			this.button5 = new System.Windows.Forms.Button();
			this.button4 = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.button1 = new System.Windows.Forms.Button();
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.panel2 = new System.Windows.Forms.Panel();
			this.studentClass = new System.Windows.Forms.TextBox();
			this.studentBalance = new System.Windows.Forms.Label();
			this.studentName = new System.Windows.Forms.TextBox();
			this.studentBalanceBtn = new System.Windows.Forms.Button();
			this.studentDescription = new System.Windows.Forms.Label();
			this.ClassPage = new System.Windows.Forms.TabPage();
			this.panel3 = new System.Windows.Forms.Panel();
			this.classBalance = new System.Windows.Forms.Label();
			this.className = new System.Windows.Forms.TextBox();
			this.classFilterBtn = new System.Windows.Forms.Button();
			this.classDescription = new System.Windows.Forms.Label();
			this.SchoolPage = new System.Windows.Forms.TabPage();
			this.panel4 = new System.Windows.Forms.Panel();
			this.schoolBalance = new System.Windows.Forms.Label();
			this.schoolName = new System.Windows.Forms.TextBox();
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
			this.panel1.Size = new System.Drawing.Size(812, 300);
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
			this.StudentReport.Size = new System.Drawing.Size(812, 300);
			this.StudentReport.TabIndex = 0;
			// 
			// StudentPage
			// 
			this.StudentPage.Controls.Add(this.button6);
			this.StudentPage.Controls.Add(this.button5);
			this.StudentPage.Controls.Add(this.button4);
			this.StudentPage.Controls.Add(this.button3);
			this.StudentPage.Controls.Add(this.button2);
			this.StudentPage.Controls.Add(this.button1);
			this.StudentPage.Controls.Add(this.tableLayoutPanel1);
			this.StudentPage.Controls.Add(this.panel2);
			this.StudentPage.Controls.Add(this.studentClass);
			this.StudentPage.Controls.Add(this.studentBalance);
			this.StudentPage.Controls.Add(this.studentName);
			this.StudentPage.Controls.Add(this.studentBalanceBtn);
			this.StudentPage.Controls.Add(this.studentDescription);
			this.StudentPage.Location = new System.Drawing.Point(4, 22);
			this.StudentPage.Name = "StudentPage";
			this.StudentPage.Padding = new System.Windows.Forms.Padding(3);
			this.StudentPage.Size = new System.Drawing.Size(804, 274);
			this.StudentPage.TabIndex = 0;
			this.StudentPage.Text = "Student";
			this.StudentPage.UseVisualStyleBackColor = true;
			// 
			// button6
			// 
			this.button6.Location = new System.Drawing.Point(695, 7);
			this.button6.Name = "button6";
			this.button6.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.button6.Size = new System.Drawing.Size(75, 23);
			this.button6.TabIndex = 7;
			this.button6.Text = "Form 6";
			this.button6.UseVisualStyleBackColor = true;
			// 
			// button5
			// 
			this.button5.Location = new System.Drawing.Point(614, 7);
			this.button5.Name = "button5";
			this.button5.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.button5.Size = new System.Drawing.Size(75, 23);
			this.button5.TabIndex = 7;
			this.button5.Text = "Form 5";
			this.button5.UseVisualStyleBackColor = true;
			// 
			// button4
			// 
			this.button4.Location = new System.Drawing.Point(533, 7);
			this.button4.Name = "button4";
			this.button4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.button4.Size = new System.Drawing.Size(75, 23);
			this.button4.TabIndex = 7;
			this.button4.Text = "Form 4";
			this.button4.UseVisualStyleBackColor = true;
			// 
			// button3
			// 
			this.button3.Location = new System.Drawing.Point(452, 7);
			this.button3.Name = "button3";
			this.button3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.button3.Size = new System.Drawing.Size(75, 23);
			this.button3.TabIndex = 7;
			this.button3.Text = "Form 3";
			this.button3.UseVisualStyleBackColor = true;
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(371, 7);
			this.button2.Name = "button2";
			this.button2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.button2.Size = new System.Drawing.Size(75, 23);
			this.button2.TabIndex = 7;
			this.button2.Text = "Form 2";
			this.button2.UseVisualStyleBackColor = true;
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(290, 7);
			this.button1.Name = "button1";
			this.button1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.button1.Size = new System.Drawing.Size(75, 23);
			this.button1.TabIndex = 7;
			this.button1.Text = "Form 1";
			this.button1.UseVisualStyleBackColor = true;
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.ColumnCount = 4;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 106F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 54F));
			this.tableLayoutPanel1.Location = new System.Drawing.Point(290, 34);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 2;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(486, 220);
			this.tableLayoutPanel1.TabIndex = 6;
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.Color.DimGray;
			this.panel2.Location = new System.Drawing.Point(257, 6);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(5, 255);
			this.panel2.TabIndex = 5;
			// 
			// studentClass
			// 
			this.studentClass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.studentClass.Location = new System.Drawing.Point(18, 123);
			this.studentClass.Name = "studentClass";
			this.studentClass.Size = new System.Drawing.Size(211, 26);
			this.studentClass.TabIndex = 4;
			this.studentClass.Text = "Class";
			// 
			// studentBalance
			// 
			this.studentBalance.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.studentBalance.Location = new System.Drawing.Point(18, 152);
			this.studentBalance.Name = "studentBalance";
			this.studentBalance.Size = new System.Drawing.Size(210, 32);
			this.studentBalance.TabIndex = 3;
			this.studentBalance.Text = "$0.00";
			// 
			// studentName
			// 
			this.studentName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.studentName.Location = new System.Drawing.Point(18, 91);
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
			this.studentDescription.Location = new System.Drawing.Point(18, 6);
			this.studentDescription.Name = "studentDescription";
			this.studentDescription.Size = new System.Drawing.Size(211, 92);
			this.studentDescription.TabIndex = 0;
			this.studentDescription.Text = "Showing balance for: ";
			// 
			// ClassPage
			// 
			this.ClassPage.Controls.Add(this.panel3);
			this.ClassPage.Controls.Add(this.classBalance);
			this.ClassPage.Controls.Add(this.className);
			this.ClassPage.Controls.Add(this.classFilterBtn);
			this.ClassPage.Controls.Add(this.classDescription);
			this.ClassPage.Location = new System.Drawing.Point(4, 22);
			this.ClassPage.Name = "ClassPage";
			this.ClassPage.Padding = new System.Windows.Forms.Padding(3);
			this.ClassPage.Size = new System.Drawing.Size(804, 274);
			this.ClassPage.TabIndex = 1;
			this.ClassPage.Text = "Class";
			this.ClassPage.UseVisualStyleBackColor = true;
			// 
			// panel3
			// 
			this.panel3.BackColor = System.Drawing.Color.DimGray;
			this.panel3.Location = new System.Drawing.Point(260, 6);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(5, 255);
			this.panel3.TabIndex = 8;
			// 
			// classBalance
			// 
			this.classBalance.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.classBalance.Location = new System.Drawing.Point(19, 136);
			this.classBalance.Name = "classBalance";
			this.classBalance.Size = new System.Drawing.Size(210, 33);
			this.classBalance.TabIndex = 7;
			this.classBalance.Text = "$0.00";
			// 
			// className
			// 
			this.className.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.className.Location = new System.Drawing.Point(19, 92);
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
			this.classDescription.Location = new System.Drawing.Point(18, 6);
			this.classDescription.Name = "classDescription";
			this.classDescription.Size = new System.Drawing.Size(211, 92);
			this.classDescription.TabIndex = 4;
			this.classDescription.Text = "Showing balance for: ";
			// 
			// SchoolPage
			// 
			this.SchoolPage.Controls.Add(this.panel4);
			this.SchoolPage.Controls.Add(this.schoolBalance);
			this.SchoolPage.Controls.Add(this.schoolName);
			this.SchoolPage.Controls.Add(this.schoolFilterButton);
			this.SchoolPage.Controls.Add(this.schoolDescription);
			this.SchoolPage.Location = new System.Drawing.Point(4, 22);
			this.SchoolPage.Name = "SchoolPage";
			this.SchoolPage.Padding = new System.Windows.Forms.Padding(3);
			this.SchoolPage.Size = new System.Drawing.Size(804, 274);
			this.SchoolPage.TabIndex = 2;
			this.SchoolPage.Text = "School";
			this.SchoolPage.UseVisualStyleBackColor = true;
			// 
			// panel4
			// 
			this.panel4.BackColor = System.Drawing.Color.DimGray;
			this.panel4.Location = new System.Drawing.Point(250, 6);
			this.panel4.Name = "panel4";
			this.panel4.Size = new System.Drawing.Size(5, 255);
			this.panel4.TabIndex = 8;
			// 
			// schoolBalance
			// 
			this.schoolBalance.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.schoolBalance.Location = new System.Drawing.Point(17, 130);
			this.schoolBalance.Name = "schoolBalance";
			this.schoolBalance.Size = new System.Drawing.Size(210, 44);
			this.schoolBalance.TabIndex = 7;
			this.schoolBalance.Text = "$0.00";
			// 
			// schoolName
			// 
			this.schoolName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.schoolName.Location = new System.Drawing.Point(17, 101);
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
			this.schoolDescription.Location = new System.Drawing.Point(17, 6);
			this.schoolDescription.Name = "schoolDescription";
			this.schoolDescription.Size = new System.Drawing.Size(211, 92);
			this.schoolDescription.TabIndex = 4;
			this.schoolDescription.Text = "Showing balance for: ";
			// 
			// Reports
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(812, 300);
			this.Controls.Add(this.panel1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Name = "Reports";
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
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Button button4;
		private System.Windows.Forms.Button button5;
		private System.Windows.Forms.Button button6;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.Panel panel4;
		private System.Windows.Forms.Panel panel3;
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
