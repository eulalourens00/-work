using System.IO;

namespace ПР_7_16._02._2025_
{
    internal class Program
    {
        //1.
        static bool NumberIn()
        {
            Console.Write("Enter a 2digit-number: ");
            string number = Console.ReadLine();
            int num = int.Parse(number);
            if (num < 10 || num > 99)
            {
                Console.WriteLine("Not 2-digit number.");
                return false;
            }

            int s_part = num % 10;
            int f_part = num / 10;
            int[] parts = new int[] { s_part, f_part };

            Console.WriteLine("Parts: " + string.Join(", ", parts));

            bool met = false;
            for (int i = 0; i < parts.Length; i++)
            {
                if (parts[i] == 4 || parts[i] == 7)
                {
                    Console.WriteLine("The first condition is true.");
                    met = true;
                }
                else if (parts[i] == 3 || parts[i] == 6 || parts[i] == 9)
                {
                    Console.WriteLine("The second condition is true.");
                    met = true;
                }
            }

            if (met == false) { Console.WriteLine("Every condition is false."); }

            return met;
        }


        //2.
        static bool SameNumbers()
        {
            Console.Write("4-digit-number: ");
            bool same = false;
            string input = Console.ReadLine();
            //if(input.Length > 4 || input.Length < 4) { Console.WriteLine("Not 4-digit-number."); return same; }

            //string[] one_of_number = input.Split();
            int four_number = int.Parse(input);
            int[] values = new int[4];
            while(four_number > 0)
            {
                int i = four_number % 10;
                four_number /= 10;
                values = new int[i];
            }

            Console.WriteLine("Parts: " + string.Join(", ", values));
            int count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for(int j = i + 1; j < values.Length; j++)
                {
                    if (values[i] == values[j])
                    {
                        count++;
                    }
                }
            }
            if(count == 3) { same = true; }
            return same;
        }
        //3.
        static int ret_vesche()
        {
            int count = 0;
            Console.Write("Enter 4 numbers: ");
            string[] numbers = Console.ReadLine().Split();
            //int [] values = new int[numbers.Length];
            //values.Append(int.Parse(numbers[0]));
            //values.Append(int.Parse(numbers[1]));
            //values.Append(int.Parse(numbers[2]));
            //values.Append(int.Parse(numbers[3]));

            int values1 =(int.Parse(numbers[0]));
            int values2 =(int.Parse(numbers[1]));
            int values3 =(int.Parse(numbers[2]));
            int values4 =(int.Parse(numbers[3]));
            if (values1 < 0)
            {
                count++;
            }
            if (values2 < 0)
            {
                count++;
            }
            if (values3 < 0)
            {
                count++;
            }
            if (values4 < 0)
            {
                count++;
            }
            return count;

        }
        //4.
        static bool parabola()
        {
            Console.Write("Enter A, B, C (A != 0): ");
            string[] numbers = Console.ReadLine().Split();
            int value_A = int.Parse(numbers[0]);
            int value_B = int.Parse(numbers[1]);
            int value_C = int.Parse(numbers[2]);

            double Des = MathF.Pow(value_B, 2) - (4 * value_A * value_C);
            Console.WriteLine($"D = {Des}");

            if(Des > 0)
            {
                double x1 = -value_B + Math.Sqrt(Des) / 2 * value_A;
                double x2 = -value_B - Math.Sqrt(Des) / 2 * value_A;
                Console.WriteLine($"X1 = {Math.Round(x1, 2)}; X2 = {Math.Round(x2, 2)}");
                return true;
            }
            else if (Des == 0)
            {
                double x = - value_B / 2* value_A;
                Console.WriteLine($"X = {Math.Round(x, 2)}");
                return true;
            }
            else
            {
                Console.WriteLine("NO Veschestvennae SQRT ");
            }
            return false;
        }

        //5.
        static void arifmet()
        {
            Console.Write("Enter two 3-digit-numbers (xxx yyy): ");
            string[] numbers = Console.ReadLine().Split();
            int value1 = int.Parse(numbers[0]);
            int value2 = int.Parse(numbers[1]);
            
            int last_1 = value1 % 10;
            int s_1 = (last_1 / 10)/10;
            value1 = (last_1 / 10) % 10;
            //321 l = 1 s = 3 v = 2
            if (s_1 > last_1 && s_1 > value1) // s = max
            {
                if (last_1 < value1) { //middle = 2
                    Console.WriteLine($"The missle of the first = {value1}");
                }
            }
            else if ()
            {

            }

            int last_2 = value2 % 10;
            int s_2 = last_2 / 10;

        }
        static void Main(string[] args)
        {
            ////1.
            //NumberIn();

            ////2.
            //SameNumbers();
        //    //3.
        //    Console.WriteLine($"Numbers < 0 = {ret_vesche()}");
        //    //4.
        //    parabola();
            //5.
            arifmet();
        }
    }
}
