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
			// TODO
			if(Validation.isEmpty(IBStudentSurname.Value)){
				MessageBox.Show("Enter a student surname","Alert");
				
				// TODO
			} else if(Validation.isEmpty(IBStudentName.Value)){
				MessageBox.Show("Enter a student name","Alert");
				
				// TODO
			} else {
				// calculate balance
				// studentBalance.Text = "";
			}
		}
		
		void ClassFilterBtnClick(object sender, EventArgs e)
		{
			// filter class balance			
//			if(Validation.isEmpty(className)){
//				MessageBox.Show("Enter a class name","Alert");
//			} else {
//				// calculate balance
//			}
		}
		
		void SchoolFilterButtonClick(object sender, EventArgs e)
		{
			// filter school balance		
//			if(Validation.isEmpty(schoolName)){
//				MessageBox.Show("Enter a class name","Alert");
//			} else {
//				// calculate balance
//			}
		}
	}
}
