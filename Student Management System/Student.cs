using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_Management_System
{
    internal class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Course> courses = new List<Course>();


        public Student(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public void EnrollInCourse(Course course)
        {
            courses.Add(course);
            Console.WriteLine($"{Name} enrolled in {course.CourseName}");
        }

        public void DisplayStudentInfo()
        {
            Console.WriteLine($"Student ID: {Id}, Name: {Name}");
            Console.WriteLine("Enrolled Courses:");
            foreach (var course in courses)
            {
                Console.WriteLine(" - " + course);
            }
        }
    }
}
