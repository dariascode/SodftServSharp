using NUnit.Framework;
using System.IO;
using System;
using _10aUnitTest;

[TestFixture]
    public class TriangleTests
{
    [Test]
    public void Distance_ReturnsCorrectDistance()
    {
        Point p1 = new Point { x = 1, y = 2 };
        Point p2 = new Point { x = 4, y = 6 };
        Triangle triangle = new Triangle(p1, p2, new Point());

        double distance = triangle.Distance(p1, p2);

        Assert.AreEqual(5, distance);
    }

    [Test]
    public void Perimeter_ReturnsCorrectPerimeter()
    {
        Point p1 = new Point { x = 0, y = 0 };
        Point p2 = new Point { x = 3, y = 0 };
        Point p3 = new Point { x = 0, y = 4 };
        Triangle triangle = new Triangle(p1, p2, p3);

        double perimeter = triangle.Perimeter();

        Assert.AreEqual(12, perimeter);
    }

    [Test]
    public void Square_ReturnsCorrectSquare()
    {
        Point p1 = new Point { x = 0, y = 0 };
        Point p2 = new Point { x = 3, y = 0 };
        Point p3 = new Point { x = 0, y = 4 };
        Triangle triangle = new Triangle(p1, p2, p3);

        double square = triangle.Square();

        Assert.AreEqual(6, square);
    }

    [Test]
    public void Print_WritesCorrectOutput()
    {
        Point p1 = new Point { x = 1, y = 2 };
        Point p2 = new Point { x = 3, y = 4 };
        Point p3 = new Point { x = 5, y = 6 };
        Triangle triangle = new Triangle(p1, p2, p3);

        using (StringWriter sw = new StringWriter())
        {
            Console.SetOut(sw);

            triangle.Print();

            string expectedOutput = $"triangle with vertices: {p1}, {p2}, {p3}" + Environment.NewLine +
                                    "perimeter: 10" + Environment.NewLine +
                                    "square: 0" + Environment.NewLine;

            Assert.AreEqual(expectedOutput, sw.ToString());
        }
    }
   
}

