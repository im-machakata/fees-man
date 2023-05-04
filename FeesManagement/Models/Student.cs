using System;
using System.Linq;
using System.Windows.Forms;

namespace FeesManagement.Models
{
	public class Student
	{
		public string ID { get; set; }
	    public string Name { get; set; }
	    public string Surname { get; set; }
	    public int ClassName { get; set; }
	    public double FeesBalance { get; set; }
	    public string Gender { get; set; }
	}
}
