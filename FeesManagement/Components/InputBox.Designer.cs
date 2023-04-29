/*
 * Created by SharpDevelop.
 * User: Caasi
 * Date: 4/29/2023
 * Time: 9:22 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace FeesManagement.Components
{
	partial class InputBox
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
			this.UsernamePanel = new System.Windows.Forms.Panel();
			this.ILabel = new System.Windows.Forms.RichTextBox();
			this.UsernamePanel.SuspendLayout();
			this.SuspendLayout();
			// 
			// UsernamePanel
			// 
			this.UsernamePanel.BackColor = System.Drawing.SystemColors.HighlightText;
			this.UsernamePanel.Controls.Add(this.ILabel);
			this.UsernamePanel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.UsernamePanel.Location = new System.Drawing.Point(0, 0);
			this.UsernamePanel.Name = "UsernamePanel";
			this.UsernamePanel.Size = new System.Drawing.Size(250, 39);
			this.UsernamePanel.TabIndex = 2;
			// 
			// ILabel
			// 
			this.ILabel.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.ILabel.DetectUrls = false;
			this.ILabel.Font = new System.Drawing.Font("Arial", 12F);
			this.ILabel.ForeColor = System.Drawing.SystemColors.ScrollBar;
			this.ILabel.Location = new System.Drawing.Point(13, 10);
			this.ILabel.MaxLength = 50;
			this.ILabel.Multiline = false;
			this.ILabel.Name = "ILabel";
			this.ILabel.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
			this.ILabel.Size = new System.Drawing.Size(225, 19);
			this.ILabel.TabIndex = 1;
			this.ILabel.Text = "Label";
			this.ILabel.TextChanged += new System.EventHandler(this.ILabelTextChanged);
			this.ILabel.Enter += new System.EventHandler(this.ILabelEnter);
			this.ILabel.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ILabelKeyPress);
			this.ILabel.KeyUp += new System.Windows.Forms.KeyEventHandler(this.ILabelKeyUp);
			this.ILabel.Leave += new System.EventHandler(this.ILabelLeave);
			// 
			// InputBox
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.UsernamePanel);
			this.Name = "InputBox";
			this.Size = new System.Drawing.Size(250, 39);
			this.UsernamePanel.ResumeLayout(false);
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.RichTextBox ILabel;
		private System.Windows.Forms.Panel UsernamePanel;
	}
}
