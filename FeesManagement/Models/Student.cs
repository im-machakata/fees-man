using System;
using System.Linq;
using System.Windows.Forms;

namespace FeesManagement.Models
{
	public class Student
	{
		public int ID { set; }
	    public string Name { get; set; }
	    public int ClassName { get; set; }
	    public decimal FeesBalance { get; set; }
	    
	    public int getID(){
	    	return Int16.Parse( String.Concat(ClassName, prepareUserID(ID)) );
	    }
	    
	    string prepareUserID(string id){
	    	if( Int16.Parse(id) > 999) {
	    		return id;
	    	}
	    	return prepareUserID( String.Concat("0", id) );
	    }
	}
}
