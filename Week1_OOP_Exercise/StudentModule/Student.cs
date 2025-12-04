
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week1_OOP_Exercise.StudentModule
{
    //Class representing a student
    public class Student
    {
        // Properties
        public int StudentID { get; set; }
        public string StudentName { get; set; }

        public Student(int studentID, string studentName)
        {
            StudentID = studentID;
            StudentName = studentName;
        }

        // Method override ToString for easy display.
        public override string ToString()
        {
            return $"ID: {StudentID}, Name: {StudentName}";
        }
    }
}
