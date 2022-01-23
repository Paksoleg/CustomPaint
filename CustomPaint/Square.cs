namespace CustomPaint
{
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
}
