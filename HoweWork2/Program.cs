using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting;
using System.Text;
using System.Threading.Tasks;

namespace hometask2
{
    internal class Program
    {
      
        static void Main(string[] args)
        {
            DoAdditionalTask2();
        }

        static void DoTask1()
        {

            Console.WriteLine("Write  3 Numbers");
            int amountNumber = 3;

            for (int i = 0; i < amountNumber; i++)
            {
                string number = Console.ReadLine();
                float convertedNumber;


                if (!float.TryParse(number, out convertedNumber))
                {
                    Console.WriteLine("Write number");
                }

                else
                {
                    if (convertedNumber >= -5 && convertedNumber <= 5)
                    {
                        Console.WriteLine("in the range");
                    }

                    else
                    {
                        Console.WriteLine("not in the range");
                    }
                }


            }

        }

        static void DoTask2()
        {
            Console.WriteLine("Write 3 integer numbers");

            int[] numbers = new int[3];

            for (int i = 0; i < numbers.Length; i++)
            {

                numbers[i] = Convert.ToInt32(Console.ReadLine());
            }

            int minNumber = numbers[0];
            int maxNumber = numbers[0];

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] < minNumber)
                {
                    minNumber = numbers[i];
                }

                else if (numbers[i] > maxNumber)
                {
                    maxNumber = numbers[i];
                }
            }

            Console.WriteLine();
            Console.WriteLine(minNumber);
            Console.WriteLine(maxNumber);

        }

        enum HTTPError
        {
            BadRequest = 400,
            Unauthorized = 401,
            PaymentRequired = 402,
            Forbidden = 403,
            NotFound = 404,
        }

        static void DoTask3()
        {
            Console.WriteLine("Select error's code:400, 401, 402, 403, 404");
            int errorCode = Convert.ToInt32(Console.ReadLine());
            string errorName = Enum.GetName(typeof(HTTPError), errorCode);

            Console.WriteLine(errorName);

        }

        struct Dog
        {
            public string name;
            public int age;
            public string mark;

            public override string ToString()
            {
                return string.Format("The dog called {0} it is {1} and it's mark is {2}", name, age, mark);
            }
        }

        static void DoTask4()
        {
            Dog dog;
            Console.WriteLine("enter dogs name");

            dog.name = Console.ReadLine();
            Console.WriteLine("enter dogs age");
            dog.age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("enter dogs mark");
            dog.mark = Console.ReadLine();


            Console.WriteLine(dog);
            Console.ReadLine();

        }

        struct Student
        {
            public string lastName;
            public int groupNumber;
        }

        static void DoAdditionalTask1()
        {
            Console.WriteLine("write amount of students");

            int studentAmount = Convert.ToInt32(Console.ReadLine());
            Student[] students = new Student[studentAmount];

            Console.WriteLine("Write group number and then last name");

            for (int i = 0; i < studentAmount; i++)
            {
                students[i] = new Student { groupNumber = Convert.ToInt32(Console.ReadLine()), lastName = Console.ReadLine() };
            }

            Console.WriteLine("Write number of the group");
            int number = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Write letter");
            char letter = Console.ReadLine()[0];

            foreach (Student student in students)
            {
                if (student.groupNumber == number && student.lastName.StartsWith(letter.ToString(), StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine(student.lastName);
                }

            }

        }
       

        enum Food
        {
            Fish,
            Mouse,
            Meat
        }
        class Cat
        {
            private int fullnessLevel;

            public Cat()
            {
                fullnessLevel = 0;
            }

            public int FullnessLevel
            {
                get { return fullnessLevel; }
                set { fullnessLevel = value; }
            }

            public void EatSomething(Food food)
            {
                switch (food)
                {
                    case Food.Fish:
                        FullnessLevel += 5;
                        break;

                    case Food.Mouse:
                        FullnessLevel += 3;
                        break;

                    case Food.Meat:
                        FullnessLevel += 6;
                        break;

                    default:
                        Console.WriteLine("error");
                        break;
                }
            }
           
        }
        
        static void DoAdditionalTask2()
        {

            Cat cat = new Cat();

            cat.EatSomething(Food.Fish);
            cat.EatSomething(Food.Mouse);
            cat.EatSomething(Food.Meat);

            Console.WriteLine(cat.FullnessLevel);

        }

    }

}