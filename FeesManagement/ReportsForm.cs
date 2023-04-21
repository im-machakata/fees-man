using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using FeesManagement.Models;

namespace FeesManagement
{
    public partial class ReportsForm : Form
    {
        public List<School> Schools { get; set; }

        public ReportsForm()
        {
            InitializeComponent();
            Schools = new List<School>();
            seedData();
        }

        public void AddSchool(School school)
        {
            Schools.Add(school);
        }

        // find schoo by name & or create one
        public School FindSchoolByName(string name,bool add = false)
        {
            var exists = Schools.FirstOrDefault(x => x.Name.Equals(name));
            if(exists == null && add) {
                var school = new School { Name = name };
                AddSchool(school);
                return school;
            }
            return exists;
        }

        public Student FindStudentById(int id)
        {
            foreach (var school in Schools)
            {
                var student = school.Students.FirstOrDefault(x => x.ClassId == id);
                if (student != null)
                {
                    return student;
                }
            }
            return null;
        }
        
        public string CreateStudentID(string className, School school_choice)
        {
        	// find number of stuents in class at school
        	int occurences = 1;
            foreach (var school in Schools)
            {
            	// only fetch data from the mentioned school
            	if(school_choice.Name != school.Name) continue;
            	
            	// count number of students with classID
                var student = school.Students.Where(x => x.Name == className);
                occurences+=student.Count();
            }
            string name = occurences<10?"00":"0";
            name = occurences>90?"":"0";
            return String.Concat(className,name,occurences.ToString());
        }

        public void AddStudentToClass(Student student, string className)
        {
            var school = FindSchoolByName(className,true);
            school.Students.Add(student);
        }

        public void UpdateFeesBalance(Student student, decimal balance)
        {
            student.FeesBalance = balance;
        }
        
        // create dummy data
        private void seedData(){
            var school = new School { Name = "Harvard High" };
            var school1 = new School { Name = "MIT High" };
            var school2 = new School { Name = "Shakaesh High" };
            
            AddSchool(school);
            AddSchool(school1);
            AddSchool(school2);
        }
    }
}