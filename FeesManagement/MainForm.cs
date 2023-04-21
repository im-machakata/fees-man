using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace FeesManagement
{
	public partial class MainForm : Form
	{
		// store the default username & password
		// we use constant strings so that the values are not be accidentally changed later in the program
		const string USERNAME ="block2023";
		const string PASSWORD ="2023";
		
		public MainForm()
		{
			InitializeComponent();
		}
		
		// Verify if the username & password are correct
		void LoginBtnClick(object sender, System.EventArgs e)
		{
			if(Username.Text == USERNAME && Password.Text == PASSWORD){
				ReportsForm reportsForm = new ReportsForm();
        		reportsForm.Show();
        		this.Hide();
			} else {
				MessageBox.Show("Username or password is incorrect","Warning!",MessageBoxButtons.OK);
				// reset inputs to labels
				Username.Text = "Username";
				Password.Text = "Password";
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
			if(Password.Text.Trim() == ""){
				Password.Text = "Password";
				Password.ForeColor = Color.FromKnownColor(KnownColor.ScrollBar);
			}
		}
		
		void UsernameLeave(object sender, EventArgs e)
		{
			// if user did not enter anything
			// set text to label
			if(Username.Text.Trim() == ""){
				Username.Text = "Username";
				Username.ForeColor = Color.FromKnownColor(KnownColor.ScrollBar);
			}
		}
		
		void UsernameEnter(object sender, EventArgs e)
		{
			// clear username in equals default
			if(Username.Text == "Username"){
				Username.Clear();
				Username.ForeColor = Color.FromKnownColor(KnownColor.ControlText);;
			}
		}
		
		void PasswordEnter(object sender, EventArgs e)
		{
			// clear password input if = label
			if(Password.Text == "Password"){
				Password.Clear();
				Password.ForeColor = Color.FromKnownColor(KnownColor.ControlText);;
			}
		}
		
		void PasswordKeyUp(object sender, KeyEventArgs e)
		{
			// if user presses enter
			// trigger login
			if (e.KeyCode == Keys.Enter)
		    {
				loginBtn.PerformClick();
		    }
		}
	}
}
