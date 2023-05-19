using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hometaskHukallo
{
    internal class Program
    {


        static void Main(string[] args)
        {
            
        }

        static void Task1()
        {
            Console.WriteLine("select side of a square");
            string a =Console.ReadLine();
            int side;
            
            if (!int.TryParse(a, out side))
            {
                Console.WriteLine("Write ingerer");

            }

            else
            {
                int area = side * side;
                int perimeter = side * 4;
                Console.WriteLine("Area:" + area + " " + "Perimeter:" + perimeter);
            }
            
        }

        static void Task2()
        {
            Console.WriteLine("What is your name?");
            string name = Console.ReadLine();
            Console.WriteLine("How old are you," + name +"?");
            string age = Console.ReadLine();
            int age1;
            if (!int.TryParse(age, out age1))
            {
                Console.WriteLine("Please, write integer");
            }

            else
            {
                Console.WriteLine(name + " " + age);
            }
            
        }

        static void Task3()
        {
            Console.WriteLine("Write radius");
            string radius = Console.ReadLine();
            double r;
            if (!double.TryParse(radius, out r))
            {
                Console.WriteLine("Write number");
            }

            else
            {
                double length = 2 * Math.PI * r;
                Console.WriteLine("Length:" + length);
                double area = Math.PI * r * r;
                Console.WriteLine("Area:" + area);
                double volume = 4 / 3 * Math.PI * r * r;
                Console.WriteLine("Volume:" + volume);
            }
       
        }
        
    }
}
