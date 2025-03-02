using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Numbers._Pract_02._03._2025
{
    internal class Febonacci
    {
        Random rnd = new Random();
        public int[] Numbers;
        public int Startdiaposon { get; set; }
        public int Enddiaposon { get; set; }

        public Febonacci(int startdiaposon, int enddiaposon)
        {
            Startdiaposon = startdiaposon;
            Enddiaposon = enddiaposon;
        }

        public void Result()
        {
            List<int> fe = new List<int>();
            int a = 0;
            int b = 1;
            if (Startdiaposon > Enddiaposon)
            { Console.WriteLine("Invalid range."); }

            while (a <= Enddiaposon)
            {
                if (a >= Startdiaposon)
                { fe.Add(a);}

                int next = a + b; 
                a = b;
                b = next;
            }

            Console.WriteLine("Febonacci numbers:");
            foreach (var number in fe)
            { Console.Write(number + " "); }
        }
    }
}

