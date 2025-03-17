using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace _2para._Kamil_
{
    internal struct Matrix2x2
    {
        public int Matrix1 {  get; set; }
        public int Matrix2 { get; set; }
        public int Matrix3 { get; set; }
        public int Matrix4 { get; set; }

        public Matrix2x2(int matrix1, int matrix2, int matrix3, int matrix4) { Matrix1 = matrix1; Matrix2 = matrix2; 
            Matrix3 = matrix3; Matrix4 = matrix4;
        }
        public int Deter()
        {
            return Matrix1 * Matrix4 - Matrix3 * Matrix4;
        }
    }
}
