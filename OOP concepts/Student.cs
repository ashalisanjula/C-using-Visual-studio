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
        public void displayDetails()
        {
            Console.WriteLine("Student Id: " +studentId);
            Console.WriteLine("Student Name: " +studentName);
        }
    }
}
