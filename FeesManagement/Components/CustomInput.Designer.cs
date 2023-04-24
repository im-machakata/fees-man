/*
 * Created by SharpDevelop.
 * User: Caasi
 * Date: 4/24/2023
 * Time: 3:37 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace FeesManagement.Components
{
	partial class CustomInput
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
			this.ILabel = new System.Windows.Forms.Label();
			this.CInput = new System.Windows.Forms.TextBox();
			this.IPanel = new System.Windows.Forms.Panel();
			this.SuspendLayout();
			// 
			// ILabel
			// 
			this.ILabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ILabel.Location = new System.Drawing.Point(14, 9);
			this.ILabel.Name = "ILabel";
			this.ILabel.Size = new System.Drawing.Size(100, 14);
			this.ILabel.TabIndex = 0;
			this.ILabel.Text = "Label";
			// 
			// CInput
			// 
			this.CInput.BackColor = System.Drawing.SystemColors.MenuBar;
			this.CInput.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.CInput.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.CInput.Location = new System.Drawing.Point(16, 26);
			this.CInput.Name = "CInput";
			this.CInput.Size = new System.Drawing.Size(448, 24);
			this.CInput.TabIndex = 1;
			// 
			// IPanel
			// 
			this.IPanel.BackColor = System.Drawing.SystemColors.MenuHighlight;
			this.IPanel.Location = new System.Drawing.Point(0, 0);
			this.IPanel.Name = "IPanel";
			this.IPanel.Size = new System.Drawing.Size(6, 58);
			this.IPanel.TabIndex = 2;
			// 
			// CustomInput
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.Controls.Add(this.IPanel);
			this.Controls.Add(this.CInput);
			this.Controls.Add(this.ILabel);
			this.Name = "CustomInput";
			this.Size = new System.Drawing.Size(474, 58);
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Panel IPanel;
		private System.Windows.Forms.TextBox CInput;
		private System.Windows.Forms.Label ILabel;
	}
}
