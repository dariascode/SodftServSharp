using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace homework3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
        }

        static void DoTask1()
        {
            Console.WriteLine("Enter string");
            string str = Console.ReadLine();
            int countA = str.Count(c => c == 'a');
            int countO = str.Count(c => c == 'o');
            int countI = str.Count(c => c == 'i');
            int countE = str.Count(c => c == 'e');

            Console.WriteLine("Amount");
            Console.WriteLine($"a: {countA}");
            Console.WriteLine($"o: {countO}");
            Console.WriteLine($"i: {countI}");
            Console.WriteLine($"e: {countE}");
        }

        static void DoTask2()
        {
            Console.WriteLine("enter month number");
            int monthNumber =Convert.ToInt32(Console.ReadLine());

            int days = GetMonth(monthNumber);

            if (days==0)
            {
                Console.WriteLine("enter number between 1 and 12");
            }
            else
            {
                Console.WriteLine($"Number of days {days}");
            }

        }

        static int GetMonth(int monthNumber)
        {
            switch(monthNumber)
            {
                case 1:
                case 3:
                case 5:
                case 7:
                case 8:
                case 10:
                case 12:
                    return 31;
                case 4:  
                case 6:  
                case 9:  
                case 11: 
                    return 30;

                case 2:  
                    return 28;

                default:
                    return 0; 


            }
        }

        static void DoTask3()
        {
            int amount = 10;
            int[] numbers = new int[amount];
            Console.WriteLine("enter 10 numbers");

            for (int i = 0; i < 10; i++)
            {
                
                numbers[i] = Convert.ToInt32(Console.ReadLine());
            }

            int result;
            if (FirstFivePositive(numbers))
            {
                result = SumFirst(numbers);
                Console.WriteLine(result);
            }
            else
            {
                result = ProductLast(numbers);
                Console.WriteLine(result);
            }
        }

        static bool FirstFivePositive(int[] numbers)
        {
            for (int i = 0; i < 5; i++)
            {
                if (numbers[i] <= 0)
                {
                    return false;
                }
            }
            return true;
        }

        static int SumFirst(int[] numbers)
        {
            int sum = 0;
            for (int i = 0; i < 5; i++)
            {
                sum += numbers[i];
            }
            return sum;
        }

        static int ProductLast(int[] numbers)
        {
            int product = 1;
            for (int i = 5; i < 10; i++)
            {
                product *= numbers[i];
            }
            return product;
        }

    }
}
