namespace _27Pract___30._03._2025__Abstract_Class
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1.
            List<Edition> catalog = new List<Edition>
            {
                new Book("Lost your mind", "Shallow A", 1869, "P2W"),
                new Article("Sharks - angels", "Weepo", 2005, "Voppyy", 246509),
                new Ebook("We had made it asleep", "WorldBegemotKot", "http://example.com")
            };
            foreach (var edition in catalog)
            {
                edition.Print();
            }
            string authorToSearch = "WorldBegemotKot";
            Console.WriteLine($"\nFind - '{authorToSearch}':");
            foreach (var edition in catalog)
            {
                if (edition.Find(authorToSearch))
                { edition.Print(); }
            }

            //2.
            Massive_Continue massive = new Massive_Continue(10);
            Console.WriteLine("Start massive: ");
            massive.Info();
            Console.WriteLine($"\nSize is {massive.Size_Values}");

            //3.
            List<GeometryFigures> figures = new List<GeometryFigures>
            {
                new Circle(5),
                new Rectangle(4, 6),
                new Triangle(2, 8, 4, 1)
            };
            figures.Sort();
            foreach (var figure in figures)
            { Console.WriteLine($"Figure: {figure.GetType().Name}, Area: {figure.Area()}"); }

            //4.
            List<Function> functions = new List<Function>
            {
                new Line(2, 3),
                new Kub(1, -1, 2),
                new Hyperbola(5)
            };
            functions.Sort();
            double x = 2;
            foreach (var function in functions)
            {
                function.Info();
                Console.WriteLine($"Value at x = {x}: {function.Calculate(x)}");
                Console.WriteLine();
            }
        }
    }
}
