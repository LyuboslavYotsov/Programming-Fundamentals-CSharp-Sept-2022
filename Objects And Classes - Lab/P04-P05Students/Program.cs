using System;
using System.Collections.Generic;

namespace P04Students
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List <Student> studentsList = new List<Student>();
            string input;
            while ((input = Console.ReadLine()) != "end")
            {
                string[] inputArr = input
                    .Split();
                string firstName = inputArr[0];
                string lastName = inputArr[1];
                int age = int.Parse(inputArr[2]);
                string homeTown = inputArr[3];

                Student newStudent = new Student (firstName, lastName, age, homeTown);
                bool exist = false;
                foreach (var currStudent in studentsList)
                {
                    if (currStudent.FirstName == newStudent.FirstName
                        && currStudent.LastName == newStudent.LastName)
                    {
                        currStudent.Age = newStudent.Age;
                        currStudent.HomeTown = newStudent.HomeTown;
                        exist = true;
                    }
                }
                if (!exist)
                {
                    studentsList.Add(newStudent);
                }
                
            }
            string cityName = Console.ReadLine();

            foreach (var student in studentsList)
            {
                if (student.HomeTown == cityName)
                {
                    Console.WriteLine($"{student.FirstName} {student.LastName} is {student.Age} years old.");
                }
            }
        }
    }

    public class Student
    {
        public Student(string firstName, string lastName, int age, string homeTown)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            HomeTown = homeTown;
        }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public int Age { get; set; }

        public string HomeTown { get; set; }
    }
}
