﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _31Pract_Pattern_08._04._2025
{
    public class PepsiB: BottleAbst
    {
        public override void Interact(WaterAbst water)
        { Console.WriteLine("Бутылка пепси, йоу");}
    }
}
