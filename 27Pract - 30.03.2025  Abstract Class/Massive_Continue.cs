using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _27Pract___30._03._2025__Abstract_Class
{
    internal class Massive_Continue : Massive
    {
        public Massive_Continue(int i ) : base(i) { }

        public override void Info()
        {
            for (int i = 0; i < Values.Length; i++) { Console.Write($"{Values[i]} "); }
        }
        public override int this[int index] { get { return Values[index]; } set { Values[index] = value; } }

    }
}
