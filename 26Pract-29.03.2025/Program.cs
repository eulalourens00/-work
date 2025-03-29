
namespace _26Pract_29._03._2025
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1.
            int[][] intervals = new int[][]
            {
                new int[] { 1, 3 },
                new int[] { 3, 7 },
                new int[] { 8, 9 }
            };

            IntervalSet intervalSet = new IntervalSet(intervals);
            int result = intervalSet.MinSetSize();
            Console.WriteLine($"Answer is {result}");

            //2.
            int[][] massive = new int[][]
            {
                new int[] { 1, 3 },
                new int[] { 2, 5 },
                new int[] { 4, 8 },
                new int[] { 6, 10 }
            };

            MinimalDiap minimalDiap = new MinimalDiap(massive);
            minimalDiap.MinimalMaxValue();

            //3.
            CountOfWords();
            //4.
            Reverse();
            //5.
            Vowel();
            //6.
            SubStrCount();
        }
        //3.
        static void CountOfWords()
        {
            Console.Write("Enter a sentence: ");
            string val = Console.ReadLine();
            int count = 0;
            string[] strArr = val.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            foreach (string str in strArr) { count++; }
            Console.WriteLine("Count of words is {0}", count);
        }
        //4.
        static void Reverse()
        {
            Console.Write("Enter a sentence: ");
            string[] originalArray = Console.ReadLine().Split();
            string[] reversedArray = new string[originalArray.Length];

            int j = originalArray.Length;

            for (int u = 0; u < j; u++)
            {
                char[] wordArray = originalArray[u].ToCharArray();
                Array.Reverse(wordArray);
                reversedArray[u] = new string(wordArray);
            }
            Console.WriteLine(string.Join(' ', reversedArray));
        }
        //5.
        static void Vowel()
        {
            Console.Write("Enter a sentence: ");
            string sentence = Console.ReadLine().ToLower();
            char[] ch_vowel = { 'a', 'e', 'i', 'o', 'u', 'y' };
            int vowel_count = 0;
            foreach (char vowel in ch_vowel)
            {
                int i = 0;
                while ((i = sentence.IndexOf(vowel, i)) != -1) { vowel_count++; i++; }
            }
            Console.WriteLine("Count of vowels in your sentence is {0}", vowel_count);
        }
        static void SubStrCount()
        {
            Console.Write("Enter a sentence: ");
            string sentence = Console.ReadLine().ToLower();
            Console.Write("Enter a sub string: ");
            string sub = Console.ReadLine().ToLower();
            int count = 0;
            int i = 0;
            while ((i = sentence.IndexOf(sub, i)) != -1)
            {
                if (sentence.IndexOf(sub) > 1) { count++; i += sub.Length; }
            }
            Console.WriteLine($"Count of your word {sub.ToUpper()} is {count}");
        }
    }
}
