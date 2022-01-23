namespace CustomPaint
{
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
}
