using Student_Management_System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Program stated!!");

        Course course1 = new Course("Mathematics", "MATH101");
        Course course2 = new Course("Computer Science", "CS101");

        // Step 5: Create Student Object
        Student student1 = new Student(1, "Ashali Samaraweera");

        // Step 6: Enroll Student in Courses
        student1.EnrollInCourse(course1);
        student1.EnrollInCourse(course2);

        // Step 7: Display Student Details
        student1.DisplayStudentInfo();

    }
}
