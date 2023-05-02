using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace FeesManagement.Models
{
    public class Classes
    {
        private Dictionary<int,string> ClassList { get; set; }

        public Classes()
        {
        	ClassList = new Dictionary<int,string>();
        	Seed();
        }
        public Classes AddClass(int Grade,string Name){
        	ClassList[Grade] = Name;
        	return this;
        }
        public string GetClass(int Grade){
       		return ClassList[Grade];
        }
        void Seed(){
        	AddClass(1, "Form 1");
        	AddClass(2, "Form 2");
        	AddClass(3, "Form 3");
        	AddClass(4, "Form 4");
        	AddClass(5, "Form 5");
        	AddClass(6, "Form 6");
        }
    }
}