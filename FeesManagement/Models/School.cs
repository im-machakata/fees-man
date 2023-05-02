using System;
using System.Collections.Generic;
using System.Linq;

namespace FeesManagement.Models
{
    public class School
    {
    	public Classes Classes { get; set; }
    	
        // we will store student id in here
        // we use a dictionary to keep track of 
        // the number of id each class has
        private Dictionary<int,string> StudentIDs { get; set; }
        
        public Dictionary<int, List<Student> > Students { get; set; }

        public School()
        {
            Classes = new Classes();
            Students = new Dictionary<int,List<Student>>();
            StudentIDs = new Dictionary<int,string>();
        }

        public Student GetStudentDetails(string name, string surname){
        	foreach (var classList in Students.Values) {
        		
                // find student using name & surname
        		foreach(var student in classList){

                    if(student.Name == name && student.Surname == surname) {
        			    return student;
        		    }
                }
        	}
        	return null;
        }
        
        public Student GetStudentDetails(int ID){
        	foreach (var classList in Students.Values) {
        		
                // find student using name & surname
        		foreach(var student in classList){

                    if(student.ID == ID) {
        			    return student;
        		    }
                }
        	}
        	return null;
        }
        
        public bool StudentExists(string name, string surname){
        	return GetStudentDetails(name,surname) != null;
        }

        public bool StudentExists(int ID){
        	return GetStudentDetails(ID) != null;
        }
        
        public bool Enroll(string name,string surname,int classNumber){
        	Classes _class = new Classes();
        	Student student = new Student();
        	
        	student.Name = name;
        	student.Surname = surname;
        	
        	if (!Students.ContainsKey(classNumber)){
        		Students[classNumber] = new List<Student>();
        	}
        	
        	if(!StudentExists(name,surname)){
        	    // generate user id
        	    student.ID = UID(classNumber);

                // add to temporary memory db
                Students[classNumber].Add(student);
        		StudentIDs.Add(classNumber,_class.GetClass(classNumber));
        	}
        	return true;
        }
        
        public List<int> GetClasses(){
        	return Students.Keys.ToList();
        }
        
        int UID(int _class){
        	return StudentIDs.ContainsKey(_class) ? StudentIDs[_class].Count() : 1;
        }
    }
}