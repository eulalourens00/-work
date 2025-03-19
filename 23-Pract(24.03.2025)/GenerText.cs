using Microsoft.VisualBasic;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23_Pract_24._03._2025_
{
    internal class GenerText
    {
        public int CountVowels { get; set; }
        public int CountUnVowels { get; set; }
        public int LengthText { get; set; }
        Random rnd = new Random();

        public GenerText(int count_vawels, int count_unvowels, int length_text)
        {
            CountVowels = count_vawels;
            CountUnVowels = count_unvowels;
            LengthText = length_text;
        }
        public void Gener()
        {
            var vowels = "AEIOUaeiou";
            var consonants = "BCDFGHJKLMNPQRSTVWXYZbcdfghjklmnpqrstvwxyz";
            var stringChars = new char[LengthText];
            var random = new Random();

            //гласные
            for (int i = 0; i < CountVowels; i++)
            { stringChars[i] = vowels[random.Next(vowels.Length)]; }

            // согласные
            for (int i = CountVowels; i < CountVowels + CountUnVowels; i++)
            { stringChars[i] = consonants[random.Next(consonants.Length)]; }

            // остальное случайными буквами
            for (int i = CountVowels + CountUnVowels; i < LengthText; i++)
            { stringChars[i] = (vowels + consonants)[random.Next(vowels.Length + consonants.Length)]; }

            // перемешивание
            stringChars = stringChars.OrderBy(x => random.Next()).ToArray();

            var finalString = new String(stringChars);
            Console.WriteLine($"RESULT: {finalString}");
        }

    }
}
