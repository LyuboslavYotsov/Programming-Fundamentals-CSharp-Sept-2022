using System;
using System.Linq;
using System.Collections.Generic;

namespace P10SoftUniCoursePlanning
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> courseList = Console.ReadLine()
                .Split(", ")
                .ToList();

            string input;

            while ((input = Console.ReadLine()) != "course start")
            {
                string[] commandArg = input
                    .Split(":")
                    .ToArray();

                string command = commandArg[0];

                if (command == "Add")
                {
                    AddCourseAtEnd(courseList, commandArg);
                }

                else if (command == "Insert")
                {
                    AddCourseAtIndex(courseList, commandArg);
                }

                else if (command == "Remove")
                {
                    RemoveCourse(courseList, commandArg);
                }

                else if (command == "Swap")
                {
                    SwapCourseAtGivenPositions(courseList, commandArg);
                }

                else if (command == "Exercise")
                {
                    AddCourseExercise(courseList, commandArg);
                }
            }

            PrintOrderedCourseList(courseList);
        }

        private static void PrintOrderedCourseList(List<string> courseList)
        {
            for (int i = 0; i < courseList.Count; i++)
            {
                Console.WriteLine($"{i + 1}.{courseList[i]}");
            }
        }

        private static void AddCourseExercise(List<string> courseList, string[] commandArg)
        {
            string title = commandArg[1];
            string excersiseTitle = $"{title}-Exercise";

            if (courseList.Contains(title) && !courseList.Contains($"{title}-Exercise"))
            {
                int titleIndex = 0;
                for (int i = 0; i < courseList.Count; i++)
                {
                    if (courseList[i] == title)
                    {
                        titleIndex = i;
                    }
                }

                courseList.Insert(titleIndex + 1, excersiseTitle);
            }

            else if (!courseList.Contains(title))
            {
                courseList.Add(title);
                courseList.Add(excersiseTitle);
            }
        }

        private static void SwapCourseAtGivenPositions(List<string> courseList, string[] commandArg)
        {
            string firstTitle = commandArg[1];
            string secondTitle = commandArg[2];
            string firstTitleExercise = $"{firstTitle}-Exercise";
            string secondTitleExercise = $"{secondTitle}-Exercise";

            if (courseList.Contains(firstTitle) && courseList.Contains(secondTitle))
            {
                int firstTitleIndex = 0;
                int secondTitleIndex = 0;
                for (int i = 0; i < courseList.Count; i++)
                {
                    if (courseList[i] == firstTitle)
                    {
                        firstTitleIndex = i;
                    }
                    if (courseList[i] == secondTitle)
                    {
                        secondTitleIndex = i;
                    }
                }

                courseList.Insert(firstTitleIndex, secondTitle);
                courseList.RemoveAt(firstTitleIndex + 1);
                courseList.Insert(secondTitleIndex, firstTitle);
                courseList.RemoveAt(secondTitleIndex + 1);

                if (courseList.Contains(secondTitleExercise))
                {
                    courseList.Remove(secondTitleExercise);
                    courseList.Insert(firstTitleIndex + 1, secondTitleExercise);
                }



                if (courseList.Contains(firstTitleExercise))
                {
                    courseList.Remove(firstTitleExercise);
                    courseList.Insert(secondTitleIndex + 1, firstTitleExercise);
                }
            }
        }

        private static void RemoveCourse(List<string> courseList, string[] commandArg)
        {
            string title = commandArg[1];

            if (courseList.Contains(title))
            {
                courseList.Remove(title);
            }
        }

        private static void AddCourseAtIndex(List<string> courseList, string[] commandArg)
        {
            string title = commandArg[1];
            int index = int.Parse(commandArg[2]);

            if (!courseList.Contains(title))
            {
                courseList.Insert(index, title);
            }
        }

        private static void AddCourseAtEnd(List<string> courseList, string[] commandArg)
        {
            string title = commandArg[1];
            if (!courseList.Contains(title))
            {
                courseList.Add(title);
            }
        }
    }
}
