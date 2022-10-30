using System;
using System.Collections.Generic;
using System.Linq;

namespace P04Students
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int studentsCount = int.Parse(Console.ReadLine());
            List<Student> studentsList = new List<Student>();

            for (int i = 0; i < studentsCount; i++)
            {
                string[] input = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string firstName = input[0];
                string lastName = input[1];
                double grade = double.Parse(input[2]);
                Student currStudent = new Student(firstName, lastName, grade);
                studentsList.Add(currStudent);
            }
            List<Student> orderedStudents = studentsList.OrderByDescending(s => s.Grade)
                .ToList();
            foreach (Student student in orderedStudents)
            {
                Console.WriteLine(student.ToString());
            }
        }
    }

    public class Student
    {
        public Student(string firstName, string lastName, double grade)
        {
            FirstName = firstName;
            LastName = lastName;
            Grade = grade;
        }
        public string FirstName { get; private set; }

        public string LastName { get; private set; }

        public double Grade { get; private set; }

        public override string ToString()
        {
            return $"{this.FirstName} {this.LastName}: {this.Grade:F2}";
        }

    }
}
