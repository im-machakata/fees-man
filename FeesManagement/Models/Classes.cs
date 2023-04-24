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
        	// do something
        }
        /**
        public Classes setClass(int Grade,string Name){
        	// if class already exist, remove it so that we can modify it
        	ClassList.ContainsKey(Grade) ? ClassList.Remove(Grade) : null;
        	ClassList.Add(Grade,Name);
        	return this;
        }
        public void getClassName(int Grade){
        	return ClassList.ContainsKey(Grade) ? ClassList.Where(Grade) : null;
        }
        public void getClass(int Grade){
        	return ClassList.ContainsKey(Grade) ? ClassList.Where(Grade) : null;
        }
        **/
    }
}