
namespace CustomPaint
{
    public class Figure
    {
        public virtual double GetLength()
        {
            return 0;
        }
        public virtual double GetArea()
        {
            return 0;
        }
    }
    public class Point : Figure
    {
        public double X { get; set; }
        public double Y { get; set; }
        public Point(double x, double y)
        {
            X = x;
            Y = y;
        }
    }
    public class Circle : Figure
    {
        private double _radius;
        private const double pi = Math.PI;
        public double Radius { get => _radius; set => _radius = value; }
        public Point Center { get; }
        public Circle(Point point, double radius)
        {
            Center = point;
            Radius = radius;
        }
        public override double GetLength()
        {
            return 2 * pi * Radius;
        }
        public override double GetArea()
        {
            return pi * (Radius * Radius);
        }
    }
    public class Line : Figure
    {
        public Point Start { get; set; }
        public Point End { get; set; }
        public Line(Point start, Point end)
        {
            Start = start;
            End = end;
        }
        public override double GetLength()
        {
            return SetLength(Start, End);
        }
        public static double SetLength(Point start, Point end)
        {
            return Math.Sqrt(Math.Pow((end.X - start.X), 2) + Math.Pow((end.Y - start.Y), 2));
        }
    }
    class Rectangle : Figure
    {
        private Point point1;
        private Point point2;
        private Point point3;
        private Point point4;
        public double First { get; set; }
        public double Second { get; set; }
        public Rectangle(Point point1, Point point2, Point point3, Point point4)
        {
            this.point1 = point1;
            this.point2 = point2;
            this.point3 = point3;
            this.point4 = point4;
        }
        public override double GetLength()
        {
            return 2 * First + 2 * Second;
        }
        public override double GetArea()
        {
            return First * Second;
        }
    }
    public class Ring : Figure
    {
        private double internalRadius;
        private double externalRadius;
        private const double pi = Math.PI;
        public double Radius { get => internalRadius; set => internalRadius = value; }
        public double Radius2 { get => externalRadius; set => externalRadius = value; }
        public Point Point1 { get; }
        public Ring(Point point1, double internalRadius, double externalRadius)
        {
            Point1 = point1;
            this.internalRadius = internalRadius;
            this.externalRadius = externalRadius;
        }

        public override double GetArea()
        {
            double square = pi * ((Radius2 * Radius2) - (Radius * Radius));
            return square;
        }
        public override double GetLength()
        {
            double length = (2 * pi * Radius2) + (2 * pi * Radius);
            return length;
        }
    }
    class Square : Figure
    {
        private double left;
        public double Left { get => left; set => left = value; }
        public Point Point1 { get; }
        public Point Point2 { get; }
        public Point Point3 { get; }
        public Point Point4 { get; }
        public Square(Point point1, Point point2, Point point3, Point point4)
        {
            Point1 = point1;
            Point2 = point2;
            Point3 = point3;
            Point4 = point4;
        }
        public override double GetLength() => Left * 4;
        public override double GetArea() => Left * Left;
    }
    class Triangle : Figure
    {
        public Line AB { get; set; }
        public Line AC { get; set; }
        public Line BC { get; set; }
        public Point Point1 { get; set; }
        public Point Point2 { get; set; }
        public Point Point3 { get; set; }
        public Triangle(Point point1, Point point2, Point point3)
        {
            Point1 = point1;
            Point2 = point2;
            Point3 = point3;
            AB = new Line(Point1, Point2);
            AC = new Line(Point2, Point3);
            BC = new Line(Point3, Point1);
        }
        public override double GetLength()
        {
            return AB.GetLength() + AC.GetLength() + BC.GetLength();
        }
        public override double GetArea()
        {
            double p = (AB.GetLength() + AC.GetLength() + BC.GetLength()) / 2;
            return Math.Sqrt(p * (p - AB.GetLength()) * (p - AC.GetLength()) * (p - BC.GetLength()));
        }
    }
}
