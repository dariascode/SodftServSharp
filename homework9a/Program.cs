using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework9a
{
    internal class Program
    {
            static void Main(string[] args)
            {
                List<Shape> shapes = new List<Shape>();

                shapes.Add(new Circle("circle1", 3));
                shapes.Add(new Circle("circle2", 8));
                shapes.Add(new Circle("circle3", 9));
                shapes.Add(new Square("square1", 4));
                shapes.Add(new Square("square2", 0.5));
                shapes.Add(new Square("square3", 6));

                var filteredByArea = shapes.Where(shape => shape.Area() >= 10 && shape.Area() <= 100);
                WriteShapesToFile(filteredByArea, "shapesByArea.txt");

                var filteredByName = shapes.Where(shape => shape.Name.Contains('a'));
                WriteShapesToFile(filteredByName, "shapesByName.txt");

                shapes.RemoveAll(shape => shape.Perimeter() < 5);
                Console.WriteLine("Shapes with perimeter >= 5:");
                foreach (Shape shape in shapes)
                {
                    Console.WriteLine($"Name: {shape.Name}");
                    Console.WriteLine($"Area: {shape.Area()}");
                    Console.WriteLine($"Perimeter: {shape.Perimeter()}");
                    Console.WriteLine();
                }
            }

            static void WriteShapesToFile(IEnumerable<Shape> shapes, string filename)
            {
                using (StreamWriter writer = new StreamWriter("C:/Univer/WP/homework9a/shapesByName.txt"))
                {
                    foreach (Shape shape in shapes)
                    {
                        writer.WriteLine($"name: {shape.Name}");
                        writer.WriteLine($"area: {shape.Area()}");
                        writer.WriteLine($"perimeter: {shape.Perimeter()}");
                        writer.WriteLine();
                    }
                }
            }
        }
    }

    

