using System;
using System.Drawing;
using System.Windows.Forms;
using FeesManagement.Models;
using FeesManagement.Utils;
using FeesManagement.Components;

namespace FeesManagement.Views
{
	/// <summary>
	/// Description of Login.
	/// </summary>
	public partial class Login : Form
	{
		InputBox Password;
		InputBox Username;
		
		public Login()
		{
			InitializeComponent();
			
			// input box is a custom component
			// it handles chaging text colors
			// when label is = to the text in the input box
			Password = new InputBox("Password");
			Username = new InputBox("Username");
			
			Password.SetWidth(350);
			Username.SetWidth(350);
			
			UsernamePanel.Controls.Add(Username);
			PasswordPanel.Controls.Add(Password);
		}
		
		// Verify if the username & password are correct
		void LoginBtnClick(object sender, System.EventArgs e)
		{
			// username & password are in the Config file
			// found in the Models folder
			if(Username.Value == Config.Username && Password.Value == Config.Password){
				Reports reports = new Reports();
        		reports.Show();
        		this.Hide();
			} else {
				MessageBox.Show("Username or password is incorrect ","Warning!",MessageBoxButtons.OK);
				// reset inputs to labels
				Username.SetText("Username");
				Password.SetText("Password");
			}
		}
		
		// Close the application when clicked
		void ExitBtnClick(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
