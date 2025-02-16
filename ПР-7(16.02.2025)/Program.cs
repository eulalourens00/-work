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
            if (input.Length != 4) { Console.WriteLine("Not 4-digit-number."); return same; }

            string[] one_of_number = input.Split();
            int[] values = new int[4];

            for (int i = 0; i < 4; i++) { values[i] = input[i] - '0'; }
            for (int i = 0; i < values.Length; i++)
            {
                int count = 0;
                for (int j = 0; j < values.Length; j++)
                {
                    if (values[i] == values[j]) { count++; }
                }
                if (count == 3) { same = true; }
            }

            return same;
        }
            
        //3.
        static int ret_vesche()
        {
            int count = 0;
            Console.Write("Enter 4 numbers: ");
            string[] numbers = Console.ReadLine().Split();

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

            // xxx
            int last_1 = value1 % 10;
            int middle_1 = (value1 / 10) % 10; 
            int start_1 = value1 / 100;
            // yyy
            int last_2 = value2 % 10;
            int middle_2 = (value2 / 10) % 10;
            int start_2 = value2 / 100;

            double result_middle1;
            if ((start_1 > middle_1 && start_1 < last_1) || (start_1 < middle_1 && start_1 > last_1))
            {
                result_middle1 = start_1;
            }
            else if ((middle_1 > start_1 && middle_1 < last_1) || (middle_1 < start_1 && middle_1 > last_1))
            {
                result_middle1 = middle_1;
            }
            else
            { result_middle1 = last_1; }
            
            double result_middle2;
            if ((start_2 > middle_2 && start_2 < last_2) || (start_2 < middle_2 && start_2 > last_2))
            {
                result_middle2 = start_2;
            }
            else if ((middle_2 > start_2 && middle_2 < last_2) || (middle_2 < start_2 && middle_2 > last_2))
            {
                result_middle2 = middle_2;
            }
            else
            { result_middle2 = last_2; }

            double average = (result_middle1 + result_middle2) / 2;

            Console.WriteLine($"The average of the middle numbers is: {average}");
        }
        //6.
        static void week()
        {
            Console.Write("Enter a number of day in the week: ");
            string num = Console.ReadLine();
            int day = int.Parse(num);
            switch (day)
            {
                case 1:
                    Console.WriteLine($"Monday - {day} day");
                    break;
                case 2:
                    Console.WriteLine($"Tuesday - {day} day");
                    break;
                case 3:
                    Console.WriteLine($"Wednesday - {day} day");
                    break;
                case 4:
                    Console.WriteLine($"Thursday - {day} day");
                    break;
                case 5:
                    Console.WriteLine($"Friday - {day} day");
                    break;
                case 6:
                    Console.WriteLine($"Saturday - {day} day");
                    break;
                case 7:
                    Console.WriteLine($"Sunday - {day} day");
                    break;
                default:
                    Console.WriteLine("Invalid input.");
                    break;
            }
        }
        //7.
        static void months()
        {
            Console.Write("Enter a number of month:");
            string num = Console.ReadLine();
            int month = int.Parse(num);
            switch (month) { 
                case 1:
                    Console.WriteLine($"January - {month} month");
                    break;
                case 2:
                    Console.WriteLine($"February - {month} month");
                    break;
                case 3:
                    Console.WriteLine($"March - {month} month");
                    break;
                case 4:
                    Console.WriteLine($"April - {month} month");
                    break;
                case 5:
                    Console.WriteLine($"May - {month} month");
                    break;
                case 6:
                    Console.WriteLine($"June - {month} month");
                    break;
                case 7:
                    Console.WriteLine($"July - {month} month");
                    break;
                case 8:
                    Console.WriteLine($"August - {month} month");
                    break;
                case 9:
                    Console.WriteLine($"September - {month} month");
                    break;
                case 10:
                    Console.WriteLine($"October - {month} month");
                    break;
                case 11:
                    Console.WriteLine($"November - {month} month");
                    break;
                case 12:
                    Console.WriteLine($"December - {month} month");
                    break;
                default :
                    Console.WriteLine("Invalid input.");
                    break;
            }
        }
        //8.
        static void birthday()
        {
            Console.Write("Enter your date of birthday (year month day): ");
            string[] num = Console.ReadLine().Split();
            int year = int.Parse(num[0]);
            int month = int.Parse(num[1]);
            int day = int.Parse(num[2]);

            DateTime birth = new DateTime(year, month, day);
            int years = DateTime.Now.Year - birth.Year;
            if (DateTime.Now < birth.AddYears(years)) //был ли день рождения (addyears)
            {
                years--;
            }
            Console.WriteLine($"{years} years");
        }
        //9.
        static void column_numbers()
        {
            Console.Write("Enter a case (a, b, c, d): ");
            string word = Console.ReadLine();
            switch (word)
            {
                case "a":
                    for (int i = 20; i <= 35; i++) { Console.WriteLine(i); }
                    break;

                case "b":
                    Console.Write("Enter a number more 10: ");
                    string number = Console.ReadLine();
                    int b1 = int.Parse(number);
                    if(b1 > 10)
                    {
                        for (int i = 10; i <= b1; i++) { Console.WriteLine(Math.Pow(i, 2)); };
                    } else { Console.WriteLine("Invalid input"); }
                    break;
                case "c":
                    Console.Write("Enter a number less 50: ");
                    string num = Console.ReadLine();
                    int c = int.Parse(num);
                    if (c < 50)
                    {
                        for (int i = 50; i >= c; i--) { Console.WriteLine(Math.Pow(i, 3)); };
                    }
                    else { Console.WriteLine("Invalid input"); }
                    break;
                case "d":
                    Console.Write("Enter a and b, where a > b: ");
                    string[] words = Console.ReadLine().Split();
                    int a = int.Parse(words[0]);
                    int b2 = int.Parse(words[1]);
                    for (int i = b2; i <= a; i++) { Console.WriteLine(i); }
                    break;

            }
        }
        //10.
        static void earth()
        {
            const double R = 6370;
            Console.WriteLine("Height (km) | Distance (km)");

            for (int h = 1; h <= 10; h++)
            {
                double distance = Math.Sqrt(2 * R * h + Math.Pow(h, 2));
                Console.WriteLine($"{h} | {Math.Round(distance, 4)}");
            }
        }
        static void Main(string[] args)
        {
            //1.
            NumberIn();
            //2.
            bool result = SameNumbers();
            Console.WriteLine(result);
            //3.
            Console.WriteLine($"Numbers < 0 = {ret_vesche()}");
            //4.
            parabola();
            //5.
            arifmet();
            //6.
            week();
            //7.
            months();
            //8.
            birthday();
            //9.
            column_numbers();
            //10.
            earth();
        }
    }
}
