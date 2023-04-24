using System;
using System.Linq;
using System.Windows.Forms;

namespace FeesManagement.Models
{
	public class Student
	{
		int id;
		
		public int ID {
			set { id = value; }
			get { 
				return Int16.Parse(PrepareUserID(id.ToString()));
			}
		}
	    public string Name { get; set; }
	    public string Surname { get; set; }
	    public int ClassName { get; set; }
	    public decimal FeesBalance { get; set; }
	    
	    string PrepareUserID(string id){
	    	if( id.Length > 999) {
	    		return String.Concat(ClassName, id);
	    	}
	    	return PrepareUserID( String.Concat("0", id) );
	    }
	}
}
