using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace hometask6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int[] numbers = new int[10];

                for (int i = 0; i < 10; i++)
                {
                    numbers[i] = ReadNumber(1, 100);
                }


                Console.WriteLine("enter numbers you want to devide:");
                int a = ReadNumber(int.MinValue, int.MaxValue);
                int b = ReadNumber(int.MinValue, int.MaxValue);

                Div(a, b);
            }
            catch (FormatException)
            {
                Console.WriteLine("invalid number format entered.");
            }
            catch (ArgumentException)
            {
                Console.WriteLine("invalid number entered.");
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("cannot divide by zero.");
            }
        }

        static void Div(int a, int b)
        {
            if (b == 0)
            {
                throw new DivideByZeroException();
            }

            Console.WriteLine(a / b);
        }

        static int ReadNumber(int start, int end)
        {
            Console.WriteLine($"enter a number between {start} and {end}:");
            int number;

            if (!int.TryParse(Console.ReadLine(), out number))
            {
                throw new FormatException();
            }

            if (number < start || number > end)
            {
                throw new ArgumentException();
            }

            return number;
        }
    }
}
