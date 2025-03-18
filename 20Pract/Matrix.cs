using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20Pract
{
    internal class Matrix
    {
        private int[,] matrix;

        public Matrix(int a, int b, int c, int d)
        {
            matrix = new int[2, 2]
            {
                { a, b },
                { c, d }
            };
        }
        public int Deter()
        {  return matrix[0, 0] * matrix[1, 1] - matrix[0, 1] * matrix[1, 0]; }
        public void MaxMin()
        {
            int min = matrix[0, 0];
            int max = matrix[0, 0];

            for (int i = 0; i < matrix.GetLength(0); i++) 
            {
                for (int j = 0; j < matrix.GetLength(1); j++) 
                {
                    if (matrix[i, j] < min) { min = matrix[i, j]; }

                    if (matrix[i, j] > max) { max = matrix[i, j]; }
                }
            }

            Console.WriteLine($"Min: {min}");
            Console.WriteLine($"Max: {max}");
        }
    }
}
