using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week1_OOP_Exercise.StudentModule
{
    //Class
    public class StudentManager
    {
        //List to hold students
        private List<Student> students = new List<Student>();

        //Method to add student
            public void AddStudent(Student student)
        {
            students.Add(student);
            Console.WriteLine("Stduent added successfully.");
        }

        // Method to remove student by student ID
        public void RemoveStudent(int id)
        {
            //Search for student using student ID.
            var student = students.Find(s => s.StudentID == id);

            if (student != null)
            {
                students.Remove(student);
                Console.WriteLine("Student removed successfully.");
            }
            else
            {
                Console.WriteLine("Student not found.");
            }
        }

        // Method to list all students
        public void ListStudents()
        {
            if (students.Count == 0)
            {
                Console.WriteLine("No students available.");
                return;
            }

            foreach (var student in students)
            {
                Console.WriteLine(student);
            }
        }
    }
}
