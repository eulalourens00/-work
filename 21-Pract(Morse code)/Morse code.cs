using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace _21_Pract_Morse_code_
{
    internal class Morse_code
    {
        public Dictionary<char, string> Code = new Dictionary<char, string>()
        {
            {'A', ".-" },
            {'B', "-..." },
            {'C', "-.-." },
            {'D', "-.." },
            {'E', "." },
            {'F', "..-." },
            {'G', "--." },
            {'H', "...." },
            {'I', ".." },
            {'J', ".---" },
            {'K', "-.-" },
            {'L', ".-.." },
            {'M', "--" },
            {'N', "-." },
            {'O', "---" },
            {'P', ".--." },
            {'Q', "--.-" },
            {'R', ".-." },
            {'S', "..." },
            {'T', "-" },
            {'U', "..-" },
            {'V', "...-" },
            {'W', ".--" },
            {'X', "-..-" },
            {'Y', "-.--" },
            {'Z', "--.." },

            {'0', "-----" },
            {'1', ".----" },
            {'2', "..---" },
            {'3', "...--" },
            {'4', "....-" },
            {'5', "....." },
            {'6', "-...." },
            {'7', "--..." },
            {'8', "---.." },
            {'9', "----." },

            {'.', ".-.-.-" },
            {',', "--..--" },
            {'?', "..--.." },
            {'`', ".----." },
            {'!', "-.-.--" },
            {'/', "-..-." },
            {'(', "-.-." },
            {')', "-.--.-" },
            {'&', ".-..." },
            {':', "---..." },
            {';', "-.-.-." },
            {'=', "-...-" },
            {'+', ".-.-." },
            {'-', "-....-" },
            {'_', "..--.-" },
            {'$', "...-..-" },
            {'@', ".--.-." }
            
        };

        public void ConvertToMorse(Dictionary<char, string>Code)
        {
            Console.WriteLine("Text To convert: ");
            string text = Console.ReadLine().ToUpper().Trim();
            char[] characters = text.ToCharArray();
            string result = string.Empty;
            foreach (char ch in text)
            {
                if (Code.ContainsKey(ch))
                { result += Code[ch] + " ";}

                else if (ch == ' ')
                { result += " ";}

                else
                { result += "";}
            }
            Console.WriteLine($"Morse code: {result}");
        }

        public void ConvertMorseToTheText(Dictionary<char, string> Code)
        {
            Console.WriteLine("Code To convert: ");
            string codee = Console.ReadLine().ToUpper().Trim();
            string[] code = codee.Split();
            //char[] characters = code.ToCharArray();
            string result = string.Empty;
            foreach (string str in code)
            {
                if (Code.ContainsValue(str))
                {
                    char character = Code.FirstOrDefault(x => x.Value == str).Key;
                    result += character;
                }
                else if (string.IsNullOrEmpty(str))
                { result += " "; }
                else
                { result += ""; }
            }
            Console.WriteLine($"Text: {result}");
        }
    }
}
