using System;
using System.Collections.Generic;
using System.Linq;

namespace FeesManagement.Models
{
    public class School
    {
        public string Name { get; set; }
        public List<Student> Students { get; set; }

        // we will store student id in here
        // we use a dictionary to keep track of 
        // the number of id each class has
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
        	
        	if(!studentExists(student)){
        	    // generate user id
        	    student.ID = generateUID();

                // add to temporary memory db
        		Students.Add(student);
        		StudentIDs.Add(classNumber,_class.getClass(classNumber));
        	}
        	return true;
        }
        int generateUID(int _class){
        	return StudentIDs[_class] .Count();
        }
    }
}