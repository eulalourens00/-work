using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _29Pract
{
    public class BankAccount2
    {
        private int IdAccount;
        private double Balance;
        private Type _Type;

        public enum Type { Credit, Deposit, Funded }
        public BankAccount2() { }

        public void AddData()
        {
            Console.Write("Balance: ");
            Double.TryParse(Console.ReadLine(), out Balance);
            Console.Write("Type (Credit, Deposit, Funded) - 1, 2, 3: ");
            Int32.TryParse(Console.ReadLine(), out int type);
            switch (type)
            {
                case 1: _Type = Type.Credit; break;
                case 2: _Type = Type.Deposit; break;
                case 3: _Type = Type.Funded; break;
                default: throw new ArgumentException("Wrong case.");
            }
            Random random = new Random();
            IdAccount = random.Next();
        }
        public override string ToString()
        {
            return $"{IdAccount} - {_Type}\nAmount: {Balance}";
        }
        public void Plus()
        {
            Console.Write($"Balance: {Balance}");
            Console.Write("\nAmount to plus: ");
            Double.TryParse(Console.ReadLine(), out double amount);
            if (amount > 0) { Balance += amount; }
            else { throw new InvalidDataException(); }
            Console.Write($"Updated balance: {Balance}");
        }
        public void Minus()
        {
            Console.Write($"Balance: {Balance}");
            Console.Write("\nAmount to minus: ");
            Double.TryParse(Console.ReadLine(), out double amount);
            if (amount > 0 && Balance >= amount) { Balance -= amount; }
            else { throw new InvalidDataException(); }
            Console.Write($"Updated balance: {Balance}");
        }
    }
}
