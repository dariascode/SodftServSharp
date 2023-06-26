using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10aUnitTest
{
        class Triangle
        {
            public Point vertex1;
            public Point vertex2;
            public Point vertex3;

            public Triangle(Point v1, Point v2, Point v3)
            {
                vertex1 = v1;
                vertex2 = v2;
                vertex3 = v3;
            }

            public double Distance(Point p1, Point p2)
            {
                int dx = p2.x - p1.x;
                int dy = p2.y - p1.y;
                return Math.Sqrt(dx * dx + dy * dy);
            }

            public double Perimeter()
            {
                double distance1 = Distance(vertex1, vertex2);
                double distance2 = Distance(vertex2, vertex3);
                double distance3 = Distance(vertex3, vertex1);
                return distance1 + distance2 + distance3;
            }

            public double Square()
            {
                double distance1 = Distance(vertex1, vertex2);
                double distance2 = Distance(vertex2, vertex3);
                double distance3 = Distance(vertex3, vertex1);
                double p = (distance1 + distance2 + distance3) / 2;
                return Math.Sqrt(p * (p - distance1) * (p - distance2) * (p - distance3));
            }

            public void Print()
            {
                Console.WriteLine($"triangle with points: {vertex1}, {vertex2}, {vertex3}");
                Console.WriteLine($"perimeter: {Perimeter()}");
                Console.WriteLine($"square: {Square()}");
            }
        }
         struct Point
         {
             public int x;
             public int y;

            public override string ToString()
                {
                    return $"({x},{y})";
                }
        }
}

