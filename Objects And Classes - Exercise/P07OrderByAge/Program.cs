using System;
using System.Linq;
using System.Collections.Generic;

namespace P07OrderByAge
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Person> personList = new List<Person>();

            AddPersonInformation(personList);

            PrintPersonInfoOrderedByAge(personList);
        }

        private static void AddPersonInformation(List<Person> personList)
        {
            string input;
            while ((input = Console.ReadLine()) != "End")
            {
                string[] pesonData = input
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string name = pesonData[0];
                string iD = pesonData[1];
                int age = int.Parse(pesonData[2]);
                Person currentPerson = new Person(name, iD, age);

                if (!personList.Any(x => x.ID == iD))
                {
                    personList.Add(currentPerson);
                }
                else
                {
                    foreach (Person peopleInList in personList)
                    {
                        if (peopleInList.ID == currentPerson.ID)
                        {
                            peopleInList.Age = currentPerson.Age;
                            peopleInList.Name = currentPerson.Name;
                        }
                    }
                }
            }
        }

        private static void PrintPersonInfoOrderedByAge(List <Person> personList)
        {
            personList = personList.OrderBy(x => x.Age).ToList();
            foreach (var person in personList)
            {
                Console.WriteLine(person.ToString());
            }
        }
    }

    public class Person
    {
        public Person(string name, string iD, int age)
        {
            Name = name;
            ID = iD;
            Age = age;
        }

        public string Name { get; set; }

        public string ID { get; set; }

        public int Age { get; set; }

        public override string ToString()
        {
            return $"{this.Name} with ID: {this.ID} is {this.Age} years old.";
        }
    }
}
