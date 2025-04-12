using System.Diagnostics;
using static _28Pract_Classes_Interfaces.Article;

namespace _28Pract_Classes_Interfaces
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1.1 Article
            Article person = new Article();
            person.AddInfoPerson();
            person.PrintInfoPerson();
            Console.WriteLine(person.ToString());

            //1.1 Magazine
            var magazine = new Magazine("Armin Arlert", Frequency.Monthly, DateTime.Now, 712, new List<Article>());

            //1.
            Console.WriteLine(magazine.ToShortString());
            //2.
            Magazine test = new Magazine
            {
                NameOfMagazine = "Try",
                Type = Frequency.Monthly,
                DateTime = DateTime.Now,
                SerialNumber = 1
            };
            Console.WriteLine($"Is the magazine weekly - {test[Frequency.Weekly]}");
            Console.WriteLine($"Is the magazine monthly - {test[Frequency.Monthly]}");
            Console.WriteLine($"Is the magazine yearly - {test[Frequency.Yearly]}");

            //3.
            Console.WriteLine(magazine.ToString());

            //4.
            magazine.AddArticle();
            Console.WriteLine($"Average Rating: {magazine.MiddleRating}");

            //5.
            Time();


            //2.0
            Person2 person1 = new Person2("Leeky", 17);
            Person2 person2 = new Person2("Leeky", 18);
            Person2 person3 = new Person2("Suya", 25);

            Console.WriteLine(person1.Equals(person2));
            Console.WriteLine(person1 == person2);
            Console.WriteLine(person1 != person3);

            Edition edition1 = new Edition("Lalala", 1111);
            Edition edition2 = new Edition("Lalala", 1111);
            Edition edition3 = new Edition("OkeOKeOKe", 222);
            Console.WriteLine(edition1.Equals(edition2));
            Console.WriteLine(edition1 == edition2);
            Console.WriteLine(edition1 != edition3);

            //3.0
            for (int i = 1; i <= 10; i++)
            { Console.WriteLine($"n = {i}: {CountSay.CountAndSay(i)}");}
        }
        //5.
        static void Time()
        {
            int size = 100000;
            Article[] one = new Article[size];
            Article[,] two = new Article[100, 100];
            Article[][] three = new Article[100][];

            for (int i = 0; i < three.Length; i++)
            { three[i] = new Article[100];}

            Stopwatch stopwatch = new Stopwatch();

            stopwatch.Start();
            for (int i = 0; i < one.Length; i++)
            {  one[i] = new Article { Title = $"Article {i}", Rating = i % 5 }; }
            stopwatch.Stop();
            Console.WriteLine($"Time to one-dimensional array: {stopwatch.ElapsedMilliseconds}");

            stopwatch.Restart();
            for (int i = 0; i < two.GetLength(0); i++)
            {
                for (int j = 0; j < two.GetLength(1); j++)
                { two[i, j] = new Article { Title = $"Article {i * 100 + j}", Rating = (i * 100 + j) % 5 }; }
            }
            stopwatch.Stop();
            Console.WriteLine($"Time to two-dimensional array: {stopwatch.ElapsedMilliseconds}");

            stopwatch.Restart();
            for (int i = 0; i < three.Length; i++)
            {
                for (int j = 0; j < three[i].Length; j++)
                { three[i][j] = new Article { Title = $"Article {i * 100 + j}", Rating = (i * 100 + j) % 5 };}
            }
            stopwatch.Stop();
            Console.WriteLine($"Time taken to fill jagged array: {stopwatch.ElapsedMilliseconds}");
        }
    }
}
