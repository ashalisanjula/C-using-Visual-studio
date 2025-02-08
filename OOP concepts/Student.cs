using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_concepts
{
    internal class Student
    {
        //data members
         int studentId;
         string studentName;

        //member functions

        public Student()
        {
            studentId = 101;
            studentName = "Anonymous";
        }

        public Student(int sId, string sName)
        {
            studentId = sId;
            studentName = sName;
        }

        //public void acceptDetails()
        //{
        //    Console.Write("Enter Student Id : ");
        //    studentId = int.Parse(Console.ReadLine());
        //    Console.Write("Enter Student Name : ");
        //    studentName = Console.ReadLine();

        //}

        //Default Constructors


        public void displayDetails()
        {
            Console.WriteLine("Student Id: " +studentId);
            Console.WriteLine("Student Name: " +studentName);
        }
    }
}
