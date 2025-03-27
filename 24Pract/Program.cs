namespace _24Pract
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1.
            Magazine_Employees employees = new Magazine_Employees(50);
            employees.AddEmployee();
            employees.SubEmployee();
            employees.EqualsEmployees();

            //2.
            Store area = new Store(1500);
            area.AddArea();
            area.SubArea();
            area.EqualsArea();

            //3.
            Books books = new Books();
            books.AddBooks();
            books.DeleteBooks();
            books.CheckBooks();

            //4.
            MathTask mathTask = new MathTask();
            mathTask.Task();

            //5.
            Symbols_INT_0_9 sym = new Symbols_INT_0_9();
            sym.GetInt();

            //6.
            Square square = new Square(5, 'L');
            square.Draw();

            //7.
            Palindrom palindrom = new Palindrom();
            palindrom.Check();

            //8.
            SystemNumber systemNumber = new SystemNumber();
            NumberConverter converter = new NumberConverter();
            bool exit = false;

            while (!exit)
            {
                systemNumber.DisplayMenu();
                int choice = systemNumber.GetSystemChoice();

                switch (choice)
                {
                    case 1: // 10
                        Console.Write("10-value: ");
                        if (int.TryParse(Console.ReadLine(), out int decimalNumber1))
                        {
                            Console.WriteLine($"2-System: {converter.DecimalToBinary(decimalNumber1)}");
                            Console.WriteLine($"8-System: {converter.DecimalToOctal(decimalNumber1)}");
                            Console.WriteLine($"16-System: {converter.DecimalToHexadecimal(decimalNumber1)}");
                        }
                        else
                        {
                            Console.WriteLine("Invalid data.");
                        }
                        break;

                    case 2: // 2
                        Console.Write("2-value: ");
                        string binaryInput = Console.ReadLine();
                        try
                        {
                            int decimalResult1 = converter.BinaryToDecimal(binaryInput);
                            Console.WriteLine($"10-System: {decimalResult1}");
                        }
                        catch (FormatException)
                        {
                            Console.WriteLine("Invalid data.");
                        }
                        break;

                    case 3: // 8
                        Console.Write("8-value: ");
                        string octalInput = Console.ReadLine();
                        try
                        {
                            int decimalResult2 = converter.OctalToDecimal(octalInput);
                            Console.WriteLine($"10-System: {decimalResult2}");
                        }
                        catch (FormatException)
                        {
                            Console.WriteLine("Invalid data.");
                        }
                        break;

                    case 4: // 16
                        Console.Write("16-value: ");
                        string hexInput = Console.ReadLine();
                        try
                        {
                            int decimalResult3 = converter.HexadecimalToDecimal(hexInput);
                            Console.WriteLine($"10-System: {decimalResult3}");
                        }
                        catch (FormatException)
                        {
                            Console.WriteLine("Invalid data.");
                        }
                        break;

                    case 5: // Выход
                        exit = true;
                        break;

                    default:
                        Console.WriteLine("Invalid data.");
                        break;
                }

                Console.WriteLine();
            }
        }
    }
}
