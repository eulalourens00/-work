using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace _20_Pract_Classes_WebSite__Journal__Store_
    {
        internal class Store
        {
            public string NameStore { get; set; }
            public string Address {  get; set; }
            public string Discription { get; set; }
            public int Phone { get; set; }
            public string Email { get; set; }

            public void AddData()
            {
                Console.WriteLine("\t--Add data about store--");
                Console.Write("Name: ");
                NameStore = Console.ReadLine();
                Console.Write("\nDiscription: ");
                Discription = Console.ReadLine();

                Console.Write("\nAddress: ");
                Address = Console.ReadLine();

                Console.Write("\nPhone: ");
                Int32.TryParse(Console.ReadLine(), out int number);
                Phone = number;

                Console.Write("\nEmail: ");
                string email = Console.ReadLine();
                string pattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";

                if (!Regex.IsMatch(email, pattern)) { Console.WriteLine("Email is invalid."); }
            }

            public override string ToString()
            {
                return $"{NameStore}. {Address}. \n" +
                    $"{Discription}. \n {Phone} \n {Email}";
            }

            public void GetName()
            { Console.WriteLine($"{NameStore}"); }
            public void GetDiscription()
            { Console.WriteLine($"{Discription}"); }
            public void GetAdress()
            { Console.WriteLine(Address); }
            public void GetContact()
            { Console.WriteLine($"{Phone} \n{Email}"); }
        }
    }

}
}
