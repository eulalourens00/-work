using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2para._Kamil_
{
    internal struct Vector3D
    {
        public int x; public int y; public int z;
        public Vector3D(int X, int Y, int Z) { x = X; y = Y; z = Z; }

        public Vector3D Add(Vector3D other)
        {
            return new Vector3D(this.x + other.x, this.y + other.y, this.z + other.z);
        }

        public double Length()
        {
            return Math.Sqrt(x * x + y * y + z * z);
        }
        public override string ToString()
        {
            return $"({x}, {y}, {z})";
        }
    }
}
