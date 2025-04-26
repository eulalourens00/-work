namespace _32Pract_Счет_для_оплаты
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var invoice = new Pay(1500m, 10, 100m, 3);

            Console.WriteLine("Исходный счет:");
            Console.WriteLine(invoice);
            Console.WriteLine();

            //  с вычисляемыми полями
            Pay.SerializeCalculatedFields = true;
            invoice.SaveToFile("invoice_with_calc.dat");
            var loaded = Pay.LoadFromFile("invoice_with_calc.dat");
            Console.WriteLine("Счет:");
            Console.WriteLine(loaded);
            Console.WriteLine();

            // без вычисляемых полей
            Pay.SerializeCalculatedFields = false;
            invoice.SaveToFile("invoice_without_calc.dat");
            loaded = Pay.LoadFromFile("invoice_without_calc.dat");
            Console.WriteLine("Счет:");
            Console.WriteLine(loaded);
        }
    }
}
