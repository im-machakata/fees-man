using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

using FeesManagement.Utils;
using FeesManagement.Models;

namespace FeesManagement.Views
{
	public partial class Reports : Form
	{
		// We use this to store a school by its class
		// in this format Form 1 > Students
		// eg. Schools["Form 1"] = List of students
		public Dictionary<string,School> Schools { get; set; }

        public Reports()
        {
            InitializeComponent();
            Schools = new Dictionary<string,School>();
            SeedData();
        }

        // find school by name & or create one
        public School FindSchoolByName(string name, bool add = false)
        {
        	var exists = Schools.ContainsKey(name) ? Schools[name] : null;
            if(exists == null && add) {
            	var school = new School();
            	Schools[name] = school;
                return school;
            }
            return exists;
        }

        // we can search a student by their id number
        // but it'd be better if we know their school too & class
        public Student FindStudentById(int id)
        {
        	// loop through all schools
            foreach (var school in Schools)
            {
            	var schoolName = school.Key;
            	var schoolClassesList = Schools[schoolName].GetClasses();
            	
            	// loop through all classes
            	foreach (var _class in schoolClassesList) {
            		
            		// class name
            		var classes = Schools[schoolName].Students[_class];
            		
            		// loop through all students in class
            		foreach (var student in classes) {
            			
            			// find student with that id
	            		if(student.ID == id){
	            			return student;
	            		}
	            	}
            	}
            }
            return null;
        }

        public void AddStudentToClass(Student student, string className)
        {
        	var school = FindSchoolByName(className,true);
            school.EnrollStudent(student.Name, student.Surname, student.ClassName);
        }
        
        void LoadStudents(){
        	// load default students
        }
        
        void LoadClassess(){
        	//
        }
        
        // create dummy data
        void SeedData(){
        	Schools["Shakashe High"] = new School();
        	Schools["Madyangove High"] = new School();
        }
		
		void StudentBalanceBtnClick(object sender, EventArgs e)
		{
			// filter student balance	
			if(Validation.isEmpty(studentClass)){
				MessageBox.Show("Enter a student name","Alert");
			} else if (studentClass.Text.Trim() == "//"){
				MessageBox.Show("Student not found","Ooops");
			} else {
				// calculate balance
				studentBalance.Text = "";
			}
		}
		
		void ClassFilterBtnClick(object sender, EventArgs e)
		{
			// filter class balance			
			if(Validation.isEmpty(className)){
				MessageBox.Show("Enter a class name","Alert");
			} else {
				// calculate balance
			}
		}
		
		void SchoolFilterButtonClick(object sender, EventArgs e)
		{
			// filter school balance		
			if(Validation.isEmpty(schoolName)){
				MessageBox.Show("Enter a class name","Alert");
			} else {
				// calculate balance
			}
		}
	}
}
