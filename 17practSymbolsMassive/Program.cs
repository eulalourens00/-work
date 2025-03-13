using System.Text.RegularExpressions;
using static System.Net.Mime.MediaTypeNames;

namespace _17practSymbolsMassive
{
    internal class Program
    {
        //1.
        static void DiapHundred()
        {
            Console.Write("End: ");
            Int32.TryParse(Console.ReadLine(), out int end);
            Random rgn = new Random();
            List<int> array = new List<int>();
            for (int i = 0; i < end; i++)
            {
                int random = rgn.Next(-1000, 1000);
                Console.Write($"\nValues: {random} ");
                if (random >= -100 && random <= 100)
                { array.Add(random); }
            }
            if (array.Count > 1) { Console.WriteLine($"\nValue in our diapason: {String.Join(", ", array)}"); }
            else { Console.WriteLine("Absence."); }
        }
        //2.
        static void IsNumber()
        {
            Console.Write("Symbol: ");
            if (Int32.TryParse(Console.ReadLine(), out int num)) { Console.WriteLine("Its a number!"); }
            else { Console.WriteLine("Its not a number."); }
        }
        //3.
        static void NumbersInTheText()
        {
            Console.WriteLine("\tText: ");
            string text = Console.ReadLine().ToLower().Trim();
            string[] digits = Regex.Split(text, @"\D+");
            foreach(string number in digits) {  Console.Write(number + " "); }
        }
        //4.
        static void FoundValue()
        {
            //Console.WriteLine("Enter a math task like (200 * 3 + 10 : 2). Any symbols of operation (but + - * : /) will be ignored.");
            Console.Write($"Math task: ");
            string task = Console.ReadLine();
            string[] digits = Regex.Split(task, @"\D+");
            string[] operations = Regex.Split(task, @"[^\+\-\*\/\:]+");

            int summa = 0;
            int origin = 0;
            foreach (string number in digits)
            {
                if (int.TryParse(number, out int num))
                {
                    while(num > 0)
                    {
                        origin = num % 10;
                        num /= 10;
                    }
                    summa += origin; 
                
                } 
            }
            Console.WriteLine($"Summa of numbers in digits = {summa}");
        }

        //5.
        static void SummaNumber()
        {
            Console.Write($"Math task: ");
            string task = Console.ReadLine();
            string[] digits = Regex.Split(task, @"\D+");

            int summa = 0;
            foreach (string number in digits)
            {
                if (int.TryParse(number, out int num))
                { summa += num; }
            }
            Console.WriteLine($"Summa of numbers in digits = {summa}");
        }

        //6.
        static void CountSpace()
        {
            Console.Write("Enter a sentence: ");
            string sentence = Console.ReadLine().ToLower();
            int count = 0;
            sentence = sentence.Trim();
            int maxSpace = 0;

            for (int i = 0; i < sentence.Length; i++)
            {
                if (sentence[i] == ' ') { count++; }
                else
                {
                    if (count > maxSpace) { maxSpace = count; }
                    else { count = 0; }
                }
            }
            Console.WriteLine($"Max space between two words is {maxSpace}");
        }
        //7.
        static void DifferentSymb()
        {
            Console.Write("Enter a sentence: ");
            string sentence = Console.ReadLine().ToLower();
            int count = 0;
            sentence = sentence.Trim().ToLower();

            var set = new HashSet<int>();
            foreach (var sym in sentence)
            {
                if (sym != ' ') { set.Add(sym); }
            }
            Console.WriteLine($"Count of different symbols = {set.Count}.");
        }

        //8.
        static void WordYesNo()
        {
            Console.Write("Two words: ");
            string[] words = Console.ReadLine().Split();
            for(int i = 1; i < words[1].Length; i++)
            {
                if (words[0][i] == words[1][i - 1])
                { Console.Write("yes "); }
                else { Console.Write("no "); }
            }
        }
        //9.
        static void ThreeWord()
        {
            Console.Write("Three words: ");
            string[] words = Console.ReadLine().Split();
            var set = new HashSet<string>(words);
            Console.WriteLine($"Different words = {string.Join(", ", set)}.");
        }
        //10.
        static void TenWords()
        {
            Console.WriteLine("\tSentence by 10 words: ");
            string[] words = Console.ReadLine().Split();
            if (words.Length == 10)
            { for (int i = 0; i < words.Length; i++) { Console.Write(words[i] + " "); } }

            else
            { throw new InvalidOperationException();}
        }
        static void Main(string[] args)
        {
            //1.
            DiapHundred();
            //2.
            IsNumber();
            //3.
            NumbersInTheText();
            //4.
            FoundValue();
            //5.
            SummaNumber();
            //6.
            CountSpace();
            //7.
            DifferentSymb();
            //8.
            WordYesNo();
            //9.
            ThreeWord();
            //10
            TenWords();
        }
    }
}
