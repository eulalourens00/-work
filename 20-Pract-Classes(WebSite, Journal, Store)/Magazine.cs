using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace _20_Pract_Classes_WebSite__Journal__Store_
{
    internal class Magazine
    {
        public string NameMagazine { get; set; }
        public DateTime Year { get; set; }
        public string Discription { get; set; }
        public int Phone {  get; set; }
        public string Email { get; set; }

        public void AddData()
        {
            Console.WriteLine("\t--Add data about magazine--");
            Console.Write("Name: ");
            NameMagazine = Console.ReadLine();
            Console.Write("\nDiscription: ");
            Discription = Console.ReadLine();

            Console.Write("\nDate (yyyy-mm-dd): ");
            DateTime.TryParse(Console.ReadLine(), out DateTime date);
            Year = date;

            Console.Write("\nPhone: ");
            Int32.TryParse(Console.ReadLine(), out int number);
            Phone = number;

            Console.Write("\nEmail: ");
            string email = Console.ReadLine();
            string pattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";

            if (!Regex.IsMatch(email, pattern)) { Console.WriteLine("Email is invalid.");}
        }

        public override string ToString()
        {
            return $"{NameMagazine}. {Year}. \n" +
                $"{Discription}. \n {Phone} \n {Email}";
        }

        public void GetName()
        { Console.WriteLine($"{NameMagazine}"); }
        public void GetDiscription()
        { Console.WriteLine($"{Discription}"); }
        public void GetDate()
        { Console.WriteLine(Year); }
        public void GetContact()
        { Console.WriteLine($"{Phone} \n{Email}"); }
    }
}
