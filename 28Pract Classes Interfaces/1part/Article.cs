using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _28Pract_Classes_Interfaces
{
    public class Article : Person
    {
        public string Name;
        public int Age;
        public string Title;
        public double Rating;
        public Frequency Type;
        public Article() { }
        public Article(Frequency type) { Type = type; }
        public override void AddInfoPerson()
        {
            Console.Write("Author: ");
            Name = Console.ReadLine();
            Console.Write("\nAge: ");
            Int32.TryParse(Console.ReadLine(), out Age);
            Console.Write("\nTitle: ");
            Title = Console.ReadLine();
            Console.Write("\nRating: ");
            string ratingInput = Console.ReadLine();
            if (!Double.TryParse(ratingInput, NumberStyles.Any, CultureInfo.InvariantCulture, out Rating))
            { throw new InvalidDataException(); }

            Console.Write("\nHow often (1 - Weekly; 2 - Monthly; 3 - Yearly): ");
            Int32.TryParse(Console.ReadLine(), out int trytype);
            switch (trytype)
            {
                case 1: Type = Frequency.Weekly; break;
                case 2: Type = Frequency.Monthly; break;
                case 3: Type = Frequency.Yearly; break;
                default: throw new InvalidDataException();
            }

            Console.WriteLine();
        }
        public override void PrintInfoPerson()
        {
            if (Name == null || Age < 18 || Title == null || Rating < 0.0 || Rating > 5.0) { throw new ArgumentException("No data."); }
            else
            {
                Console.WriteLine("Person: " + Name); 
                Console.WriteLine("Age: " + Age);
                Console.WriteLine("Title: " + Title); 
                Console.WriteLine("Rating: " + Rating);
                Console.WriteLine("How often: " + Type);
            }

            Console.WriteLine();
        }
        public override string ToString()
        {
            return $"Get information from -PrintInfoPerson- method.";
        }
        public enum Frequency
        { Weekly, Monthly, Yearly}
    }
}
