namespace ПР_2__30._01._2025_
{
    internal class Program
    {
        
        //1.
        static double[] function()
        {
            Console.Write("X and A: ");
            string[] elem = Console.ReadLine().Split();
            int _x = int.Parse(elem[0]);
            int _a = int.Parse(elem[1]);

            double result_x = 7 * Math.Pow(_x, 2) + 3 * _x + 6;
            double result_a = 12 * Math.Pow(_a, 2) + 7 * _a + 12;
            return [result_x, result_a];
        }
        //2.
        static int line_so()
        {
            Console.Write("A, X, B (A != 0): ");
            string[] coef = Console.ReadLine().Split();
            int a = int.Parse(coef[0]);
            int x = int.Parse(coef[1]);
            int b = int.Parse(coef[2]);

            if (a != 0)
            {
                return a*x + b;
            }
            else {
                Console.Write("Mistake. Ends -> ");
                return 0;
            }
        }
        //3.
        static double catets()
        {
            Console.Write("Catets: ");
            string[] catets = Console.ReadLine().Split();
            int f_catet = int.Parse(catets[0]);
            int s_catet = int.Parse(catets[1]);

            double fs = Math.Pow(f_catet, 2) + Math.Pow(s_catet, 2);

            return f_catet + s_catet + Math.Sqrt(fs);
        }
        //4.
        static int trapetion()
        {
            Console.Write("Hight and Sides(a, b): ");
            string[] abh = Console.ReadLine().Split();
            int h = int.Parse(abh[0]);
            int a = int.Parse(abh[1]);
            int b = int.Parse(abh[2]);

            Console.Write("Perimetr is ");
            return (a + b) + 2 * h;
        }

        //5.
        static void treside()
        {
            Console.WriteLine("Three parts coordinates ABC(x1, y1...). ");
            Console.Write("A - x1, y1: ");
            string[] coor1 = Console.ReadLine().Split();
            Console.Write("B - x2, y2: ");
            string[] coor2 = Console.ReadLine().Split();
            Console.Write("C - x3, y3: ");
            string[] coor3 = Console.ReadLine().Split();
            int x1 = int.Parse(coor1[0]);
            int y1 = int.Parse(coor1[1]);
            int x2 = int.Parse(coor2[0]);
            int y2 = int.Parse(coor2[1]);
            int x3 = int.Parse(coor3[0]);
            int y3 = int.Parse(coor3[1]);

            //sides
            double AB = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2));
            double BC = Math.Sqrt(Math.Pow((x3 - x2), 2) + Math.Pow((y3 - y2), 2));
            double AC = Math.Sqrt(Math.Pow((x3 - x1), 2) + Math.Pow((y3 - y1), 2));

            //perimeter
            double result_per = AB + BC + AC;
            Console.WriteLine($"Perimeter is {result_per}");
            //S
            double result_S = Math.Abs((x1 * (y2 - y3) + x2 * (y3 - y1) + x3 * (y1 - y2)) / 2.0);
            Console.WriteLine($"S is {result_S}");
        }

        //6.
        static void look_number()
        {
            int finish = 237;
            int x = finish - (finish % 10); //230
            int after_x = x /= 10; //23

            int last_x = finish % 10;
            string r_x = Convert.ToString(last_x);
            string a_x = Convert.ToString(after_x);

            string result = after_x + r_x;
            int f_result = int.Parse(result);
            Console.WriteLine($"Start number is {f_result}");
        }

        //7.
        static bool logic()
        {
            bool A = true;
            bool B = false;
            bool C = false;
            if (A || B) { return A; }
            if (A && B) { return B; }
            if (C || B) { return C; }

            return false;
        }

        //8.
        static bool logic2()
        {
            bool A = true;
            bool B = false;
            bool C = false;
            if (!A && B) { return A; };
            if (A || !B) { return B; };
            if (A && B || C) { return C; };
            return false;
        }

        //9.
        static bool logic3()
        {
            bool A = true;
            bool B = false;
            bool C = false;
            if (A || B && !C) { return true; }
            if (!A && !B) { return false; };
            if (!(A && C) || B) { return false; }

            if (A && !B || C) { return true; };
            if (A && (!B || C)) { return true; }
            if (A || (!(B && C))) { return true; }

            return false;
        }

        //10.
        static bool helpwhatisit()
        {
            Console.Write("Enter x: ");
            double x = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter y: ");
            double y = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"You entered x: {x}; y: {y}");
            int count = 0;

            if (x < 2 && y < 3)
            {
                Console.WriteLine($"a. Condition {x} < 2 && {y} < 3 is right");
                count++;
            }
            else if (x >= 2)
            {
                Console.WriteLine($"b. Condition {x} >= 2 is right");
                count++;
            }
            else if (x < 1 || y < 2)
            {
                Console.WriteLine($"c. Condition {x} < 1 || {y} < 2 is right");
                count++;
            }
            else if (x >= 0 && x >= 5)
            {
                Console.WriteLine($"d. Condition {x} >= 0 && {x} >= 5 is right");
                count++;
            }
            else if (x < 0 && y > 5)
            {
                Console.WriteLine($"e. Condition {x} < 0 && {y} > 5 is right");
                count++;
            }
            else if (10 < x && x < 20)
            {
                Console.WriteLine($"f. Condition 10 < {x} < 20 is right");
                count++;
            }
            else if (x > 3 || x < 1)
            {
                Console.WriteLine($"g. Condition {x} > 3 || {x} < 1 is right");
                count++;
            }
            else if (0 < y && y < 4 && x < 5)
            {
                Console.WriteLine($"h. Condition 0 < {y} < 4 && {x} < 5 is right");
                count++;
            }
            else if (x > 3 && x < 10)
            {
                Console.WriteLine($"i. Condition {x} > 3 0 && {x} < 10 is right");
                count++;
            }

            Console.WriteLine("Finish.");
            Console.WriteLine($"Result: {count}/9 right conditions");

            if (count == 9)
            {
                Console.WriteLine($"Everything is right. {helpwhatisit}");
                return true;
            }
            else
            {
                Console.WriteLine($"Something is not right. {helpwhatisit}");
                return false;
            }
        }

            static void Main(string[] args)
        {
            //1.
            double[] ax = function();
            Console.WriteLine($"Y = {ax[0]}; X = {ax[1]}");

            //2.
            Console.WriteLine(line_so());

            //3.
            Console.WriteLine($"Perimetr is {Math.Round(catets(), 2)}");

            //4.
            trapetion();

            //5.
            treside();

            //6.
            look_number();

            //7.
            Console.WriteLine($"Result is: {logic()}");

            //8.
            Console.WriteLine($"Result is: {logic2()}");

            //9.
            Console.WriteLine($"Result is: {logic3()}");

        }
    }
}
