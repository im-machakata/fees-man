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
        	// do something
        }
        public Classes addClass(int Grade,string Name){
        	ClassList[Grade] = Name;
        	return this;
        }
        public string getClass(int Grade){
       		return ClassList[Grade];
        }
    }
}