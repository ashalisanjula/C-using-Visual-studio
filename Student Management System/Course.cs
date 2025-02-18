using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_Management_System
{
    internal class Course
    {
        public string CourseName { get; set; }
        public string CourseCode { get; set; }

        public Course(string name, string code)
        {
            CourseName = name;
            CourseCode = code;
        }

        public override string ToString()
        {
            return $"{CourseCode}: {CourseName}";


        }
    }
}
