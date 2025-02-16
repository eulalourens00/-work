namespace ПР_10_11._02._2025_
{
    internal class Program
    {
        //1.
        static void summa_of_number()
        {
            Console.Write("Enter a word-operation (a, b, c, d): ");
            string caase = Console.ReadLine();
            switch (caase)
            {
                case "a":
                    int summa_a = 0;
                    for (int i = 100; i <= 500; i++) { summa_a += i; }
                    Console.WriteLine($"Summa = {summa_a}");
                    break;

                case "b":
                    Console.Write("A (a < 500): ");
                    int a = int.Parse(Console.ReadLine());
                    if (a < 500)
                    {
                        int summa_b = 0;
                        for (int i = a; i <= 500; i++) { summa_b += i; }
                        Console.WriteLine($"Summa = {summa_b}");
                    }
                    break;

                case "c":
                    Console.Write("B (b > -10): ");
                    int b = int.Parse(Console.ReadLine());
                    if (b > -10)
                    {
                        int summa_c = 0;
                        for (int i = b; i >= -10; i--) { summa_c += i; }
                        Console.WriteLine($"Summa = {summa_c}");
                    }
                    break;

                case "d":
                    Console.Write("A and B (b > a): ");
                    string[] nums = Console.ReadLine().Split();
                    int value_a = int.Parse(nums[0]);
                    int value_b = int.Parse(nums[1]);

                    if (value_b > value_a)
                    {
                        int summa_ab = 0;
                        for (int i = value_a; value_b >= i; i++ ) { summa_ab += i; }
                    }
                    break;

                default:
                    Console.WriteLine("Invalid opeation. Try again.");
                    break;
            }
                
                    


        }
        //2.
        static double chain()
        {
            double x;
            Console.Write("Enter x: ");
            x = double.Parse(Console.ReadLine());

            double sum = 1 - 1 / (double)2;
            for (double i = 3; i <= x; i++) { sum += 1.0 / i; }
            Console.WriteLine($"Sum: {Math.Round(sum, 4)}");
            return sum;
        }
        //3.
        static void stolb_sqrt()
        {
            Console.Write("Enter two numbers (a > b): ");
            string[] numbers = Console.ReadLine().Split();
            double value1 = double.Parse(numbers[0]);
            double value2 = double.Parse(numbers[1]);
            if (value1 > value2) {
                Console.WriteLine("Column of SQRT.");
                do
                {
                    Console.WriteLine($"SQRT of {value1} = {Math.Round(Math.Sqrt(value1), 2)}");
                    value1--;
                } while (value1 >= value2);
            }
            else { Console.WriteLine("Invalid input."); }
        }
        //4.
        static void natural_number()
        {
            Console.Write("Enter a number: ");
            string x = Console.ReadLine();
            int value = int.Parse(x);

            if (value <= 0) { Console.WriteLine("Invalid input."); }
            int count = 0;
            int summa_a = 0;
            int mulp_b = 1;
            int original = value;

            while (value > 0) {
                // summa a)
                int i = value % 10;
                summa_a += i;
                // mulp б)
                mulp_b *= i;

                value = value / 10;
           
                count++;
            }
            Console.WriteLine($"Summa = {summa_a}.");
            Console.WriteLine($"Mulp = {mulp_b}.");
            // в)
            Console.WriteLine($"Its {count}-digit number.");
            if (count % 2 == 0) { Console.WriteLine("Its chetnoe number"); }
            // г)
            if (count == 4) { Console.WriteLine("True. 4-digit"); }
            // д)
            while(value > 10)
            {
                value = value / 10;
            }
            if (value <= 6) { Console.WriteLine("Not more 6"); }
            // е)
            if (value == original % 10) { Console.WriteLine("Same start and finish."); }
            // ж)
            if (value > original % 10) { Console.WriteLine($"Start {value} is more."); }
            else { Console.WriteLine($"Finish {original % 10} is more."); }
        }
        static void Main(string[] args)
        {
            ////1.
            //summa_of_number();
            ////2.
            //chain();
            ////3.
            //stolb_sqrt();
            //4.
            natural_number();
            //5.
            //6.
            //7.
            //8.
            //9.
            //10.
        }
    }
}
