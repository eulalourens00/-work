namespace _19Pract
{
    internal class Program
    {
        //2.
        static void Sort(int[] arr1, int left, int right)
        {
            if (left < right)
            {
                int pivot = Partition(arr1, left, right);

                if (pivot > 1)
                { Sort(arr1, left, pivot - 1); }

                if (pivot + 1 < right)
                { Sort(arr1, pivot + 1, right); }
            }
        }

        static int Partition(int[] arr, int left, int right)
        {
            int pivot = arr[left];
            while (true)
            {
                while (arr[left] < pivot)
                { left++; }

                while (arr[right] > pivot)
                { right--; }

                if (left < right)
                {
                    int temp = arr[left];
                    arr[left] = arr[right];
                    arr[right] = temp;
                }
                else { return right; }
            }
        }

        static void Main(string[] args)
        {
            //1.
            int[] arr = { 78, 55, 45, 98, 13 };
            int temp;

            Console.WriteLine("Start:");
            foreach (int p in arr)
            { Console.Write(p + " "); }

            for (int j = 0; j <= arr.Length - 2; j++)
            {
                for (int i = 0; i <= arr.Length - 2; i++)
                {
                    if (arr[i] > arr[i + 1])
                    {
                        temp = arr[i + 1];
                        arr[i + 1] = arr[i];
                        arr[i] = temp;
                    }
                }
            }

            Console.WriteLine("\nNow:");
            foreach (int p in arr)
            { Console.Write(p + " "); }


            Console.WriteLine();

            //2.
            int[] arr1 = { 78, 55, 45, 98, 13 };
            Console.WriteLine("Start:");
            foreach (int p in arr1)
            { Console.Write(p + " "); }

            Sort(arr1, 0, arr1.Length - 1);

            Console.WriteLine("\nNow:");
            foreach (int p in arr1)
            { Console.Write(p + " "); }

            Console.WriteLine();

            //3.
            string str = "Leeky Suya";
            int length = 0;

            foreach (char ch in str)
            { length++; }

            Console.WriteLine("Length: " + length);

            Console.WriteLine();

            //4.
            Console.WriteLine("After obrabotca:");

            for (int i = str.Length - 1; i >= 0; i--)
            {Console.Write(str[i]); }

            Console.WriteLine();

            //5.
            string str1 = "Meow meow meow kitty says meow meow";
            int wordCount = 0;

            for (int i = 0; i < str1.Length - 1; i++)
            {
                if (str1[i] == ' ' && Char.IsLetter(str1[i + 1]) && (i > 0))
                {  wordCount++;}
            }
            wordCount++;

            Console.WriteLine("Count: " + wordCount);

            Console.WriteLine();
            //6.
            string str2 = "Leeky";
            string str3 = "Suya";

            bool flag = true;

            if (str2.Length != str3.Length)
            {flag = false; }
            else
            {
                for (int i = 0; i < str2.Length; i++)
                {
                    if (str2[i] != str3[i])
                    {
                        flag = false;
                        break;
                    }
                }
            }
            Console.WriteLine("Same: " + flag);

            Console.WriteLine();
            //7.
            string str4 = "Leeky Suya! 123";
            int words = 0, digits = 0, symbols = 0;

            foreach (char ch in str4)
            {
                if (Char.IsLetter(ch))
                    words++;
                else if (Char.IsDigit(ch))
                    digits++;
                else
                    symbols++;
            }

            Console.WriteLine("Words: " + words);
            Console.WriteLine("Numbers: " + digits);
            Console.WriteLine("Symbols: " + symbols);

            Console.WriteLine();
            //8.
            string thefirst = "Aplle gaspe banana";
            string thesecond = "OHWHAT";

            foreach (char ch in thefirst)
            { thesecond += ch;}

            Console.WriteLine("Well: " + thesecond);

            Console.WriteLine();

            //9.
            string text = "pe pe pep epeppee pryumpunmd".ToLower().Trim();
            int vowels = 0, unvowels = 0;

            foreach (char ch in str)
            {
                if (Char.IsLetter(ch))
                {
                    if ("aeiouy".Contains(ch))
                    { vowels++; }
                    else { unvowels++; }
                }
            }

            Console.WriteLine("Vowels: " + vowels);
            Console.WriteLine("Unvowels: " + unvowels);

            Console.WriteLine();
            //10.
            string[] wordsss = { "banana", "apple", "cherry", "grape" };

            Array.Sort(arr);

            Console.WriteLine("After sort:");
            foreach (string a in wordsss)
            { Console.WriteLine(str); }
        }
    }
}
