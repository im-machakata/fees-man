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

        public School FindSchoolByName(string name,bool add)
        {
            var exists = Schools.FirstOrDefault(x => x.Name.Equals(name));
            if(exists == null && add) {
                school = new School { Name = name };
                AddSchool(school);
                return true;
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
        public string CreateStudentID(string className, School school)
        {
        	int occurences = 1;
            foreach (var school in Schools)
            {
                var student = school.Students.Where(x => x.ClassId == id);
                occurences+=student.Count();
            }
            string name = occurences<10?
            return className + occurences.ToString();
        }

        public void AddStudentToClass(Student student, string className)
        {
            var school = FindSchoolByName(className);
            school.Students.Add(student);
        }

        public void UpdateFeesBalance(Student student, decimal balance)
        {
            student.FeesBalance = balance;
        }
        private void seedData(){
            var school = new School { Name = "Harvard High" };
            school1 = new School { Name = "MIT High" };
            school2 = new School { Name = "Shakaesh High" };
            
            AddSchool(school);
            AddSchool(school1);
            AddSchool(school2);
        }
    }
}