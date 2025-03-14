namespace _18Pract
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1.
            Diapason dipason = new Diapason(5, 10);
            Console.WriteLine("Mul of values in diapason = " + dipason.Factorial());
            //2.
            City city = new City();
            city.AddData();
            Console.WriteLine(city.ToString());

            Console.WriteLine();
            city.GetCountry();
            city.GetCodePhone();

            //3.
            Employee employee = new Employee();
            employee.AddData();
            Console.WriteLine(employee.ToString());

            Console.WriteLine();
            employee.GetEmail();
            employee.GetPhone();

            //4.
            Minimal();

            //5.
            DifferentWords();
        }
        //4.
        static void Minimal()
        {
            Console.Write("Enter a sentence: ");
            string[] sentence = Console.ReadLine().Split();
            string minSym = string.Empty;

            for (int i = 1; i < sentence.Length; i++)
            {
                if(sentence[i].Length < sentence[i - 1].Length) { minSym = sentence[i];}
            }
            Console.WriteLine($"Min word is {minSym}");
        }
        //5.
        static void DifferentWords()
        {
            Console.Write("Enter a sentence: ");
            string[] sentence = Console.ReadLine().Split();

            var allWords = new HashSet<string>();
            var duplicateWords = new HashSet<string>();

            foreach (var word in sentence)
            {
                if (!allWords.Add(word))
                { duplicateWords.Add(word);}                
            }
            allWords.ExceptWith(duplicateWords);
            Console.WriteLine($"Different words = {string.Join(", ", allWords)}.");
        }
    }
}