using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events
{
    internal class Account
    {
        public delegate void AccountHandler(string message);
        AccountHandler? Notify;
        public event AccountHandler? notify
        {
            add
            {
                Notify += value;
                Console.WriteLine($"{value.Method.Name} add");
            }
            remove
            {
                Notify -= value;
                Console.WriteLine($"{value.Method.Name} remove");
            }
        }
        public int Sum { get; set; }
        public Account(int sum) => Sum = sum;

        public void Put(int sum)
        {
            Sum += sum;
            Notify?.Invoke($"На счёт поступило: {sum}");
        }

        public void Take(int sum)
        {
            if (Sum >= sum) { Sum -= sum; Notify?.Invoke($"Со счета сняли: {sum}"); }
            else { Notify?.Invoke($"Loool"); }

        }
    }
}
