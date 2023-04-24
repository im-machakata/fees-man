/*
 * Created by SharpDevelop.
 * User: Caasi
 * Date: 4/24/2023
 * Time: 3:37 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace FeesManagement.Components
{
	/// <summary>
	/// Description of CustomInput.
	/// </summary>
	public partial class CustomInput : UserControl
	{
		string value;
		
		public string Value {
			get { return CInput.Text.Trim(); }
		}
		public CustomInput(string Label)
		{
			InitializeComponent();
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			ILabel.Text = Label;
		}
		
		void CInputKeyDown(object sender, KeyEventArgs e)
		{
			value = CInput.Text.Trim();
		}
	}
}
