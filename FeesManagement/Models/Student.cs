using System;
using System.Linq;
using System.Windows.Forms;

namespace FeesManagement.Models
{
	public class Student
	{
		int id;
		
		public string ID {
			set { id = Int32.Parse(value); }
			get { 
				return PrepareUserID(id.ToString());
			}
		}
	    public string Name { get; set; }
	    public string Surname { get; set; }
	    public int ClassName { get; set; }
	    public double FeesBalance { get; set; }
	    public string Gender { get; set; }
	    
	    string PrepareUserID(string id){
	    	if( id.Length > 3) {
	    		return String.Concat(ClassName.ToString(), id);
	    	}
	    	return PrepareUserID( String.Concat("0", id) );
	    }
	}
}
