using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person[] people = new Person[6];

            for (int i = 0; i < 6; i++)
            {
                Console.WriteLine($"enter details for person {i + 1}:");
                people[i] = new Person();
                people[i].Input();
            }

            Console.WriteLine();
            Console.WriteLine("name and age of each person:");

            foreach (Person person in people)
            {
                Console.WriteLine($"name: {person.Name}, age: {person.Age()}");
            }

            Console.WriteLine();

            foreach (Person person in people)
            {
                if (person.Age() < 16)
                {
                    person.ChangeName("very young");
                }
            }

            Console.WriteLine("information about all persons:");

            foreach (Person person in people)
            {
                person.Output();
            }

            Console.WriteLine();
            Console.WriteLine("persons with the same names:");

            for (int i = 0; i < people.Length - 1; i++)
            {
                for (int j = i + 1; j < people.Length; j++)
                {
                    if (people[i] == people[j])
                    {
                        Console.WriteLine($"Person {i + 1} and Person {j + 1}");
                    }
                }
            }
        }
    }

    }

    class Person
    {
        private string name;
        private DateTime birthYear;

        public string Name
        {
            get { return name; }
        }

        public DateTime BirthYear
        {
            get { return birthYear; }
        }

        public Person()
        {
            
        }

        public Person(string name, DateTime birthYear)
        {
            this.name = name;
            this.birthYear = birthYear;
        }

        public int Age()
        {
            DateTime currentDate = DateTime.Now;
            int age = currentDate.Year - birthYear.Year;
            if (currentDate.Month < birthYear.Month || (currentDate.Month == birthYear.Month && currentDate.Day < birthYear.Day))
            {
                age--;
            }
            return age;
        }

        public void Input()
        {
            Console.Write("enter name: ");
            name = Console.ReadLine();

            Console.Write("enter birth year: ");
            int year;
            while (!int.TryParse(Console.ReadLine(), out year) || year > DateTime.Now.Year)
            {
                Console.WriteLine("invalid year");
                Console.Write("enter birth year: ");
            }
            birthYear = new DateTime(year, 1, 1);
        }

        public void ChangeName(string newName)
        {
            name = newName;
        }

        public override string ToString()
        {
            return $"name: {name}, birth year: {birthYear.Year}";
        }

        public void Output()
        {
            Console.WriteLine(ToString());
        }

        public static bool operator ==(Person person1, Person person2)
        {
            if (ReferenceEquals(person1, person2))
            {
                return true;
            }

            if (person1 is null || person2 is null)
            {
                return false;
            }

            return person1.name == person2.name;
        }

        public static bool operator !=(Person person1, Person person2)
        {
            return !(person1 == person2);
        }
    }

    

