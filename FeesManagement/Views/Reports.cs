using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

using FeesManagement.Utils;
using FeesManagement.Models;

namespace FeesManagement.Views
{
	/// <summary>
	/// Description of Reports.
	/// </summary>
	public partial class Reports : Form
	{
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
            foreach (var school in Schools)
            {
            	//
            }
            return null;
        }

        public void AddStudentToClass(Student student, string className)
        {
        	var school = FindSchoolByName(className,true);
            school.EnrollStudent(student.Name, student.Surname, student.ClassName);
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
