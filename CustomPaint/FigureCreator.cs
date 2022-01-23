
namespace CustomPaint
{
    public class FigureCreator
    {
        private List<User> users = new List<User>();
        private static User user;
        public static Point Input(string name)
        {
            Console.Write($"{Environment.NewLine}{name} :" +
                $"{Environment.NewLine}X: ");
            double.TryParse(Console.ReadLine(), out double x);
            Console.Write("Y: ");
            double.TryParse(Console.ReadLine(), out double y);
            return new Point(x, y);
        }
        public void GetAuthorised()
        {
            Console.Clear();
            Console.WriteLine("Введите имя: ");
            string name = Console.ReadLine();
            if (users.Contains(name))
#pragma warning disable CS8601 // Возможно, назначение-ссылка, допускающее значение NULL.
                user = users.Find(x => x.Name == name);
#pragma warning restore CS8601 // Возможно, назначение-ссылка, допускающее значение NULL.
            else
            {
                user = name;
                users.Add(user);
            }
            Console.Clear();
            GetStarted();
        }
        public void GetStarted()
        {
            string input;
            Console.WriteLine("Выберите действие:");
            Console.WriteLine("1. Добавить фигуру");
            Console.WriteLine("2. Вывести фигуры");
            Console.WriteLine("3. Очистить холст");
            Console.WriteLine("4. Сменить пользователя");
            Console.WriteLine("5. Выход");
            input = Console.ReadLine();

            switch (input)
            {
                case "1":
                    Console.WriteLine("Выбери фигуру для создания:");
                    Console.WriteLine("1. Создать линию:");
                    Console.WriteLine("2. Создать круг:");
                    Console.WriteLine("3. Создать кольцо: ");
                    Console.WriteLine("4. Создать треугольник: ");
                    Console.WriteLine("5. Создать прямоугольник");
                    Console.WriteLine("6. Создать квадрат: ");
                    string variant = Console.ReadLine();
                    Point dot1;
                    Point dot2;
                    Point dot3;
                    Point dot4;
                    double internalRadius;
                    double externalRadius;

                    switch (variant)
                    {
                        case "1":
                            dot1 = Input("Первая точка");
                            dot2 = Input("Вторая точка");
                            try
                            {
                                Line line = new Line(dot1, dot2);
                                user.AddFigure(line);
                                Console.WriteLine($"Line is created: {line}");
                                Console.WriteLine(value: $"{line} Длина: {line.GetLength()}");
                                Console.WriteLine($" Длина линии: {line.GetLength()}");
                                Console.WriteLine();
                                GetStarted();
                            }
                            catch
                            {
                                throw new Exception();
                            }
                            break;

                        case "2":
                            dot1 = Input("Первая точка");
                            Console.Write("Введите радиус: ");
                            double.TryParse(Console.ReadLine(), out internalRadius);
                            try
                            {
                                Circle circle = new Circle(dot1, internalRadius);
                                user.AddFigure(circle);
                                Console.WriteLine($"Circle is created: {circle}");
                                Console.WriteLine($" Длина круга: {circle.GetLength()}; Площадь круга: {circle.GetArea()}");
                                Console.WriteLine();
                                GetStarted();
                            }
                            catch
                            {
                                throw new Exception();
                            }
                            break;

                        case "3":
                            dot1 = Input("Первая точка");
                            Console.Write("Введите внутренний радиус: ");
                            double.TryParse(Console.ReadLine(), out internalRadius); ;
                            Console.Write("Введите внешний радиус: ");
                            double.TryParse(Console.ReadLine(), out externalRadius); ;
                            try
                            {
                                Ring ring = new Ring(dot1, internalRadius, externalRadius);
                                user.AddFigure(ring);
                                Console.WriteLine($"Ring is created: {ring}");
                                Console.WriteLine($" Длина кольца: {ring.GetLength()}; Площадь кольца: {ring.GetArea()}");
                                Console.WriteLine();
                                GetStarted();
                            }
                            catch
                            {
                                throw new Exception();
                            }
                            break;

                        case "4":
                            dot1 = Input("Первая сторона");
                            dot2 = Input("Вторая сторона");
                            dot3 = Input("Третья сторона");

                            try
                            {
                                Triangle triangle = new Triangle(dot1, dot2, dot3);
                                user.AddFigure(triangle);
                                Console.WriteLine($"Triangle is created: {triangle}");
                                Console.WriteLine($" Периметр треугольника: {triangle.GetLength()}; Площадь треугольника: {triangle.GetArea()}");
                                Console.WriteLine();
                                GetStarted();
                            }
                            catch
                            {
                                throw new Exception();
                            }
                            break;

                        case "5":
                            dot1 = Input("Первая сторона");
                            dot2 = Input("Вторая сторона");
                            dot3 = Input("Третья сторона");
                            dot4 = Input("Четвертая сторона");

                            try
                            {
                                Rectangle rectangle = new Rectangle(dot1, dot2, dot3, dot4);
                                user.AddFigure(rectangle);
                                Console.WriteLine($"Rectangle is created:{rectangle}");
                                Console.WriteLine($"Периметр прямоугольника: {rectangle.GetLength()}; Площадь прямоугольника: {rectangle.GetArea()}");
                                Console.WriteLine();
                                GetStarted();
                            }
                            catch
                            {
                                throw new Exception();
                            }
                            break;

                        case "6":
                            dot1 = Input("Первая точка");
                            dot2 = Input("Вторая точка");
                            dot3 = Input("Третья точка");
                            dot4 = Input("Четвертая точка");

                            try
                            {
                                Square square = new Square(dot1, dot2, dot3, dot4);
                                user.AddFigure(square);
                                Console.WriteLine($"Square is created: {square}");
                                Console.WriteLine($" Периметр квадрата: {square.GetLength()}; Площадь квадрата: {square.GetArea()}");
                                Console.WriteLine();
                                GetStarted();
                            }
                            catch
                            {
                                throw new Exception();
                            }
                            break;

                        default:
                            throw new NotImplementedException();
                    }
                    break;

                case "2":
                    int i = 0;
                    foreach (var item in user._figures)
                    {
                        Console.WriteLine($"Id - {i} {item}");
                        i++;
                    }
                    Console.WriteLine();
                    GetStarted();
                    break;
                case "3":
                    user._figures.Clear();
                    Console.WriteLine("Clear");
                    Console.WriteLine();
                    GetStarted();
                    break;
                case "4":
                    GetAuthorised();
                    break;
                case "5":
                    break;
                default:
                    throw new NotImplementedException();
            }
        }
    }
}
