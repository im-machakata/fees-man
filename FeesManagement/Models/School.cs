using System;
using System.Collections.Generic;
using System.Linq;

namespace FeesManagement.Models
{
    public class School
    {
        public string Name { get; set; }
        public List<Student> Students { get; set; }
        private Dictionary<int,string> StudentIDs { get; set; }

        public School(string name)
        {
        	Name = name;
            Students = new List<Student>();
            StudentIDs = new Dictionary<int,string>();
        }
        public bool studentExists(Student student){
        	foreach (var element in Students) {
        		if(element == student) {
        			return true;
        		}
        	}
        	return false;
        }
        public bool enrollStudent(string name,string surname,int classNumber){
        	Student student = new Student();
        	Classes _class = new Classes();
        	
        	// add to temporary memory db
        	if(!studentExists(student)){
        		Students.Add(student);
        		StudentIDs.Add(classNumber,_class.getClass(classNumber));
        	}
        	return true;
        }
        
    }
}