namespace UniTests_Модульное_Тестирование
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BankAccount ba = new BankAccount("Leeky Suya", 7000);
            ba.Credit(200.00);
            ba.Debit(500.00);
            Console.WriteLine($"Balance: {ba.Balance}");
        }
    }
}
