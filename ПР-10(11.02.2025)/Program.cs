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
            string org = original.ToString();
            int org_length = org.Length;

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
            if (summa_a > 10) { Console.WriteLine("Summa is more 10"); }
            Console.WriteLine($"Mulp = {mulp_b}.");
            if (mulp_b < 50) { Console.WriteLine("Mulp is less 50"); }
            // в)
            Console.WriteLine($"Its {count}-digit number.");
            if (count % 2 == 0) { Console.WriteLine("Its chetnoe count number"); }
            // г)
            if (count == 4) { Console.WriteLine("True. 4-digit"); }
            // д)
            while(value > 10)
            {
                value = value / 10;
            }

            int count_100 = 1;
            while (org_length > 1) { count_100 *= 10; org_length--; }
            int sames = (original / count_100);
            int samef = original % 10;

            if (sames <= 6) { Console.WriteLine("Not more 6"); }
            else { Console.WriteLine("The first sym is more 6"); }
            // е)
            if (sames == samef) { Console.WriteLine("Same start and finish."); }
            else { Console.WriteLine("Not the same finish and start."); }
            // ж)

            if (sames > samef) { Console.WriteLine($"Start {sames} is more."); }
            else if (sames == samef) { Console.WriteLine($"The start {sames} and the finish {samef} is the same. Dont have something's more"); }
            else { Console.WriteLine($"Finish {samef} is more."); }
        }
        //5.
        static int Factorial()
        {
            Console.Write("Enter number: ");
            int fact = 1;
            Int32.TryParse(Console.ReadLine(), out int value);
            for (int i = 1; i <= value; i++) { fact *= i; }
            return fact;
        }
        //6.
        static void K_value()
        {
            Console.Write("Enter number: ");
            Int32.TryParse(Console.ReadLine(), out int value);
            Console.Write("Enter k: "); //1
            Int32.TryParse(Console.ReadLine(), out int k);
            Console.Write("Enter b: ");//2
            Int32.TryParse(Console.ReadLine(), out int b);
            Console.Write("Enter x and y: "); //3
            string[] coor = Console.ReadLine().Split();
            int x = int.Parse(coor[0]);
            int y = int.Parse(coor[1]);
            Console.Write("Enter a: ");//4
            Int32.TryParse(Console.ReadLine(), out int a);
            Console.Write("Enter m and n: "); //5
            string[] mn = Console.ReadLine().Split();
            int m = int.Parse(mn[0]);
            int n = int.Parse(mn[1]);


            int save_value = value;
            int summa = 0;
            int count = 0;
            //a
            int i = 0;
            while (value > 0) { i = value % 10; summa += i; count++; value /= 10; }

            if (save_value % 2 == 0 && summa > k) { Console.WriteLine("Chetnoe number. And summa is more value."); }
            else { Console.WriteLine("Conditions is false"); }
            //б
            if (count % 2 == 0 && save_value <= b) { Console.WriteLine("Chetnoe count. And number doesnt more value."); }
            else { Console.WriteLine("Conditions is false"); }
            //в
            int ii = 1;
            while(count > 1) { ii *= 10; count--;}
            int sames = save_value / ii;
            int samef = save_value % 10;
            if (sames == x && samef == y) { Console.WriteLine("True. Start = x and finish = y"); }
            else { Console.WriteLine("False."); }
            //г
            int mulp = 1;
            while (save_value > 1) { mulp *= save_value % 10; save_value /= 10; }
            if (mulp < a && save_value / b == 0) { Console.WriteLine($"True. Mulp {mulp} is less a, and value / b = 0"); }
            else { Console.WriteLine("False."); }
            //д
            if (summa > m && save_value / n == 0) { Console.WriteLine($"True. Summa {summa} is more m, and value / n = 0"); }
            else { Console.WriteLine("False."); }
        }
        //7
        static int NegativeNum()
        {
            int count = 0;
            Console.WriteLine("Enter a list of numbers: ");

        }
        static void Main(string[] args)
        {
            ////1.
            //summa_of_number();
            ////2.
            //chain();
            ////3.
            //stolb_sqrt();
            ////4.
            //natural_number();
            ////5.
            //int result = Factorial();
            //Console.WriteLine($"Result = {result}");
            ////6.
            //K_value();
            //7.
            //8.
            //9.
            //10.
        }
    }
}
