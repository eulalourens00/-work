using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Перегрузка_Структуры_01._03._2025
{
    public abstract class WorldMagic
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string Locationt { get; set; }

        public WorldMagic(string name, string desc, string local)
        {
            Name = name;
            Description = desc;
            Locationt = local;
        }
        public void Info()
        {
            Console.WriteLine($"Its {Name}. {Description}. \nIn {Locationt}");
        }
    }
}
