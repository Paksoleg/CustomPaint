namespace CustomPaint
{
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
}
