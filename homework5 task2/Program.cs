using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace homework5task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<uint, string> persons = new Dictionary<uint, string>();

            Console.WriteLine("enter id and name");

            for (int i = 0; i < 7; i++)
            {
                uint id = uint.Parse(Console.ReadLine());
                string name = Console.ReadLine();

                persons.Add(id, name);
            }
            
            Console.WriteLine("enter id");
            uint enteredID = uint.Parse(Console.ReadLine());

            if (persons.ContainsKey(enteredID))
            {
                string name = persons[enteredID];
                Console.WriteLine(name);
            }

            else
            {
                Console.WriteLine("not found");
            }

        }
    }
}
