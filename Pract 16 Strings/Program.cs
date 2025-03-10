namespace Pract_16_Strings
{
    internal class Program
    {
        //1.
        static void Matrix()
        {
            Console.Write("Size: ");
            Int32.TryParse(Console.ReadLine(), out int size);

            if(size <= 0) { throw new InvalidOperationException(); }
            int[,] matrix = new int[size, size];

            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    Console.Write($"Value [{i},{j}]: ");
                    Int32.TryParse(Console.ReadLine(), out matrix[i, j]);    
                }
            }
            Console.WriteLine("\tMatrix:");
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    Console.Write($"{matrix[i, j], 4} "); 
                }
                Console.WriteLine();
            }

            int positiveCount = 0;
            int negativeCount = 0;

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (matrix[i, j] > 0)
                    { positiveCount++;}
                    else if (matrix[i, j] < 0)
                    { negativeCount++;}
                }
            }

            Console.WriteLine($"Count of positive numbers: {positiveCount}");
            Console.WriteLine($"Count of negtive numbers: {negativeCount}");
        }
        //2.
        static void TwoWords()
        {
            Console.Write($"Enter two words: ");
            string[] words = Console.ReadLine().Split();
            if (words[1].Length >= words[0].Length) { throw new InvalidOperationException(); }

            string neew = string.Empty;
            for (int i = 0; i < words[1].Length; i++)
            {
                neew += words[0][i];
            }
            Console.WriteLine($"Result: {neew}");
        }
        //3.
        static void Sentence()
        {
            Console.WriteLine("\tText: ");
            string text = Console.ReadLine().ToLower().Trim();
            int countNN = 0;
            string sub = "нн";
            int i = 0;
            while ((i = text.IndexOf(sub, i)) != -1)
            {
                if (text.IndexOf(sub) > 1) { countNN++; i += sub.Length; }
            }
            Console.WriteLine($"Count of your word {sub.ToUpper()} is {countNN}");
        }
        //4.
        static void CandT()
        {
            Console.WriteLine("\tText: ");
            string text = Console.ReadLine().ToLower().Trim();
            string subT = "т";
            string subC = "с";
            int t = text.LastIndexOf(subT);
            int c = text.LastIndexOf(subC);
            if (t > c) { Console.WriteLine($"The last word is T. Index {t}"); }
            else { Console.WriteLine($"The last word is C. Index {c}"); }
        }
        //5.
        static void FiveSymbols()
        {
            Console.WriteLine("\tText: ");
            string text = Console.ReadLine().ToLower().Trim();
            int count = 1;
            bool flag = false;

            for (int i = 1; i < text.Length; i++)
            {
                if (text[i] == text[i - 1])
                {
                    count++;
                    if (count == 5)
                    { Console.WriteLine($"Found five same symbols: {text[i]}"); flag = true;
                        break;
                    }
                }
                else { count = 1; }
            }

            if (!flag) { Console.WriteLine("No."); }
        }
        static void Main(string[] args)
        {
            //1.
            Matrix();
            //2.
            TwoWords();
            //3.
            Sentence();
            //4.
            CandT();
            //5.
            FiveSymbols();
        }
    }
}
