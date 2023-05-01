using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using FeesManagement.Utils;
using FeesManagement.Models;
using FeesManagement.Components;

namespace FeesManagement.Views
{
	public partial class Reports : Form
	{
		// We use this to store a school by its class
		// in this format Form 1 > Students
		// eg. Schools["Form 1"] = List of students
		public Dictionary<string,School> Schools { get; set; }
		
		// define inputs
		InputBox IBStudentName;
		InputBox IBStudentSurname;
		StudentCard IBStudentResults;

        public Reports()
        {
            InitializeComponent();
            Schools = new Dictionary<string,School>();
            
            // initialize inputs
            IBStudentResults = new StudentCard("Name","Surname");
            IBStudentSurname = new InputBox("Student surname");
            IBStudentName = new InputBox("Student name");
            
            // adjust inputs width size
            IBStudentSurname.SetWidth(210);
            IBStudentName.SetWidth(210);
            
            //bind enter key for the first input box
            IBStudentName.FocusBox(IBStudentSurname);
            
            // add to view
           StudentResults1.Controls.Add(IBStudentResults);
           StudentSurname1.Controls.Add(IBStudentSurname);
           StudentName1.Controls.Add(IBStudentName);
           
           SeedData();
        }

        // find school by name & or create one
        public School FindSchool(string name, bool add = false)
        {
        	var exists = Schools.ContainsKey(name) ? Schools[name] : null;
            if(exists == null && add) {
        		exists = CreateSchool(name);
            }
            return exists;
        }
        public School CreateSchool(string name){
        	name = name.Trim();
        	if(!Schools.ContainsKey(name)){
            	Schools[name] = new School();
            }
            return Schools[name];
        }

        public void AddStudent(Student student, string className)
        {
        	var school = FindSchool(className,true);
            school.Enroll(student.Name, student.Surname, student.ClassName);
        }
        
        void LoadStudents(){
        	// load default students
        }
        
        void LoadClassess(){
        	//
        }
        
        // create dummy data
        void SeedData(){
        	
        	// we will use one school for the meantime
        	// but more school can be added this way
        	Schools["Junior High"] = new School();
        	// AddStudent();
        }
		
		void StudentBalanceBtnClick(object sender, EventArgs e)
		{
			var Name = IBStudentName.Value;
			var Surname = IBStudentSurname.Value;
			Response Results = new Response { HasError = true };
			
			// validate
			if(Validation.isEmpty(Name) || IBStudentName.IsLabel()){
				Results.Message = "Enter a student name";
			} else if(Validation.isEmpty(IBStudentName.Value) || IBStudentSurname.IsLabel()){
				Results.Message = "Enter a student surname";
			} else if (!Schools["Junior High"].StudentExists(Name,Surname)) {
				Results.Message = "Student not found.";
			} else {
				Results.HasError = false;
			}
			
			if(Results.HasError){
				MessageBox.Show(Results.Message, "Alert");
			} else {
				
				// get student & display their balance
			}
		}
		
		void ClassFilterBtnClick(object sender, EventArgs e)
		{
			// filter class balance			
			// if(Validation.isEmpty(className)){
			// 	MessageBox.Show("Enter a class name","Alert");
			// } else {
			// 	// calculate balance
			// }
		}
		
		void SchoolFilterButtonClick(object sender, EventArgs e)
		{
			// filter school balance		
			// if(Validation.isEmpty(schoolName)){
			// 	MessageBox.Show("Enter a class name","Alert");
			// } else {
			// 	// calculate balance
			// }
		}
	}
}
