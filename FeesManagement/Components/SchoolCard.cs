using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace FeesManagement.Components
{
	public partial class SchoolCard : UserControl
	{
		public SchoolCard(string SName)
		{
			InitializeComponent();
			SchoolName.Text = SName;
			SchoolName.ForeColor = Color.Black;
		}
	}
}
