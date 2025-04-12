using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Атрибуты
{
    [AttributeUsage(AttributeTargets.Method | AttributeTargets.Class)]
    public class CoderAttribute : Attribute
    {
        string _name = "Leeky";
        DateTime _date = DateTime.Now;
        public CoderAttribute() { }
        public CoderAttribute(string name, string date)
        {
            try
            {
                _name = name; _date = Convert.ToDateTime(date);
            }
            catch (Exception ex) { Console.WriteLine(ex.Message); }
        }
        public override string ToString() { return $"Coder: {_name}, Date: {_date}"; }
    } 
}
