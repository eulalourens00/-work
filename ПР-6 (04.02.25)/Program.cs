namespace ПР_6__04._02._25_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1.
            Veschestvenn();
            //2.
            Console.Write("Enter a, b (numbers), c, d (result): ");
            string[] numbers = Console.ReadLine().Split();
            int num_a = int.Parse(numbers[0]);
            int num_b = int.Parse(numbers[1]);
            int res_c = int.Parse(numbers[2]);
            int res_d = int.Parse(numbers[2]);

            Console.WriteLine(div(num_a, num_b, res_c, res_d));

            //3.
            int[] result = max_min();
            Console.WriteLine($"Max: {result[0]}, Min: {result[1]}");

            //4.
            double[] absolute_result = absolute_numbers();
            Console.WriteLine($"Absolute half-sum is {absolute_result[0]}. Absolute pow is {absolute_result[1]}");

            //5.
            Console.Write("Enter three param of hight people: ");
            string[] hight = Console.ReadLine().Split();
            int hight_1 = int.Parse(hight[0]);
            int hight_2 = int.Parse(hight[1]);
            int hight_3 = int.Parse(hight[2]);

            Console.WriteLine(hight_people(hight_1, hight_2, hight_3));

            //6.
            sumbist();
        }

        //1.
        static void Veschestvenn()
        {
            Console.Write("Enter a, b, c: ");
            string[] numbers = Console.ReadLine().Split();
            int a = int.Parse(numbers[0]);
            int b = int.Parse(numbers[1]);
            int c = int.Parse(numbers[2]);

            Console.WriteLine("Lets check condition.");
            if (a < b && b < c)
            {
                Console.WriteLine("The first condition is right. a < b < c");
            }
            else if (b > a && a > c)
            {
                Console.WriteLine("The second condition is right. b > a > c");
            }
            else
            {
                Console.WriteLine("Nothing is right.");
            }
        }

        //2.
        static bool div(int num_a, int num_b, int res_c, int res_d)
        {
            if(num_a < 0 || num_b < 0)
            {
                Console.WriteLine("You cannot use numbers which < 0");
                return false;
            }
            else
            {
                if (num_a % num_b == res_c || num_a % num_b == res_d) {
                    return true;                   
                }
                else
                { 
                    return false;
                }
            }
        }
        //3.
        static int[] max_min()
        {
            Console.Write("Enter 4 numbers: ");
            string[] four_numbers = Console.ReadLine().Split();
            int num1 = int.Parse(four_numbers[0]);
            int num2 = int.Parse(four_numbers[1]);
            int num3 = int.Parse(four_numbers[2]);
            int num4 = int.Parse(four_numbers[3]);

            int result_max1 = Math.Max(num1, num2);
            int result_max2 = Math.Max(num3, num4);

            int result_max = Math.Max(Math.Max(num1, num2), Math.Max(num3, num4));
            int result_min = Math.Min(Math.Min(num1, num2), Math.Min(num3, num4));

            return new int[] { result_max, result_min };
        }

        //4.
        static double[] absolute_numbers()
        {
            Console.Write("Enter two absolute numbers (x > 0): ");
            string[] two_absolute = Console.ReadLine().Split();
            double f_abs = double.Parse(two_absolute[0]);
            double s_abs = double.Parse(two_absolute[1]);
            if(f_abs < 0 || s_abs < 0)
            {
                Console.WriteLine("Absolute numbers cant be less 0.");
                return new double[0];
            }
            else
            {
                double result_sum = (f_abs + s_abs) / 2;
                double result_pow = Math.Pow(2, (f_abs * s_abs));
                return new double[] { result_sum, Math.Round(result_pow, 4) };
            }
        }

        //5.
        static bool hight_people(int hight_1, int hight_2, int hight_3) {
            if (hight_1 == hight_2 && hight_2 == hight_3) {
                return true;
            }
            else
            {
                return false;
            }
        }

        //6.
        static void sumbist()
        {
            Console.Write("Enter sumbist weight: ");
            string weight = Console.ReadLine();
            double sumb_weight = double.Parse(weight);

            if(sumb_weight > 69)
            {
                Console.WriteLine("No for these categories.");
            }
            else if(sumb_weight <= 60)
            {
                Console.WriteLine("The first category. (max 60)");
            }
            else if(sumb_weight <= 64)
            {
                Console.WriteLine("The second category. (max 64)");
            }
            else if(sumb_weight <= 69)
            {
                Console.WriteLine("The three category. (max 69)");
            }
        }
    }   
}
