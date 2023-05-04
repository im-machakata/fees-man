using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using FeesManagement.Models;

namespace FeesManagement.Components
{
	public partial class StudentCard : UserControl
	{		
		public StudentCard(string Name, string Surname)
		{
			InitializeComponent();
			// set text
			StudentName.Text = Name;
			StudentSurname.Text = Surname;
			
			// set text color
			// it's white because of the 
			// forecolor set on the parent
			StudentName.ForeColor = Color.Black;
			StudentSurname.ForeColor = Color.Black;
			SchoolId.ForeColor = Color.Black;
			ClassName.ForeColor = Color.Black;
		}
		public void SetText(Student user){
			Classes userClass = new Classes();
			StudentName.Text = user.Name;
			StudentSurname.Text = user.Surname;
			ClassName.Text = userClass.GetClass(user.ClassName);
			SchoolId.Text = "#" + user.ID.ToString();
		}
	}
}
