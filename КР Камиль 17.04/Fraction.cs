using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace КР_Камиль_17._04
{
    public class Fraction
    {
        public double chislitel1 {  get; set; }
        public double znamenatel1 { get; set; }
        public double chislitel2 { get; set; }
        public double znamenatel2 { get; set; }

        public Fraction(double chislitel1, double znamenatel1, double chislitel2, double znamenatel2)
        {
            this.chislitel1 = chislitel1;
            this.znamenatel1 = znamenatel1;
            this.chislitel2 = chislitel2;
            this.znamenatel2 = znamenatel2;
        }  
        public void Summa()
        {
            if (znamenatel1 == 0 || znamenatel2 == 0) { throw new DivideByZeroException(); }
            double thefirst = chislitel1 / znamenatel1;
            double thesecond = chislitel2 / znamenatel2;
            Console.WriteLine("Values: " + thefirst + " " + thesecond);
            Console.WriteLine($"Result: {thefirst + thesecond}");
        }
        public void Div()
        {
            if (znamenatel1 == 0 || znamenatel2 == 0) { throw new DivideByZeroException(); }
            double thefirst = chislitel1 / znamenatel1;
            double thesecond = chislitel2 / znamenatel2;
            Console.WriteLine("Values: " + thefirst + " " + thesecond);
            Console.WriteLine($"Result: {Math.Round(thefirst - thesecond)}");
        }
    }
}
