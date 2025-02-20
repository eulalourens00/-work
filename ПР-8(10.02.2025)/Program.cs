namespace ПР_8_10._02._2025_
{

    internal class Program
    {
        //1.
        static void coordinates()
        {
            Console.Write("Enter X and Y where its != 0");
            string[] xy = Console.ReadLine().Split();
            int value_x = int.Parse(xy[0]);
            int value_y = int.Parse(xy[1]);
            if (value_x > 0 && value_y > 0) { Console.WriteLine("I part"); }
            else if (value_x < 0 && value_y > 0) { Console.WriteLine("II part"); }
            else if (value_x < 0 && value_y < 0) { Console.WriteLine("III part"); }
            else { Console.WriteLine("IV part"); }
        }
        //2.
        static bool HappyNumber()
        {
            Console.Write("Enter a 6-digit number: ");
            string check = Console.ReadLine();
            if (check.Length == 6)
            {
                int value = int.Parse(check);
                int summa1 = 0; int summa2 = 0;
                for (int i = 0; i < 3; i++)
                {
                    summa1 += value % 10;
                    value /= 10;
                }
                for (int j = 0; j < 3; j++)
                {
                    summa2 += value % 10;
                    value /= 10;
                }
                if (summa1 == summa2) { Console.WriteLine("It is a happy number! (❁´◡`❁) "); return true; }
                else { Console.WriteLine("Somethings going bad.."); return false; }
            }
            else { Console.WriteLine("Invalid input."); }
            return false;
        }
        //3.
        static void Year()
        {
            Console.Write("Enter a number of the day in the year: ");
            Int32.TryParse(Console.ReadLine(), out int day);
            int d = 1;
            if (day >= 1 && day <= 365)
            {
                int IndexDay = (d - 1 + (day - 1)) % 7;
                string NameOfDay = "Invalid input.";
                switch (IndexDay)
                {
                    case 0: NameOfDay = "Monday"; break;
                    case 1: NameOfDay = "Tueday"; break;
                    case 2: NameOfDay = "Wednesday"; break;
                    case 3: NameOfDay = "Thursday"; break;
                    case 4: NameOfDay = "Friday"; break;
                    case 5: NameOfDay = "Saturday"; break;
                    case 6: NameOfDay = "Sunday"; break;

                    default: Console.WriteLine("Invalid input."); break;
                }
                Console.WriteLine($"{day} day in the year - {NameOfDay}");
            }
            else { Console.WriteLine("Invalid input."); }
        }
        //4.
        static void Date()
        {
            Console.Write("Choose a month (1-12): ");
            Int32.TryParse(Console.ReadLine(), out int month);
            Console.Write("\nAnd choose a day (1-31): ");
            Int32.TryParse(Console.ReadLine(), out int day);

            int[] DaysInMonth = { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };

            if (day == 1)
            { month--; day = DaysInMonth[month - 1]; }
            else {day--;}
            Console.WriteLine($"Yesterday: {month}.{day}");

            if (day == DaysInMonth[month - 1])
            { day = 1; month++; } else {day+=2; }

            Console.WriteLine($"Tomorrow: {month}.{day}");

        }
        //5.
        static void Rectangle()
        {
            Console.Write("Enter sides of the rectangle: ");
            string[] sides = Console.ReadLine().Split();
            int a = int.Parse(sides[0]);
            int b = int.Parse(sides[1]);
            int c = int.Parse(sides[2]);

            int TbiggestS = 0;
            if (a > b && a > c)
            {
                TbiggestS = a;
                if ((b + c) >= TbiggestS)
                {
                    Console.Write("Possibility is true");
                }
            }
            else if (b > a && b > c)
            {
                TbiggestS = b;
                if ((a + c) >= TbiggestS) { Console.Write("Possibility is true"); }
            }
            else if (c > a && c > b)
            {
                TbiggestS = c;
                if ((a + b) >= c) { Console.Write("Possibility is true"); }
            }
            else if (a == b && b == c) { Console.Write("Possibility is true"); }
            else { Console.Write("Possibility is false"); }
            //6. func under
            if (Math.Pow(a, 2) + Math.Pow(b, 2) == Math.Pow(c, 2)) { Console.Write("\nA 90-rectangle is true"); }
            else { Console.Write("\nA 90-rectangle is false"); }
        }
        //7
        static void Cheese()
        {
            Console.Write("Enter a cheese price: ");
            Int32.TryParse(Console.ReadLine(), out int price);
            int miniprice = 0;
            for(int i = 50; i <= 1000; i+=50)
            {
                miniprice = (i * price) / 1000;
                Console.WriteLine($"{i} = {miniprice}");
            }
        }
        //8
        static void ColumnDouble()
        {
            for(int i = 21; i <= 28; i ++)
            {
                double j = i / 10.0;
                Console.WriteLine(j);
            }
        }
        //9
        static void summ()
        {
            Console.Write("Enter a case (a, b, c, d): ");
            string word = Console.ReadLine();
            int summa = 0;
            switch (word)
            {
                case "a":
                    for (int i = 100; i <= 500; i++) { summa += i; }
                    Console.WriteLine(summa);
                    break;

                case "b":
                    Console.Write("Enter a < 500: ");
                    string number = Console.ReadLine();
                    int b1 = int.Parse(number);

                    if (b1 < 500)
                    {
                        for (int i = b1; i <= 500; i++) { summa += i; };
                    }
                    else { Console.WriteLine("Invalid input"); }
                    Console.WriteLine(summa);
                    break;

                case "c":
                    Console.Write("Enter a number > -10: ");
                    string num = Console.ReadLine();
                    int c = int.Parse(num);
                    if (c > -10)
                    {
                        for (int i = c; i >= c; i--) { summa+=i; };
                    }
                    else { Console.WriteLine("Invalid input"); }
                    Console.WriteLine(summa);
                    break;

                case "d":
                    Console.Write("Enter a and b, where b > a: ");
                    string[] words = Console.ReadLine().Split();
                    int a = int.Parse(words[0]);
                    int b2 = int.Parse(words[1]);
                    for (int i = a; i <= b2; i++) { summa+=i; }
                    Console.WriteLine(summa);
                    break;
                default: Console.WriteLine("Invalid input."); break;
            }
        }
        //10
        static void mult()
        {
            Console.Write("Enter a case (a, b, c, d): ");
            string word = Console.ReadLine();
            int mult = 1;
            switch (word)
            {
                case "a":
                    for (int i = 8; i <= 15; i++) { mult *= i; }
                    Console.WriteLine(mult);
                    break;

                case "b":
                    Console.Write("Enter 1 <= a < <= 20: ");
                    string number = Console.ReadLine();
                    int b1 = int.Parse(number);

                    if (b1 <= 20 && b1 >=1)
                    {
                        for (int i = b1; i <= b1; i++) { mult *= i; };
                    }
                    else { Console.WriteLine("Invalid input"); }
                    Console.WriteLine(mult);
                    break;

                case "c":
                    Console.Write("Enter a number less 20 and more 1: ");
                    string num = Console.ReadLine();
                    int c = int.Parse(num);
                    if (c >= 1 && c <= 20)
                    {
                        for (int i = c; c <=20; i++) { mult *= i; };
                    }
                    else { Console.WriteLine("Invalid input"); }
                    Console.WriteLine(mult);
                    break;

                case "d":
                    Console.Write("Enter a and b, where b > a: ");
                    string[] words = Console.ReadLine().Split();
                    int a = int.Parse(words[0]);
                    int b2 = int.Parse(words[1]);
                    for (int i = a; i <= b2; i++) { mult *= i; }
                    Console.WriteLine(mult);
                    break;
                default: Console.WriteLine("Invalid input."); break;
            }
        }
        static void Main(string[] args)
        {
            //1.
            coordinates();
            //2.
            HappyNumber();
            //3.
            Year();
            //4.
            Date();
            //5. 6.
            Rectangle();

            //7.
            Cheese();
            //8.
            ColumnDouble();
            //9.
            summ();
            //10.
            mult();
        }
    }
}
