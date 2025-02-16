using System.Net.Http.Headers;

namespace class_11._02._2025
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //User user = new User();
            //user.Name = "Leeky";

            //User user = new User();
            //user.Print();

            //User user1 = new User("USER1");
            //user1.Print();

            //User user2 = new User("ttt", "222");
            //user2.Print();

            //(string name, string lastname) = user2;
            //Console.WriteLine(name + " " + lastname);

            int a = 10;
            Calc calc = new Calc();
            calc.Add(1, 2);
            calc.Add(3, 4, 5);
            calc.Add(5, 6, 7, 8);
            calc.Inc(a);
            calc.Inc(ref a);

            Stat user1 = new Stat(18);
            user1.Check();
            Stat.limitAge = 21;
            user1.Check();

            Console.WriteLine(user1.Count);
            Stat user2 = new Stat(19);

            Stat.AddAge();

        }
    }
}
