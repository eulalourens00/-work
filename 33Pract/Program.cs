namespace _33Pract
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1
            Translator translator = new Translator();

            while (true)
            {
                Console.WriteLine("1. eng -> ru");
                Console.WriteLine("2. ru -> eng");
                Console.WriteLine("3. exit");
                Console.Write("Choose: ");

                string choice = Console.ReadLine();

                if (choice == "3") { break; }

                Console.Write("Word: ");
                string word = Console.ReadLine();

                string translation = translator.Translate(choice, word);
                Console.WriteLine($"Translate: {translation}\n");
            }
            //2
            Point3D point = new Point3D(1, 2, 3);
            Console.WriteLine(point);

            //3
            var point1 = new Point2D<int>(1, 2);
            var point2 = new Point2D<int>(3, 4);
            var line1 = new Line<int>(point1, point2);
            Console.WriteLine(line1);

            var line2 = new Line<double>(1.5, 2.5, 3.5, 4.5);
            Console.WriteLine(line2);

            //4
            Console.WriteLine("Text:");
            string text = Console.ReadLine();

            WordCounter counter = new WordCounter();
            var result = counter.CountWords(text);

            Console.WriteLine("\nResult:");
            foreach (var pair in result.OrderByDescending(p => p.Value))
            {   Console.WriteLine($"{pair.Key}: {pair.Value}");}
        }
    }
}
