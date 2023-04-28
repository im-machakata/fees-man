using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace FeesManagement.Components
{
	public partial class StudentCard : UserControl
	{
		public StudentCard(string name, string surname)
		{
			InitializeComponent();	
			studentName.Text = name;
			studentSurname.Text = surname;
		}
	}
}
