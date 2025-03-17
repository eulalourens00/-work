using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ildar_1para
{
    internal class Character
    {
        public string Name { get; set; }
        public int HP { get; private set; } = 150;
        public int Power { get; private set; } = 25;
        public CharacterType Type { get; set; }
        public WiaponType Wiapon { get; set; }
        public Character(string name, CharacterType type, WiaponType wiapon)
        {
            Name = name;
            Type = type;
            Wiapon = wiapon;
        }

        public enum CharacterType
        {
            MainDPS, Hiller, Shield, Support
        }
        public enum WiaponType
        {
            Sword, Catalyst, Spear, TwoHandedSword, Arrow
        }
        public void TakeDamage(int damage)
        {
            HP -= damage;
            if (HP > 0) { Console.WriteLine($"{Name} takes {damage} damage! Remaining HP is {HP}\n "); }
            else { Console.WriteLine($"Enemy takes {damage} damage! FIGHT! DIED!\n"); HP = 0; }
        }
    }
}
