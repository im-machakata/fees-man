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
				return Int16.Parse(
					String.Concat(
						ClassName, 
						prepareUserID(id.ToString())
					)
				);
			}
		}
	    public string Name { get; set; }
	    public int ClassName { get; set; }
	    public decimal FeesBalance { get; set; }
	    
	    string prepareUserID(string id){
	    	if( Int16.Parse(id) > 999) {
	    		return id;
	    	}
	    	return prepareUserID( String.Concat("0", id) );
	    }
	}
}
