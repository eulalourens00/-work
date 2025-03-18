using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20Pract
{
    internal class Airplane
    {
        public string Name { get; set; }
        public string Manufacturer { get; set; }
        public DateTime DateTime { get; set; }

        public AirplaneType Type { get; set; }
        public enum AirplaneType { military, civilian }

        public void AddData()
        {
            Console.WriteLine("\t--Add data about airplane--");
            Console.Write("Name: ");
            Name = Console.ReadLine();
            Console.Write("\nManifacturer: ");
            Manufacturer = Console.ReadLine();

            Console.Write("Date (yyyy-mm-dd): ");
            DateTime.TryParse(Console.ReadLine(), out DateTime date);
            DateTime = date;

            Console.Write("Type (Military, Civilian): ");
            Enum.TryParse<AirplaneType>(Console.ReadLine(), true, out AirplaneType type);
            Type = type;
        }

        public override string ToString()
        {
            return $"{Name}. By {Manufacturer}. \n" +
                $"DateTime - {DateTime}. Type - {Type}";
        }

        public void GetName()
        {  Console.WriteLine($"Its {Name}"); }
        public void GetManufacturer()
        { Console.WriteLine($"By {Manufacturer}"); }
        public void GetDate()
        { Console.WriteLine(DateTime); }
        public void GetType()
        { Console.WriteLine($"{Type}");}
    }
}
