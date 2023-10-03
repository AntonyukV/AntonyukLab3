using System;
using System.Collections.Generic;

class Point
{
    public double X { get; }
    public double Y { get; }
    public string Name { get; }

    public Point(double x, double y, string name)
    {
        X = x;
        Y = y;
        Name = name;
    }
}

class Figure
{
    private List<Point> points = new List<Point>();

    public Figure(Point p1, Point p2, Point p3)
    {
        points.Add(p1);
        points.Add(p2);
        points.Add(p3);
    }

    public Figure(Point p1, Point p2, Point p3, Point p4)
    {
        points.Add(p1);
        points.Add(p2);
        points.Add(p3);
        points.Add(p4);
    }

    public Figure(Point p1, Point p2, Point p3, Point p4, Point p5)
    {
        points.Add(p1);
        points.Add(p2);
        points.Add(p3);
        points.Add(p4);
        points.Add(p5);
    }

    public double GetSideLength(Point A, Point B)
    {
        return Math.Sqrt(Math.Pow(B.X - A.X, 2) + Math.Pow(B.Y - A.Y, 2));
    }

    public void CalculatePerimeter()
    {
        double perimeter = 0;
        for (int i = 0; i < points.Count; i++)
        {
            int nextIndex = (i + 1) % points.Count;
            perimeter += GetSideLength(points[i], points[nextIndex]);
        }
        Console.WriteLine($"Perimeter of the figure: {perimeter}");
    }
}

class Rectangle
{
    private double side1;
    private double side2;

    public Rectangle(double side1, double side2)
    {
        this.side1 = side1;
        this.side2 = side2;
    }

    public double CalculateArea()
    {
        return side1 * side2;
    }

    public double CalculatePerimeter()
    {
        return 2 * (side1 + side2);
    }

    public double Area => CalculateArea();
    public double Perimeter => CalculatePerimeter();
}

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter the length of side 1 of the rectangle: ");
        double side1 = double.Parse(Console.ReadLine());

        Console.WriteLine("Enter the length of side 2 of the rectangle: ");
        double side2 = double.Parse(Console.ReadLine());

        Rectangle rectangle = new Rectangle(side1, side2);

        Console.WriteLine($"Rectangle Area: {rectangle.Area}");
        Console.WriteLine($"Rectangle Perimeter: {rectangle.Perimeter}");

        Point p1 = new Point(0, 0, "A");
        Point p2 = new Point(0, 4, "B");
        Point p3 = new Point(3, 0, "C");

        Figure figure = new Figure(p1, p2, p3);
        figure.CalculatePerimeter();
    }
}
