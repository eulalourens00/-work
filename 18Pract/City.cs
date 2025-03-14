using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18Pract
{
    internal class City
    {
        public string Country { get; set; }
        public string NameOfCity { get; set; }
        public int CountOfPeople { get; set; }
        public string CodeOfPhone { get; set; }
        public List<string>NameOfArea { get; set; } = new List<string>();

        //public City(string country, string name_of_country, int count_of_people, string code_of_phone, string[] name_of_area) 
        //{ 
        //    Country = country; NameOfArea = name_of_area; CountOfPeople = count_of_people; CodeOfPhone = code_of_phone; NameOfArea = name_of_area;
        //}

        public void AddData()
        {
            Console.WriteLine("\t--Add data about the city--");
            Console.Write("Country: ");
            Country = Console.ReadLine();
            Console.Write("\nCity: ");
            NameOfCity = Console.ReadLine();

            Console.Write("\nPopulation: ");
            string People = Console.ReadLine();
            if(Int32.TryParse(People, out int value)) { if (value > 0) { CountOfPeople = value; } else { throw new InvalidOperationException(); } }

            Console.Write("\nCode of phone: ");
            CodeOfPhone = Console.ReadLine();

            Console.WriteLine();
            Console.WriteLine("\t--Areas in the city (press empty string to finish)--");
            Console.WriteLine("Areas: ");
            while (true)
            {
                string area = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(area)) { break; }
                NameOfArea.Add(area);
            }
        }

        public override string ToString()
        {
            return $"Country - {Country}. City - {NameOfCity}. \n" +
                $"Count of people - {CountOfPeople}. Code of phone - {CodeOfPhone} \n"
                + $"Area in the city: {string.Join(", ", NameOfArea )}";
        }

        public void GetCountry()
        {
            Console.WriteLine($"Its {Country}");
        }
        public void GetNameOfCity() {
            Console.WriteLine($"Its {NameOfCity}");
        }
        public int GetCountOfPeople() { 
            return CountOfPeople;
        }
        public void GetCodePhone()
        {
            Console.WriteLine($"Code {CodeOfPhone}");
        }
        public void GetNameOfArea() {
            Console.WriteLine($"Here {string.Join(", ", NameOfArea)}");
        }
    }
}
