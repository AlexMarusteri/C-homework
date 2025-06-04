using System;

class Exercise18
{
    public class Point
    {
        public double X { get; set; }
        public double Y { get; set; }

        public Point() { }

        public Point(double x, double y)
        {
            X = x;
            Y = y;
        }

        public Point(Point p)
        {
            X = p.X;
            Y = p.Y;
        }

        public void Read()
        {
            Console.Write("Enter X: ");
            X = double.Parse(Console.ReadLine());
            Console.Write("Enter Y: ");
            Y = double.Parse(Console.ReadLine());
        }

        public void Write()
        {
            Console.WriteLine($"Point({X}, {Y})");
        }

        public double DistanceTo(Point other)
        {
            double dx = X - other.X;
            double dy = Y - other.Y;
            return Math.Sqrt(dx * dx + dy * dy);
        }
    }

    public class Triangle
    {
        public Point A { get; set; }
        public Point B { get; set; }
        public Point C { get; set; }

        public Triangle() 
        {
            A = new Point();
            B = new Point();
            C = new Point();
        }

        public Triangle(Point a, Point b, Point c)
        {
            A = new Point(a);
            B = new Point(b);
            C = new Point(c);
        }

        public void Read()
        {
            Console.WriteLine("Enter coordinates for point A:");
            A.Read();
            Console.WriteLine("Enter coordinates for point B:");
            B.Read();
            Console.WriteLine("Enter coordinates for point C:");
            C.Read();
        }

        public void Write()
        {
            Console.WriteLine("Triangle Points:");
            A.Write();
            B.Write();
            C.Write();
        }

        public double Perimeter()
        {
            return A.DistanceTo(B) + B.DistanceTo(C) + C.DistanceTo(A);
        }

        public double Area()
        {
            double a = A.DistanceTo(B);
            double b = B.DistanceTo(C);
            double c = C.DistanceTo(A);
            double s = (a + b + c) / 2;
            return Math.Sqrt(s * (s - a) * (s - b) * (s - c));
        }
    }

    static void Main()
    {
        Triangle triangle = new Triangle();
        triangle.Read();
        triangle.Write();
        Console.WriteLine("Perimeter: " + triangle.Perimeter());
        Console.WriteLine("Area: " + triangle.Area());
    }
}
