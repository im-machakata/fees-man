/*
 * Created by SharpDevelop.
 * User: Caasi
 * Date: 4/24/2023
 * Time: 3:09 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace FeesManagement.Views
{
	partial class Login
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
			this.panel1 = new System.Windows.Forms.Panel();
			this.ExitBtn = new System.Windows.Forms.Label();
			this.loginBtn = new System.Windows.Forms.Button();
			this.PasswordPanel = new System.Windows.Forms.Panel();
			this.UsernamePanel = new System.Windows.Forms.Panel();
			this.signInImage = new System.Windows.Forms.PictureBox();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.signInImage)).BeginInit();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
			this.panel1.Controls.Add(this.ExitBtn);
			this.panel1.Controls.Add(this.loginBtn);
			this.panel1.Controls.Add(this.PasswordPanel);
			this.panel1.Controls.Add(this.UsernamePanel);
			this.panel1.Controls.Add(this.signInImage);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(500, 400);
			this.panel1.TabIndex = 0;
			// 
			// ExitBtn
			// 
			this.ExitBtn.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
			this.ExitBtn.Cursor = System.Windows.Forms.Cursors.Hand;
			this.ExitBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ExitBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.ExitBtn.Location = new System.Drawing.Point(213, 368);
			this.ExitBtn.Name = "ExitBtn";
			this.ExitBtn.Size = new System.Drawing.Size(83, 23);
			this.ExitBtn.TabIndex = 4;
			this.ExitBtn.Text = "Exit Sytem";
			this.ExitBtn.Click += new System.EventHandler(this.ExitBtnClick);
			// 
			// loginBtn
			// 
			this.loginBtn.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.loginBtn.FlatAppearance.BorderSize = 0;
			this.loginBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.loginBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.loginBtn.ForeColor = System.Drawing.SystemColors.InfoText;
			this.loginBtn.Location = new System.Drawing.Point(80, 287);
			this.loginBtn.Name = "loginBtn";
			this.loginBtn.Size = new System.Drawing.Size(350, 41);
			this.loginBtn.TabIndex = 3;
			this.loginBtn.Text = "LOGIN";
			this.loginBtn.UseVisualStyleBackColor = false;
			this.loginBtn.Click += new System.EventHandler(this.LoginBtnClick);
			// 
			// PasswordPanel
			// 
			this.PasswordPanel.BackColor = System.Drawing.SystemColors.HighlightText;
			this.PasswordPanel.Location = new System.Drawing.Point(80, 223);
			this.PasswordPanel.Name = "PasswordPanel";
			this.PasswordPanel.Size = new System.Drawing.Size(350, 39);
			this.PasswordPanel.TabIndex = 2;
			// 
			// UsernamePanel
			// 
			this.UsernamePanel.BackColor = System.Drawing.SystemColors.HighlightText;
			this.UsernamePanel.Location = new System.Drawing.Point(80, 157);
			this.UsernamePanel.Name = "UsernamePanel";
			this.UsernamePanel.Size = new System.Drawing.Size(350, 39);
			this.UsernamePanel.TabIndex = 1;
			// 
			// signInImage
			// 
			this.signInImage.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
			this.signInImage.Image = ((System.Drawing.Image)(resources.GetObject("signInImage.Image")));
			this.signInImage.InitialImage = ((System.Drawing.Image)(resources.GetObject("signInImage.InitialImage")));
			this.signInImage.Location = new System.Drawing.Point(206, 32);
			this.signInImage.Name = "signInImage";
			this.signInImage.Size = new System.Drawing.Size(90, 90);
			this.signInImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.signInImage.TabIndex = 0;
			this.signInImage.TabStop = false;
			// 
			// Login
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(500, 400);
			this.Controls.Add(this.panel1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "Login";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "FeesManagement";
			this.Click += new System.EventHandler(this.LoginBtnClick);
			this.panel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.signInImage)).EndInit();
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.Label ExitBtn;
		private System.Windows.Forms.Panel UsernamePanel;
		private System.Windows.Forms.Panel PasswordPanel;
		private System.Windows.Forms.Button loginBtn;
		private System.Windows.Forms.PictureBox signInImage;
		private System.Windows.Forms.Panel panel1;
	}
}
