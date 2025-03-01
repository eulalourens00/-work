namespace Перегрузка_Структуры_01._03._2025
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //5
            Article article = new Article(7324, "Flowers", 4700, ArticleType.Other);
            Console.WriteLine(article);

            //6
            Client client = new Client(134, "Leeky", "Suya", "12A BooStreeet", 79773212, 5, 4323.12, ClientType.UserPro);
            Console.WriteLine(client);

            //7
            List<string> goods = new List<string> { "apples", "potato", "oil" };
            Request request = new Request("07DB27", "Adam", new DateTime(2025, 03, 01), goods, 460.0, PayType.Online );
            Console.WriteLine(request);

            //8.
            int[][] marks = new int[][] {
                new int[] {4, 5, 4},
                new int[] {5, 4, 3 },
                new int[] {3, 3, 4 }
            };
            Student student = new Student("Hekkoo", "Luna", "12AS-D", 19, marks);
            student.Info();
            student.NewMark(0, 1, 5);
            Console.WriteLine(student.GetMark(1, 1));
            Console.WriteLine(student.MiddleMark(2));

            //9.
            WorldMagic[] magics = new WorldMagic[] {
                new GreatWallOfChina(),
                new ChristTheRedeemer(),
                new MachuPicchu(),
                new ChichenItza(),
                new RomanColosseseum(),
                new Petra(),
                new TajMahal()
            };
            foreach (var magic in magics) { magic.Info(); }

            //10.
            CapitalA capitalA = new CapitalA();
            CapitalB capitalB = new CapitalB();
            CapitalC capitalC = new CapitalC();

            Console.WriteLine($"Population of {capitalA.Name}: {capitalA.People}");
            Console.WriteLine($"Population of {capitalB.Name}: {capitalB.People}");
            Console.WriteLine($"Population of {capitalC.Name}: {capitalC.People}");

            
            Population(capitalA, capitalB, capitalC);
        }
        //10
        static void Population(CapitalA capitalA, CapitalB capitalB, CapitalC capitalC)
        {
            int maxPeople = Math.Max(capitalA.People, Math.Max(capitalB.People, capitalC.People));

            if (maxPeople == capitalA.People)
            {
                Console.WriteLine($"{capitalA.Name} has the highest People.");
            }
            else if (maxPeople == capitalB.People)
            {
                Console.WriteLine($"{capitalB.Name} has the highest People.");
            }
            else
            {
                Console.WriteLine($"{capitalC.Name} has the highest People.");
            }
        }

    }
    
}
