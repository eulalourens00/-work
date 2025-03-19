using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23_Pract_24._03._2025_
{
    internal class Money
    {
        public double Amount {  get; set; }
        public double MoneyForOperation;

        public Money(double amount) { Amount = amount; }

        public double TopUpBalance()
        {
            Console.Write("Amount for top up the balance: ");
            Double.TryParse(Console.ReadLine(), out double summa);
            MoneyForOperation = summa;
            if(MoneyForOperation > 0) { return Amount + MoneyForOperation; }
            else { throw new InvalidOperationException(); }
            Console.Write($"Balance {Amount}");
        }
        public double TopDownBalance() {

            Console.Write("Amount for top down the balance: ");
            Double.TryParse(Console.ReadLine(), out double summa);
            MoneyForOperation = summa;

            if(Amount - MoneyForOperation <= 0) { throw new Exception("Bancrot"); }

            if (MoneyForOperation > 0 && Amount >= MoneyForOperation) { return Amount - MoneyForOperation; }
            else { throw new InvalidOperationException(); }
            Console.Write($"Balance {Amount}");
        }

        public double DivBalance()
        {
            Console.Write("Amount for top div the balance: ");
            Double.TryParse(Console.ReadLine(), out double summa);
            MoneyForOperation = summa;

            if (Amount / MoneyForOperation <= 0) { throw new Exception("Bancrot"); }

            if (MoneyForOperation > 0 && Amount >= MoneyForOperation) { return Amount / MoneyForOperation; }
            else { throw new DivideByZeroException(); }
            Console.Write($"Balance {Amount}");
        }

        public double MulBalance()
        {
            Console.Write("Amount for top mul the balance: ");
            Double.TryParse(Console.ReadLine(), out double summa);
            MoneyForOperation = summa;

            if (Amount * MoneyForOperation <= 0) { throw new Exception("Bancrot"); }

            if (MoneyForOperation > 0 && Amount >= MoneyForOperation) { return Amount * MoneyForOperation; }
            else { throw new InvalidOperationException(); }
            Console.Write($"Balance {Amount}");
        }

        public double CentePlus()
        {
            for(int i = 0; i < 100; i++) { Amount += 0.1; }
            return Amount;
        }
        public double CenteMinus()
        {
            for (int i = 0; i < 100; i++) { if (Amount >= 0.1) Amount -= 0.1; else { throw new InvalidOperationException(); } }
            return Amount;
        }
    }
}
