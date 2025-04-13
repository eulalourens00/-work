using Microsoft.VisualBasic;

namespace _29Pract
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1
            BankAccount account = new BankAccount();
            account.AddData();
            Console.WriteLine(account.ToString());
            account.Plus();

            Console.WriteLine();

            BankAccount2 account2 = new BankAccount2();
            account2.AddData();
            Console.WriteLine(account2.ToString());
            account2.Minus();
            //2
            int[] array = { 5, 3, 8, 6, 1, 9, 2, 7, 4 };
            BubbleSortAlgorithm(array);
            //3
            string[] strings = { "la", "lalala", "lel", "lelelele", "l", "luuu" };
            FastSortAlgorithm(strings);
            //4
            FindLength();
            //5
            PrintLast();
            //6
            CountWords();
            //7
            CompareWords();
            //8
            CountEverything();
            //9
            CopyTo();
            //10
            string[] str = { "meow", "me", "meoooow", "mememme" };
            FastSortAlgorithm(str);
        }
        //2
        static void BubbleSortAlgorithm(int[] arr)
        {
            int n = arr.Length;
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        int temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }
            }
            foreach (var num in arr) {  Console.Write(num + " ");  }
        }
        //3.
        static void FastSortAlgorithm(string[] str)
        {
            int n = str.Length;
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (str[j].Length > str[j + 1].Length)
                    {
                        string temp = str[j];
                        str[j] = str[j + 1];
                        str[j + 1] = temp;
                    }
                }
            }
            foreach(var num in str) {  Console.Write(num + " "); }
        }
        //4.
        static void FindLength()
        {
            Console.Write("Word: ");
            string word = Console.ReadLine();
            char[] chars = word.ToCharArray();
            int i = 0;
            foreach (char c in chars) { i++; }
            Console.WriteLine($"Length - {i}");
        }
        //5
        static void PrintLast()
        {
            Console.Write("Word: ");
            string word = Console.ReadLine();
            char[] chars = word.ToCharArray();
            Array.Reverse(chars);
            foreach(var c in chars) { Console.Write(c + " "); }
        }
        //6
        static void CountWords()
        {
            Console.WriteLine("Sentence: ");
            string[] text = Console.ReadLine().Split();
            Console.WriteLine($"Count of words: {text.Count()}");
        }
        //7
        static void CompareWords()
        {
            Console.WriteLine("Enter two sentenses:");
            string[] strings = Console.ReadLine().Split('.');
            if (strings[0].Length > strings[1].Length) { Console.WriteLine("The first is more."); }
            else if (strings[0].Length == strings[1].Length) { Console.WriteLine("The same length."); }
            else { Console.WriteLine("The second is more."); }
        }
        //8
        static void CountEverything()
        {
            Console.WriteLine("Sentence:");
            string input = Console.ReadLine();
            int alphabets = 0;
            int digits = 0;
            int specialChars = 0;

            foreach (char ch in input)
            {
                if (char.IsLetter(ch))
                {  alphabets++;}
                else if (char.IsDigit(ch))
                {  digits++; }
                else
                {  specialChars++; }
            }

            Console.WriteLine($"Alphabets: {alphabets}");
            Console.WriteLine($"Digits: {digits}");
            Console.WriteLine($"Special symbols: {specialChars}");
        }
        //9
        static void CopyTo()
        {
            Console.WriteLine("Sentence for copy:");
            string sourceString = Console.ReadLine();
            char[] charArray = sourceString.ToCharArray();
            string copiedString = new string(charArray);

            Console.WriteLine($"Before: \"{sourceString}\"");
            Console.WriteLine($"After: \"{copiedString}\"");
        }
    }
}
