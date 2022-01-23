namespace CustomPaint
{
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
}
