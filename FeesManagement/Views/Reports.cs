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
		InputBox IBS_School;
		SchoolCard School_Card;
		InputBox IBClassName;
		InputBox IBClassSchool;
		InputBox IBStudentName;
		InputBox IBStudentSurname;
		InputBox IBStudentSchool;
		StudentCard IBStudentResults;

		public Reports()
		{
			InitializeComponent();
			Schools = new Dictionary<string,School>();
			SetupStudentView();
			SetupSchoolView();
			SetupClassView();
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

		public void AddStudent(string name, string surname, int className,string schoolName,double fees = 0)
		{
			var school = FindSchool(schoolName,true);
			school.Enroll(name, surname, className, fees);
		}
		
		void LoadSchools(){
			CreateSchool("Junior High");
		}
		
		void LoadStudents(){
			AddStudent("Mary","Doe",1,"Junior High");
			AddStudent("John","Doe",1,"Junior High",200);
		}
		
		// create dummy data
		void SeedData(){
			LoadSchools();
			LoadStudents();
		}
		
		void SetupStudentView(){
			// initialize inputs
			IBStudentResults = new StudentCard("Name","Surname");
			IBStudentSurname = new InputBox("Student surname");
			IBStudentName = new InputBox("Student name");
			IBStudentSchool = new InputBox("School");
			
			// adjust inputs width size
			IBStudentSurname.SetWidth(210);
			IBStudentName.SetWidth(210);
			IBStudentSchool.SetWidth(210);
			
			// config view 
			IBStudentSchool.FocusBox(IBStudentName);
			IBStudentName.FocusBox(IBStudentSurname);
			
			IBStudentSchool.EnableInput(false);
			IBStudentSchool.SetText("Junior High");

			// add to view
			StudentSchool1.Controls.Add(IBStudentSchool);
			StudentResults1.Controls.Add(IBStudentResults);
			StudentSurname1.Controls.Add(IBStudentSurname);
			StudentName1.Controls.Add(IBStudentName);
		}
		
		void SetupClassView(){
			// initialize inputs
			IBClassName = new InputBox("Class");
			IBClassSchool = new InputBox("School");
			
			// adjust inputs width size
			IBClassName.SetWidth(210);
			IBClassSchool.SetWidth(210);
			
			// config view 
			IBClassSchool.FocusBox(IBClassName);
			
			IBClassSchool.EnableInput(false);
			IBClassSchool.SetText("Junior High");

			// add to view
			ClassFilterSchool.Controls.Add(IBClassSchool);
			ClassFilterClass.Controls.Add(IBClassName);
		}
		
		void SetupSchoolView(){
			// school view setup
			// initialize inputs
			IBS_School = new InputBox("School");
			School_Card = new SchoolCard("School");
			
			// adjust inputs width size
			IBS_School.SetWidth(210);
			
			// config view 
			IBS_School.FocusBox(IBClassName);
			
			IBS_School.EnableInput(false);
			IBS_School.SetText("Junior High");

			// add to view
			SchoolFilterSchool.Controls.Add(IBS_School);
			School_Card_Container.Controls.Add(School_Card);
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
				var rand = new Random();
				var Balance = Schools["Junior High"].GetStudentDetails(Name, Surname).FeesBalance;
				Results.Message = "$" + Balance.ToString("F2");
			}
			
			if(Results.HasError){
				MessageBox.Show(Results.Message, "Alert");
			} else {
				StudentBalance.Text = Results.Message;
				IBStudentResults.SetData(Name, Surname);
			}
		}
		
		void SchoolFilterButtonClick(object sender, EventArgs e)
		{
			var Balance = Schools["Junior High"].TotalFees();
			SchoolTotal.Text = "$" + Balance.ToString("F2");		
		}
	}
}
