using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace _20_Pract_Classes_WebSite__Journal__Store_
{
    internal class WebSite
    {
        public string NameWeb {  get; set; }
        public string WayWeb { get; set; }
        public string Discription {  get; set; }
        public int ID { get; set; }

        public void AddData()
        {
            Console.WriteLine("\t--Add data about Web Site--");
            Console.Write("Name: ");
            NameWeb = Console.ReadLine();
            Console.Write("\nWay: ");
            WayWeb = Console.ReadLine();

            Console.Write("Discription: ");
            Discription = Console.ReadLine();

            Console.Write("ID: ");
            Int32.TryParse(Console.ReadLine(), out int id);
            ID = id;
        }

        public override string ToString()
        {
            return $"{NameWeb}. {WayWeb}. \n" +
                $"- {Discription}.\n- {ID}";
        }

        public void GetName()
        { Console.WriteLine($"{NameWeb}"); }
        public void GetWay()
        { Console.WriteLine($"{WayWeb}"); }
        public void GetDiscription()
        { Console.WriteLine(Discription); }
        public void GetID()
        { Console.WriteLine($"{ID}"); }
    }
}
