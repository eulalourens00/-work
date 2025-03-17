using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ildar_1para
{
    public abstract class Enemy
    {
        public int HP { get; private set; } = 100;
        public int Power { get; private set; } = 15;
        public abstract void Fight();
        public void Take_Damage(int damage)
        {
            HP -= damage;
            if (HP > 0) { Console.WriteLine($"Enemy takes {damage} damage! Remaining HP is {HP}!\n "); }
            else { Console.WriteLine($"Enemy takes {damage} damage! FIGHT! DIED!\n"); HP = 0; }
        }
    }
}
