using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<IDeveloper> developers = new List<IDeveloper>();

            developers.Add(new Programmer { Tool = "VS", Language = "C#" });
            developers.Add(new Builder { Tool = "Axe" });
            developers.Add(new Programmer { Tool = "Sublime Text", Language = "Python" });
            developers.Add(new Builder { Tool = "Hammer" });

            foreach (var developer in developers)
            {
                developer.Create();
                developer.Destroy();
                Console.WriteLine();
            }

            developers.Sort();

            foreach (var developer in developers)
            {
                Console.WriteLine($"Tool: {developer.Tool}, Language: {developer.GetType().Name}");
            }
        }
    }

    interface IDeveloper : IComparable<IDeveloper>
    {
        void Create();
        void Destroy();
        string Tool { get; set; }
    }

    class Programmer : IDeveloper
    {
        public string Tool { get; set; }
        public string Language { get; set; }

        public int CompareTo(IDeveloper other)
        {
            if (other is Programmer otherProgrammer)
            {
                return this.Language.CompareTo(otherProgrammer.Language);
            }

            return 0;
        }

        public void Create()
        {
            Console.WriteLine($"I'm a programmer and I'm creating something with {Tool} and {Language}");
        }

        public void Destroy()
        {
            Console.WriteLine($"I'm a programmer and I'm destroying something with {Tool} and {Language}");
        }
    }

    class Builder : IDeveloper
    {
        public string Tool { get; set; }

        public int CompareTo(IDeveloper other)
        {
            if (other is Builder otherBuilder)
            {
                return this.Tool.CompareTo(otherBuilder.Tool);
            }

            return 0;
        }

        public void Create()
        {
            Console.WriteLine($"I'm a builder and I'm creating something with {Tool}");
        }

        public void Destroy()
        {
            Console.WriteLine($"I'm a builder and I'm destroying something with {Tool}");
        }
    }
}

