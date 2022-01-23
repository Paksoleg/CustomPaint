namespace CustomPaint
{
    public class User
    {
        public string Name { get; set; }
        public List<Figure> _figures;
        public User(string name)
        {
            Name = name;
            _figures = new List<Figure>();
        }
        public static implicit operator User(string name)
        {
            return new User(name) { Name = name, _figures = new List<Figure>() };
        }
        public void AddFigure(Figure figure)
        {
            _figures.Add(figure);
        }
    }
}
