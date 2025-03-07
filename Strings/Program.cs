using System.Diagnostics;

namespace Strings
{
    internal class Program
    {
        //ПР-14 25.02.2025
        //1.
        static void CountOfWords()
        {
            Console.Write("Enter a sentence: ");
            string val = Console.ReadLine();
            int count = 0;
            string[] strArr = val.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            foreach (string str in strArr) { count++; }
            Console.WriteLine("Count of words is {0}", count);
        }
        // 2.
        static void Reverse()
        {
            Console.Write("Enter a sentence: ");
            string[] originalArray = Console.ReadLine().Split();
            string[] reversedArray = new string[originalArray.Length];
            
            int j = originalArray.Length;

            for(int u = 0; u < j; u++)
            {
                char[] wordArray = originalArray[u].ToCharArray();
                Array.Reverse(wordArray);
                reversedArray[u] = new string(wordArray);
            }
            Console.WriteLine(string.Join(' ', reversedArray));
        }
        //3.
        static void Vowel()
        {
            Console.Write("Enter a sentence: ");
            string sentence = Console.ReadLine().ToLower();
            char[] ch_vowel = { 'a', 'e', 'i', 'o', 'u', 'y'};
            int vowel_count = 0;
            foreach (char vowel in ch_vowel)
            {
                int i = 0;
                while ((i = sentence.IndexOf(vowel, i)) != -1) { vowel_count++; i++; }  
            }
            Console.WriteLine("Count of vowels in your sentence is {0}", vowel_count);
        }
        //4.
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
                if(sentence.IndexOf(sub) > 1) { count++; i += sub.Length; }
            }
            Console.WriteLine($"Count of your word {sub.ToUpper()} is {count}");
        }
        //5.
        static void CountSpace()
        {
            Console.Write("Enter a sentence: ");
            string sentence = Console.ReadLine().ToLower();
            int count = 0;
            sentence = sentence.Trim();
            int maxSpace = 0;

            for(int i = 0; i < sentence.Length; i++)
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
        //6.
        static void CountSymbols()
        {
            Console.Write("Enter a sentence: ");
            string sentence = Console.ReadLine().ToLower();
            int count = 0;
            sentence = sentence.Trim();
            int maxSym = 0;

            for (int i = 0; i < sentence.Length; i++)
            {
                for (int j = 1; j < sentence.Length; j++) {
                    if (sentence[i] == ' ') { continue; }
                    else if (sentence[i] == sentence[j]) { count++; }
                    else
                    {
                        if (count > maxSym) { maxSym = count; }
                        else { count = 0; }
                    }
                }    
            }
            Console.WriteLine($"Max space between two words is {maxSym}");
        }
        //7
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
        //8
        static void TwoSame()
        {
            Console.Write("Enter a sentence: ");
            string sentence = Console.ReadLine().ToLower().Trim();

            char? same = null;
            for (int i = 0; i < sentence.Length; i++)
            {
                int count = 0;
                for (int j = 0; j < sentence.Length; j++)
                { if (sentence[i] == sentence[j]) { count++; } }
                           
                if (count == 2)
                { same = sentence[i]; break;}
            }

            Console.WriteLine($"Two same symbols is - '{same}'");
        }
        //___________________________________________________________________________________________________
        //      ПРАКТИЧЕСКАЯ 15
        //1.
        static void NewWord()
        {
            Console.Write("Enter a sentence: ");
            string sentence = Console.ReadLine().ToLower();
            string newword = string.Empty;

            for(int i = 1; i < sentence.Length; i++)
            {
                if(i % 2 != 0) { newword += sentence[i]; }
            }

            Console.WriteLine("New word is {0}", newword);
        }
        //2.
        static void Symbols()
        {
            Console.Write("Enter a sentence: ");
            string sentence = Console.ReadLine().ToLower();
            string sub = "+";
            string sub2 = "*";

            int countPlus = 0;
            int countStar = 0;

            int i = 0;
            while ((i = sentence.IndexOf(sub, i)) != -1)
            { countPlus++; i += sub.Length; }

            int j = 0;
            while ((j = sentence.IndexOf(sub2, j)) != -1)
            { countStar++; j += sub2.Length; }
            
            Console.WriteLine($"Count of + is {countPlus} \nCount of * is {countStar}");
        }
        //3
        static void Zapytaya()
        {
            string sentence = "To be or not to be, that is the question.";
            string start = string.Empty;

            int zap = sentence.IndexOf(',');
            if (zap != -1) {
                string result = sentence.Substring(0, zap);
                Console.WriteLine("Start: {0} ", sentence);
                Console.WriteLine("Before: {0} ", result);
            }
            else { Console.WriteLine("No zapyataya"); }
        }
        //4
        static void OoooO()
        {
            Console.Write("Sentence: ");
            string sentence = Console.ReadLine().ToLower().Trim();
            string sub = "-";
            int i = 0;
            int countsub = 0;
            while ((i = sentence.IndexOf(sub, i)) != -1)
            { countsub++; i += sub.Length; }

            if (countsub > 0) { Console.WriteLine("Invalid input."); }
            else
            {
                int count_O = 0;
                int j = 0;
                string o = "o";
                string[] new_sentence = sentence.Split( );
                while ((j = new_sentence[0].IndexOf(o, j)) != -1) { count_O++; j += o.Length; }
                Console.WriteLine($"Count of 'O' in the first word = {count_O}");
            }
        }
        //5
        static void Sentences()
        {
            Console.WriteLine("Text (dont forget about the dots!): ");
            string text = Console.ReadLine().Trim();
            string[] dots = text.Split(new char[] { '.', '!', '?' }, StringSplitOptions.RemoveEmptyEntries);
            Console.WriteLine($"Count of sentences = {dots.Length}");
        }
        //6
        static void E_up_I()
        {
            Console.Write("Text: ");
            string text = Console.ReadLine().Trim().ToLower();
            text = text.Replace("e", "i");
            Console.WriteLine(text);
        }
        //7
        static void Ah_up_Uh()
        {
            Console.Write("Text: ");
            string text = Console.ReadLine().Trim().ToLower();
            text = text.Replace("ah", "uh");
            Console.WriteLine(text);
        }
        //8
        static void ReplaceMiddle()
        {
            Console.Write("Text: ");
            string text = Console.ReadLine().Trim().ToLower();
            string result = string.Empty;
            if(text.Length == 12)
            {
                string part = text.Substring(2, 8); //3, 9
                char[] strArray = part.ToCharArray();
                Array.Reverse(strArray);
                result = new string(strArray);
               
                Console.WriteLine($"Result: {text.Substring(0, 2)}{result}{text.Substring(9)}");
            }
            else { Console.WriteLine("Invalid input."); }
        }
        static void Main(string[] args)
        {
                        //// №14
            ////1.
            //CountOfWords();
            ////2.
            //Reverse();
            ////3.
            //Vowel();
            ////4.
            //SubStrCount();
            ////5.
            //CountSpace();
            ////6.
            //CountSymbols();
            ////7.
            //DifferentSymb();
            //////8.
            //TwoSame();

                        ////№15
            ////1.
            //NewWord();
            ////2.
            //Symbols();
            ////3.
            //Zapytaya();
            ////4.
            //OoooO();
            ////5.
            //Sentences();
            ////6.
            //E_up_I();
            ////7.
            //Ah_up_Uh();
            //8.
            //ReplaceMiddle();

            //--------------------------------------------------------------------------
            //  CLASSWORK

            //string str1 = "Test";
            //string str5 = "Test";

            //string str2 = new string(new char[] { 'a', 'b', 'c', 'd', 'e' });
            //string str3 = new string(new char[] { 'a', 'b', 'c', 'd', 'e' }, 1, 3);
            //string str4 = new string('a', 20);

            //Console.WriteLine(str1);
            //Console.WriteLine(str2);
            //Console.WriteLine(str3);
            //Console.WriteLine(str4);

            //Console.WriteLine();
            //foreach(var c in str1) Console.WriteLine(c);

            //Console.WriteLine(str1==str5);

            //string str1 = "Help";
            //string str2 = "mee";

            //string str3 = str1 + " " + str2;
            //string str4 = string.Concat(str3, "!");

            //Console.WriteLine(str4);

            //var val = new string[] { str1, str2, str3, str4 };
            //string str5 = string.Join(" ", val);
            //Console.WriteLine(str5);

            ////Compare
            //int result = string.Compare(str1, str2);
            //if (result < 0) { Console.WriteLine("Строка s1 перед строкой s2"); }
            //else if (result > 0) { Console.WriteLine("Строка s1 стоит после s2"); } //алфовитный порядок
            //else { Console.WriteLine("Same."); }

            //string str3 = "Test word text tee";
            //char ch = 'e';
            //int indexOfChar = str3.IndexOf(ch);
            //Console.WriteLine(indexOfChar);

            //string sub = "tex";
            //int indexOfSub = str3.IndexOf(sub);
            //Console.WriteLine(indexOfSub);

            //// startwith endwith
            //var files = new string[]
            //{
            //    "my.png",
            //    "i.jpg",
            //    "u.exe",
            //    "text.exe",
            //    "3.png"
            //};
            //for (int i = 0; i < files.Length; i++) {
            //    if (files[i].EndsWith(".png"))
            //    {
            //        Console.WriteLine(files[i]);
            //    }
            //}

            ////Split
            //string text = "Help me pleaseeee meeeowww";
            //string[] strArr = text.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            //foreach (string str in strArr) { Console.WriteLine(str); }

            //Trim TrimStart TrimEnd
            //string text = "              Text texts tetsdt teee doooog     ";
            //Console.WriteLine(text);
            //text = text.Trim();

            ////Console.WriteLine(text);

            ////string ttext = text.Trim(new char[] { 't', 'o' });
            ////Console.WriteLine(ttext);

            //text = text.Substring(0, text.Length - 2); // обрезает
            //Console.WriteLine(text);

            ////insert впихивает внутрь текста по индексу
            //string sub = "World settings";
            //text = text.Insert(8, sub);
            //Console.WriteLine(text);

            //// remove
            //string text = "Eula Lourens";

            //int ind = text.Length - 1;
            //text = text.Remove(ind);

            //Console.WriteLine(text);
            //text = text.Remove(0, 2);
            //Console.WriteLine(text);

            //// replace
            //text = text.Replace("Eula", "Leeky");
            //Console.WriteLine(text);

            //text = text.Replace("e", " ");
            //Console.WriteLine(text.ToUpper());

            //string LastName = "Suya";
            //int salary = 30000;
            //Console.WriteLine("LastName: {0}, Salary: {1}", LastName, salary);
        }
    }
}
