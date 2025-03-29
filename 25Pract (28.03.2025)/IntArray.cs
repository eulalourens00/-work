using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _25Pract__28._03._2025_
{
    internal class IntArray
    {
        private int[] _array;
        private int _currentIndex;

        public IntArray(int size)
        {
            _array = new int[size];
            _currentIndex = 0;
        }
        public int CurrentValue
        {
            get  { return _array[_currentIndex]; }
            set
            {
                _array[_currentIndex] = value;
                _currentIndex = (_currentIndex + 1) % _array.Length;
            }
        }

        public void FillArray(int[] values)
        {
            if (values.Length > _array.Length)
            { throw new ArgumentException("Too many values."); }

            for (int i = 0; i < values.Length; i++)
            { _array[i] = values[i]; }
        }

        public void PrintArray()
        {
            Console.WriteLine("Array:");
            foreach (var i in _array)
            { Console.Write(i + " ");}
            Console.WriteLine();
        }
    }
}
