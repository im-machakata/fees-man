using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace FeesManagement.Models
{
    public class School
    {
        public string Name { get; set; }
        public List<Student> Students { get; set; }

        public School()
        {
            Students = new List<Student>();
        }
    }
}