using System;
using System.Collections.Generic;
using System.Linq;

namespace FeesManagement.Models
{
    public class School
    {
    	public Classes Classes { get; set; }
        
        public Dictionary<int, List<Student> > Students { get; set; }

        public School()
        {
            Classes = new Classes();
            Students = new Dictionary<int,List<Student>>();
        }

        public Student GetStudentDetails(string name, string surname){
        	foreach (var classList in Students.Values) {
                
        	    var StudentResults = classList.SingleOrDefault(s => s.Name == name && s.Surname == surname);
        		
                // find student using name & surname
                if(StudentResults != null){
                	return StudentResults;
                }
        	}
        	return null;
        }
        
        public Student GetStudentDetails(int ID){
        	foreach (var classList in Students.Values) {
                
        		var StudentResults = classList.SingleOrDefault(s => Int32.Parse(s.ID) == ID);
        		
                // find student using name & surname
                if(StudentResults != null){
                	return StudentResults;
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
        
        public bool Enroll(string name,string surname,int classNumber,double fees = 0){
        	Classes _class = new Classes();
        	Student student = new Student();
        	
        	student.Name = name;
        	student.Surname = surname;
   
        	if(fees < 1.0){
        		var rand = new Random(Guid.NewGuid().GetHashCode());
        		fees = rand.NextDouble() * (500 - 100) + 100;
        	}
        	
        	student.FeesBalance = fees;
        	
        	if (!Students.ContainsKey(classNumber)){
        		Students.Add(classNumber, new List<Student>());
        	}
        	
        	if(!StudentExists(name, surname)){
                var classListCount = Students[classNumber].Count + 1;
                
        	    // generate user id
        	    student.ID = PrepareUserID(classListCount.ToString(), classNumber);

                // add to temporary memory db
                Students[classNumber].Add(student);
        	}
        	return true;
        }
        
        public double TotalFees(){
        	double total = 0.0;
        	foreach (var className in Students.Keys) {
        		total += TotalFees(className);
        	}
        	return total;
        }       
        
        public double TotalFees(int className){
        	double total = 0.0;
        	if (!Students.ContainsKey(className)){ return total; }
        	Students[className].ForEach(student => total += student.FeesBalance);
        	return total;
        }
        
        public List<int> GetClasses(){
        	return Students.Keys.ToList();
        }
        
        string PrepareUserID(string id, int className = 0){
	    	if( id.Length == 3 && className != 0) {
	    		return String.Concat(className.ToString(), id);
	    	}
	    	return PrepareUserID( String.Concat("0", id), className );
	    }
    }
}