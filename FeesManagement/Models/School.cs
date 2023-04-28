using System;
using System.Collections.Generic;
using System.Linq;

namespace FeesManagement.Models
{
    public class School
    {
    	public Dictionary<string,List<Student>> Students { get; set; }
        public Classes Classes { get; set; }

        // we will store student id in here
        // we use a dictionary to keep track of 
        // the number of id each class has
        private Dictionary<int,string> StudentIDs { get; set; }

        public School()
        {
            Classes = new Classes();
            Students = new Dictionary<string,List<Student>>();
            StudentIDs = new Dictionary<int,string>();
        }

        public bool StudentExists(string name, string surname){
        	foreach (var className in Students.Keys) {
        		
        		// get class list
        		var classList = Students[className]; 
        		
                // find student using name & surname
        		foreach(var student in classList){

                    if(student.Name == name && student.Surname == surname) {
        			    return true;
        		    }
                }
        	}
        	return false;
        }
        public bool EnrollStudent(string name,string surname,int classNumber){
        	Student student = new Student();
        	Classes _class = new Classes();
        	
        	if(!StudentExists(name,surname)){
        	    // generate user id
        	    student.ID = GenerateUID(classNumber);

                // add to temporary memory db
                Students[classNumber.ToString()].Add(student);
        		StudentIDs.Add(classNumber,_class.getClass(classNumber));
        	}
        	return true;
        }
        
        public List<string> GetClasses(){
        	return Students.Keys.ToList();
        }
        
        int GenerateUID(int _class){
        	return StudentIDs[_class] .Count();
        }
    }
}