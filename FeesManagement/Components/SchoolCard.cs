using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace FeesManagement.Components
{
	public partial class SchoolCard : UserControl
	{
		public SchoolCard(string SchoolName)
		{
			InitializeComponent();
			Name.Text = SchoolName;
			Name.ForeColor = Color.Black;
		}
	}
}
