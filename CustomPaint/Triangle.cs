namespace CustomPaint
{
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
