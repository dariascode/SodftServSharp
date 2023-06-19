using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Shape> shapes = new List<Shape>();

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"Enter the details of Shape {i + 1}:");
                Console.Write("Name: ");
                string name = Console.ReadLine();

                Console.WriteLine("Choose the type of shape (1 - Circle, 2 - Square):");
                int shapeType = Convert.ToInt32(Console.ReadLine());

                switch (shapeType)
                {
                    case 1:
                        Console.Write("Enter the radius: ");
                        double radius = Convert.ToDouble(Console.ReadLine());
                        shapes.Add(new Circle(name, radius));
                        break;
                    case 2:
                        Console.Write("Enter the side length: ");
                        double side = Convert.ToDouble(Console.ReadLine());
                        shapes.Add(new Square(name, side));
                        break;
                    default:
                        Console.WriteLine("Invalid shape type.");
                        break;
                }
            }

            Console.WriteLine("\nShapes:");
            foreach (Shape shape in shapes)
            {
                Console.WriteLine($"Name: {shape.Name}");
                Console.WriteLine($"Area: {shape.Area()}");
                Console.WriteLine($"Perimeter: {shape.Perimeter()}");
                Console.WriteLine();
            }

            double largestPerimeter = double.MinValue;
            string shapeWithLargestPerimeter = "";

            foreach (Shape shape in shapes)
            {
                if (shape.Perimeter() > largestPerimeter)
                {
                    largestPerimeter = shape.Perimeter();
                    shapeWithLargestPerimeter = shape.Name;
                }
            }

            Console.WriteLine($"Shape with the largest perimeter: {shapeWithLargestPerimeter}");

            shapes.Sort(new ShapeComparer());

            Console.WriteLine("\nShapes sorted by area:");
            foreach (Shape shape in shapes)
            {
                Console.WriteLine($"Name: {shape.Name}");
                Console.WriteLine($"Area: {shape.Area()}");
                Console.WriteLine($"Perimeter: {shape.Perimeter()}");
                Console.WriteLine();
            }
        }
    }

    class ShapeComparer : IComparer<Shape>
    {
        public int Compare(Shape x, Shape y)
        {
            if (x.Area() < y.Area())
                return -1;
            else if (x.Area() > y.Area())
                return 1;
            else
                return 0;
        }
    }
}
    

