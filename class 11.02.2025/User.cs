using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class_11._02._2025
{
    //public class User
    //{
    //    string name = "Leeky";
    //    string lastName = "Suyac";

    //    //public string userName;
    //    //public string userlastName;

    //    //public User() { }
    //    //public User(string name, string lastName)
    //    //{
    //    //    this.name = name;
    //    //    this.lastName = lastName;
    //    //}

    //    //public User() : this("Test") { }
    //    //public User(string name) : this(name, "lll") { }
    //    //public User(string name, string lastName)
    //    //{
    //    //    this.name = name;
    //    //    this.lastName = lastName;
    //    //}
    //    //public void Print()
    //    //{
    //    //    Console.WriteLine($"{name} - {lastName}");
    //    //}

    //    //public void Deconstruct(out string userName, out string userLastName)
    //    //{
    //    //    userName = name;
    //    //    userLastName = lastName;
    //    //}

    //    public string Name
    //    {
    //        get { return name; }
    //        set
    //        {
    //            if (value.Length > 2 && value.Length < 7)
    //            {
    //                name = value;
    //            }
    //            else
    //            {
    //                Console.WriteLine("...");
    //            }
    //        }
    //    }

    //    public string Name2 { get { return name; } }
    //    public string Name3 { set { name = value; } }
    //    public string Test { get; set; }
    //}

    // 2 class
    public class Calc
    {
        public void Add(int a, int b)
        {
            int res = a + b;
            Console.WriteLine(res);
        }
        public void Add(int a, int b, int c)
        {
            int res = a + b + c;
            Console.WriteLine(res);
        }
        public void Add(int a, int b, int c, int d)
        {
            int res = a + b + c + d;
            Console.WriteLine(res);
        }

        public void Inc(ref int value)
        {
            value++;
            Console.WriteLine(value);
        }
        public void Inc(int value)
        {
            value++;
            Console.WriteLine(value);
        }

        public int Mult(int a, int b)
        {
            return a * b;
        }
        public double Mult(double a,  double b)
        {
            return a * b;
        }

        
    }
}
