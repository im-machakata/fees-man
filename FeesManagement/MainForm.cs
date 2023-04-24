﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using FeesManagement.Models;

namespace FeesManagement
{
	public partial class MainForm : Form
	{		
		public MainForm()
		{
			InitializeComponent();
		}
		
		void ChangeInputColor(RichTextBox Input,string Label){
			if(Utils.isEmpty(Input) || Utils.isLabel(Input,Label)){
				Input.ForeColor = Color.FromKnownColor(KnownColor.ScrollBar);
			} else {
				Input.ForeColor = Color.FromKnownColor(KnownColor.ControlText);
			}
		}
		
		void SetupLabel(RichTextBox Input,string Label){
			if(Utils.isEmpty(Input) || Utils.isLabel(Input,Label)){
				Input.Text = Label;
			}
		}
		
		void resetInputColors(){
			ChangeInputColor(Password,"Password");
			ChangeInputColor(Username,"Username");
		}
		
		// Verify if the username & password are correct
		void LoginBtnClick(object sender, System.EventArgs e)
		{
			if(Username.Text == Config.Username && Password.Text == Config.Password){
				ReportsForm reportsForm = new ReportsForm();
        		reportsForm.Show();
        		this.Hide();
			} else {
				MessageBox.Show("Username or password is incorrect","Warning!",MessageBoxButtons.OK);
				// reset inputs to labels
				Username.Text = "Username";
				Password.Text = "Password";
				
				// Change colors
				resetInputColors();
			}
		}
		
		// Close the application when clicked
		void ExitBtnClick(object sender, EventArgs e)
		{
			this.Close();
		}
		
		void PasswordLeave(object sender, EventArgs e)
		{
			// if user did not enter anything
			// set text to label
			ChangeInputColor(Password,"Password");
			SetupLabel(Password,"Password");
		}
		
		void UsernameLeave(object sender, EventArgs e)
		{
			// if user did not enter anything
			// set text to label
			ChangeInputColor(Username,"Username");
			SetupLabel(Username,"Username");
		}
		
		void UsernameEnter(object sender, EventArgs e)
		{
			// clear username in equals default
			if(Utils.isLabel(Username,"Username")){
				Username.Clear();
			}
			ChangeInputColor(Username,"Username");
		}
		
		void PasswordEnter(object sender, EventArgs e)
		{
			// clear password input if = label
			if(Utils.isLabel(Password,"Password")){
				Password.Clear();
			}
			ChangeInputColor(Password,"Password");
		}
		
		void PasswordKeyUp(object sender, KeyEventArgs e)
		{
			ChangeInputColor(Password,"Password");
			// if user presses enter
			// trigger login
			if (e.KeyCode == Keys.Enter)
		    {
				loginBtn.PerformClick();
		    }
		}
		
		void UsernameKeyUp(object sender, KeyEventArgs e)
		{
			ChangeInputColor(Username,"Username");
		}
	}
}
