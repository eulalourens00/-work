using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ildar_1para
{
    internal class Warrior: Character
    {
        public Warrior(string name) : base(name, CharacterType.MainDPS, WiaponType.Spear) { }

        public void Attack(Enemy enemy)
        {
            Console.WriteLine($"{Name} attacks!\n");
            enemy.Take_Damage(Power);
        }
    }
}
