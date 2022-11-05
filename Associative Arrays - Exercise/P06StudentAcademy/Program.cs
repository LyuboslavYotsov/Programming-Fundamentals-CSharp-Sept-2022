using System;
using System.Collections.Generic;
using System.Linq;
namespace P06StudentAcademy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, List<double>> studentGrades = new Dictionary<string, List<double>>();

            for (int i = 0; i < n; i++)
            {
                string studentName = Console.ReadLine();
                double grade = double.Parse(Console.ReadLine());

                if (!studentGrades.ContainsKey(studentName))
                {
                    studentGrades[studentName] = new List<double>();
                }
                studentGrades[studentName].Add(grade);
            }
            Dictionary<string, List<double>> studentsAverage = studentGrades
                .Where(x => x.Value.Average() >= 4.50)
                .ToDictionary(s => s.Key, s => s.Value);

            foreach (var student in studentsAverage)
            {
                Console.WriteLine($"{student.Key} -> {student.Value.Average():f2}");
            }

        }
    }
}
