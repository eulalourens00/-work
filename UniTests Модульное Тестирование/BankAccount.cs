using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniTests_Модульное_Тестирование
{
    public class BankAccount
    {
        private readonly string m_customerName;
        private double m_balance;
        private BankAccount() { }
        public BankAccount(string customerName, double balance)
        {
            m_customerName = customerName;
            m_balance = balance;
        }
        public string m_CustomerName
        {
            get { return m_customerName; }
        }
        public double Balance
        {
            get { return m_balance; }
        }
        public void Debit(double amount)
        {
            if (amount > m_balance) { throw new ArgumentOutOfRangeException("Amount objection!"); }
            if (amount < 0) { throw new ArgumentOutOfRangeException("Amount objection! Its 0"); }
            m_balance -= amount;
        }
        public void Credit(double amount)
        {
            if (amount < 0) { throw new ArgumentOutOfRangeException("Credit objection!"); }
            m_balance += amount;
        }
    }
}
