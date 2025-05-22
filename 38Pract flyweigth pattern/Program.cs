namespace _38Pract_flyweigth_pattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var factory = new GlyphFactory();
            var context = new GraphicsContext(0, 0);

            var page = factory.CreatePage();
            var row = factory.CreateRow();

            row.Add(factory.CreateCharacter('A'));
            row.Add(factory.CreateCharacter('B'));
            row.Add(factory.CreateCharacter('C'));

            page.Add(row);

            Console.WriteLine("Draw:");
            page.Draw(context);

            Console.WriteLine("\nCheck:");
            Console.WriteLine($"Point (5,5): {page.Intersects(new Point(5, 5), context)}");
            Console.WriteLine($"Point (50,50): {page.Intersects(new Point(50, 50), context)}");
        }
    }
}
