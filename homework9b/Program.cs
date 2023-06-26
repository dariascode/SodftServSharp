using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace homework9b
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string filePath = "C:/Univer/WP/homework9b/text.txt";

            string[] lines = File.ReadAllLines(filePath);

            Console.WriteLine("number of symbols in each line:");
            foreach (string line in lines)
            {
                int symbolCount = line.Length;
                Console.WriteLine($"Line '{line}': {symbolCount} symbols");
            }
            Console.WriteLine();

            string longestLine = lines.OrderByDescending(l => l.Length).First();
            string shortestLine = lines.OrderBy(l => l.Length).First();
            Console.WriteLine($"longest line: '{longestLine}'");
            Console.WriteLine($"shortest line: '{shortestLine}'");
            Console.WriteLine();

            Console.WriteLine("lines containing the word 'var':");
            var linesWithVar = lines.Where(line => line.Contains("var"));
            foreach (string line in linesWithVar)
            {
                Console.WriteLine(line);
            }

            Console.ReadLine();
        }
    }
}
