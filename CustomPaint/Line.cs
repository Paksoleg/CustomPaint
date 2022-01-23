namespace CustomPaint
{
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
}
