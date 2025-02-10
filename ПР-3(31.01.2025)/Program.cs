namespace ПР_3_31._01._2025_
{
    internal class Program
    {
        //2.
        static bool helpwhatisit()
        {
            Console.Write("Enter x and y: ");
            string[] strings = Console.ReadLine().Split();
            double x = double.Parse(strings[0]);
            double y = double.Parse(strings[1]);
            Console.WriteLine($"You entered x: {x}; y: {y}");

            if (x < 2 && y < 3)
            {
                Console.WriteLine($"a. Condition {x} < 2 && {y} < 3 is right");
                return true;
            }
            if (x >= 2)
            {
                Console.WriteLine($"b. Condition {x} >= 2 is right");
                return true;
            }
            if (x < 1 || y < 2)
            {
                Console.WriteLine($"c. Condition {x} < 1 || {y} < 2 is right");
                return true;
            }
            if (x >= 0 && x >= 5)
            {
                Console.WriteLine($"d. Condition {x} >= 0 && {x} >= 5 is right");
                return true;
            }
            if (x < 0 && y > 5)
            {
                Console.WriteLine($"e. Condition {x} < 0 && {y} > 5 is right");
                return true;
            }
            if (10 < x && x < 20)
            {
                Console.WriteLine($"f. Condition 10 < {x} < 20 is right");
                return true;
            }
            if (x > 3 || x < 1)
            {
                Console.WriteLine($"g. Condition {x} > 3 || {x} < 1 is right");
                return true;
            }
            if (0 < y && y < 4 && x < 5)
            {
                Console.WriteLine($"h. Condition 0 < {y} < 4 && {x} < 5 is right");
                return true;
            }
            if (x > 3 && x < 10)
            {
                Console.WriteLine($"i. Condition {x} > 3 0 && {x} < 10 is right");
                return true;
            }
            return false;
        }
        //2.
        static bool condition()
        {
            Console.Write("Enter x, y and z: ");
            string[] strings = Console.ReadLine().Split();
            int x = int.Parse(strings[0]);
            int y = int.Parse(strings[1]);
            int z = int.Parse(strings[2]);

            if (x % 2 != 0 && y % 2 != 0)
            {
                return true;
            }
            if ((x < 20 && y >= 20) || (x >= 20 && y < 20))
            {
                return true;
            }
            if (x == 0 || y == 0)
            {
                return true;
            }
            if (x < 0 && y < 0 && z < 0)
            {
                return true;
            }
            if ((x % 5 == 0 && y % 5 != 0 && z % 5 != 0) ||
            (x % 5 != 0 && y % 5 == 0 && z % 5 != 0) ||
            (x % 5 != 0 && y % 5 != 0 && z % 5 == 0))
            {
                return true;
            }
            if (x > 100 || y > 100 || z > 100)
            {
                return true;
            }
            return false;
        }
        //3.
        static double sinxcos()
        {
            Console.Write("Enter x: ");
            double x = double.Parse(Console.ReadLine());
            if (x > 0)
            {
                double s = Math.Sin(x);
                Console.WriteLine($"Sin(x) = {Math.Round(s, 2)}");
                return s;
            }
            else if(x == 0)
            {
                return 0;
            }
            else
            {
                double c = Math.Cos(x);
                Console.WriteLine($"Cos(x) = {Math.Round(c, 2)}");
                return c;
            }
        }
        //4.
        static bool A_div_B()
        {
            Console.Write("Enter A and B: ");
            string[] numbers = Console.ReadLine().Split();
            int value1 = int.Parse(numbers[0]);
            int value2 = int.Parse(numbers[1]);

            if (value2 % value1 == 0)
            {
                Console.WriteLine("True.");
                return true;
            }
            return false;
        }
        //5.
        static bool natural()
        {
            Console.Write("Enter x: ");
            int x = int.Parse(Console.ReadLine());
            if (x % 2 == 0)
            {
                Console.WriteLine("True.");
                return true;
            }
            if(x % 10 == 7)
            {
                Console.WriteLine("True.");
                return true;
            }
            return false;
        }
        //6.
        static void km_f()
        {
            Console.Write("Enter the path in kilometers and in feet: ");
            string[] way = Console.ReadLine().Split();
            double km_way = double.Parse(way[0]);
            double feet_way = double.Parse(way[1]);

            double result_km = km_way * 1000;
            double result_feet = feet_way * 0.305;
            if (result_km > result_feet) { Console.WriteLine("Feet way is less."); }
            else if (result_feet > result_km) { Console.WriteLine("Km way is less."); }
            else { Console.WriteLine("The same ways."); }
        }
        //7.
        static bool parabola()
        {
            Console.Write("Enter A, B, C (A != 0): ");
            string[] numbers = Console.ReadLine().Split();
            int value_A = int.Parse(numbers[0]);
            int value_B = int.Parse(numbers[1]);
            int value_C = int.Parse(numbers[2]);

            double Des = MathF.Pow(value_B, 2) - (4 * value_A * value_C);
            Console.WriteLine($"D = {Des}");

            if (Des > 0)
            {
                double x1 = -value_B + Math.Sqrt(Des) / 2 * value_A;
                double x2 = -value_B - Math.Sqrt(Des) / 2 * value_A;
                Console.WriteLine($"X1 = {Math.Round(x1, 2)}; X2 = {Math.Round(x2, 2)}");
                return true;
            }
            else if (Des == 0)
            {
                double x = -value_B / 2 * value_A;
                Console.WriteLine($"X = {Math.Round(x, 2)}");
                return true;
            }
            else
            {
                Console.WriteLine("NO Veschestvennae SQRT ");
            }
            return false;
        }

        //8.
        static bool square_circle()
        { 
            Console.Write("Enter a S of square and circle: ");
            string[] s = Console.ReadLine().Split();
            int square = int.Parse(s[0]);
            int circle = int.Parse(s[1]);

            double side = Math.Sqrt(square);
            double diameter = Math.Sqrt(circle / Math.PI);
            diameter *= 2;
            double diagonal = side * Math.Sqrt(2);
            if(diameter <= side) { Console.WriteLine("Circle can be in square. "); return true; }
            if(diagonal <= diameter) { Console.WriteLine("Square can be in circle. "); return true;}
            return false;
        }

        //9.
        static bool interval()
        {
            Console.Write("Enter number:");
            int x = int.Parse(Console.ReadLine());
            if (x <= 3 && x >= -5) { Console.WriteLine("True."); return true; }
            return false;
        }
        //10.
        static bool ABC_triangle()
        {
            Console.Write("A, B, C: ");
            string[] sides = Console.ReadLine().Split();
            int A = int.Parse(sides[0]);
            int B = int.Parse(sides[1]);
            int C = int.Parse(sides[2]);
            if (A == 0 && B == 0 && C == 0) { Console.WriteLine("True."); return true; }
            return false;
        }
        static void Main(string[] args)
        {
            //1.
            helpwhatisit();
            //2.
            condition();
            //3.
            sinxcos();
            //4.
            A_div_B();
            //5.
            natural();
            //6.
            km_f();
            //7.
            parabola();
            //8.
            square_circle();
            //9.
            interval();
            //10.
            ABC_triangle();

        }
    }
}
