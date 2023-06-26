using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework10a
{
    class Program
    {
        static void Main()
        {
            List<Triangle> triangles = new List<Triangle>();

            Point p1 = new Point { x = 3, y = 2 };
            Point p2 = new Point { x = 3, y = 0 };
            Point p3 = new Point { x = 8, y = 6 };
            Triangle triangle1 = new Triangle(p1, p2, p3);
            triangles.Add(triangle1);

            Point p4 = new Point { x = -1, y = 0 };
            Point p5 = new Point { x = -3, y = -4 };
            Point p6 = new Point { x = -3, y = -1 };
            Triangle triangle2 = new Triangle(p4, p5, p6);
            triangles.Add(triangle2);

            Point p7 = new Point { x = 2, y = 3 };
            Point p8 = new Point { x = 1, y = 5 };
            Point p9 = new Point { x = 7, y = 0 };
            Triangle triangle3 = new Triangle(p7, p8, p9);
            triangles.Add(triangle3);

            Triangle closestToOrigin = triangles[0];
            double closestDistance = closestToOrigin.Distance(new Point { x = 0, y = 0 }, closestToOrigin.vertex1);

            foreach (var triangle in triangles)
            {
                double distance = triangle.Distance(new Point { x = 0, y = 0 }, triangle.vertex1);
                if (distance < closestDistance)
                {
                    closestDistance = distance;
                    closestToOrigin = triangle;
                }
            }

            Console.WriteLine("triangles:");
            foreach (var triangle in triangles)
            {
                triangle.Print();
                Console.WriteLine();
            }

            Console.WriteLine("triangle closest to the origin:");
            closestToOrigin.Print();
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