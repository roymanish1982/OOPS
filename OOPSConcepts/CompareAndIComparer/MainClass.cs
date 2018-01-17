using System;
using System.Collections.Generic;

namespace OOPSConcepts.CompareAndIComparer
{
    public class MainClass
    {
        private static List<Person> personList = new List<Person>();

        public static void Processor()
        {
            personList.Add(new Person { Age = 10, Name = "Sagar" });
            personList.Add(new Person { Age = 30, Name = "Manish" });
            personList.Add(new Person { Age = 6, Name = "Amit" });
            personList.Add(new Person { Age = 50, Name = "Deepak" });

            Console.WriteLine($"Default Sort using IComparable");
            personList.Sort();
            Display(personList);

            Console.WriteLine($"Sort by Age Using IComparer");
            personList.Sort(new CompareByAge());
            Display(personList);

            Console.WriteLine($"Sort by Name Using IComparer");
            personList.Sort(new CompareByName());
            Display(personList);
        }

        public static void Display(List<Person> personList)
        {
            personList.ForEach(person =>
            {
                Console.WriteLine($"Name { person.Name }  : Age {person.Age}");
            });
        }
    }

    public class Person : IComparable<Person>
    {
        public string Name { get; set; }

        public int Age { get; set; }

        public int CompareTo(Person personToCompare)
        {
            if (personToCompare.Age != this.Age)
            {
                return personToCompare.Age.CompareTo(this.Age);
            }
            else
            {
                return this.Name.CompareTo(personToCompare.Name);
            }
        }
    }

    public class CompareByName : IComparer<Person>
    {
        public int Compare(Person x, Person y)
        {
            return string.Compare(x.Name, y.Name);
        }
    }

    public class CompareByAge : IComparer<Person>
    {
        public int Compare(Person x, Person y)
        {
            if (x.Age > y.Age) return 1;
            if (x.Age < y.Age) return 0;

            return 0;
        }
    }
}