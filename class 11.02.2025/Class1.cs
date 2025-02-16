using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class_11._02._2025
{
    internal class Stat
    {
   
        static int count = 0;
        public int Count => count;
        int age;
        public static int limitAge = 18;
        static int limAge = 18;


        public static int LimAge
        {
            get { return limAge; }
            set
            {
                if (value > 1 && value < 100)
                { limAge = value; }
            }
        }

        public void GetAge()
        {
            Console.WriteLine(age);
        }
        public void SetAge (int age)
        {
            this.age = age;
        }
        public Stat(int age)
        {
            this.age = age;
        }
        public void Check()
        {
            if (age >= limitAge)
            {
                Console.WriteLine("OK");
            }
            else
            {
                Console.WriteLine("no.");
            }
        }

        public static void AddAge()
        {
            LimAge++;
            Console.WriteLine(LimAge);
        }
        
        static Stat()
        {
            if(DateTime.Now.Year == 2024)
            {
                limAge = 18;
            }
            else
            {
                limAge = 21;
            }
        }
    }

    static class Stat2
    {
        public static double Add(double a, double b) => a + b;
    }


}
