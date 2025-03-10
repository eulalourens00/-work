using static System.Net.Mime.MediaTypeNames;
using System.Text.RegularExpressions;
using System.Diagnostics.Metrics;

namespace MassiveStrings
{
    internal class Program
    {
        //1.
        static void LastNames()
        {
            Console.WriteLine("\tLast names: ");
            string names = Console.ReadLine();
            string[] lastnames = names.Split(',');
            string max = string.Empty;

            foreach (string name in lastnames) 
            {
                if(name.Length > max.Length) {  max = name; }
            }
            Console.WriteLine($"The longest last name is {max}");
        }
        //2.
        static void Choises()
        {
            List<Candidates> voters = new List<Candidates>
            {
                new Candidates("Leeky Suya", "GMS Street 5", new DateTime(2007, 12, 27)),
                new Candidates("Stepano Step", "Boor Street 7A", new DateTime(2005, 10, 18)),
                new Candidates("Poraky Leo", "Lesopol Street 12", new DateTime(1998, 8, 12)),
                new Candidates("Anna Smith", "GMS Street 5", new DateTime(2000, 5, 15)),
                new Candidates("John Doe", "Boorew Street 11C", new DateTime(1990, 3, 22))
            };

            var NeedVoters = voters.Where(voter => voter.Age() >= 18).ToList();

            NeedVoters.Sort((x, y) => string.Compare(x.Address, y.Address));

            Console.WriteLine("\tCandidates:");
            foreach (var voter in NeedVoters)
            {
                Console.WriteLine($"{voter.FullName}\n Address: {voter.Address}, Age: {voter.Age()}");
            }
        }

        //3.
        static void DSumma()
        {
            Console.Write("Last number: ");
            Int32.TryParse(Console.ReadLine(), out int last);
            int summa = 0;
            for(int i = 1; i <= last; i++)
            {
                summa += i;
                Console.Write($"d{i} ");
            }
            Console.WriteLine($"\nSumma = {summa}");
        }
        //4.
        static void TextNumber()
        {
            Console.WriteLine("Text:");
            string Text = Console.ReadLine().Trim();
            int summa = 0;
            string[] digits = Regex.Split(Text, @"\D+");

            foreach (string value in digits)
            {
                int number;
                if (int.TryParse(value, out number))
                {
                    Console.Write("Numbers: ", value + " ");
                    summa += number;
                }
            }
            Console.WriteLine($"\nResult of numbers in the text: {summa}");
        }
        static void Main(string[] args)
        {
            //1
            LastNames();
            //2
            Choises();
            //3
            DSumma();
            //4
            TextNumber();
        }
    }
}
