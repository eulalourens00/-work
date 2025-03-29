using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _25Pract__28._03._2025_
{
    internal class TextArray
    {
        private string[] _textArray;
        public TextArray(string[] anotherArray) { _textArray = anotherArray; }
        public string this[int index] /*одномерный инд*/
        {
            get
            {
                index = (index % _textArray.Length + _textArray.Length) % _textArray.Length;
                return _textArray[index];
            }
            set
            {
                index = (index % _textArray.Length + _textArray.Length) % _textArray.Length;
                _textArray[index] = value;
            }
        }
        public char this[int anotherArray, int charIndex] /*двумерный инд*/
        {
            get
            {
                anotherArray = (anotherArray % _textArray.Length + _textArray.Length) % _textArray.Length;
                char[] chars = _textArray[anotherArray].ToCharArray();
                charIndex = (charIndex % chars.Length + chars.Length) % chars.Length;

                return chars[charIndex];
            }
            set
            { 
                anotherArray = (anotherArray % _textArray.Length + _textArray.Length) % _textArray.Length;
                char[] chars = _textArray[anotherArray].ToCharArray();
                charIndex = (charIndex % chars.Length + chars.Length) % chars.Length;
                chars[charIndex] = value;
                _textArray[anotherArray] = new string(chars);
            }
        }
    }
}
