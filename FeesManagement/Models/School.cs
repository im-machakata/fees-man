using System;
using System.Collections.Generic;
using System.Linq;

namespace FeesManagement.Models
{
    public class School
    {
        public string Name { get; set; }
        public List<Student> Students { get; set; }
        private List<string> StudentID { get; set; }

        public School()
        {
            Students = new List<Student>();
            StudentID = new List<string>();
        }
        public void enrollStudent(){
        	// enroll
        }
        public void searchStudent(){
        	// search
        }
        
    }
}