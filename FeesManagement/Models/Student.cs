using System;
using System.Windows.Forms;

namespace FeesManagement.Models
{
	public class Student
	{
		public int ID {get; set;}
	    public string Name { get; set; }
	    public int ClassId { get; set; }
	    public decimal FeesBalance { get; set; }
	}
}
