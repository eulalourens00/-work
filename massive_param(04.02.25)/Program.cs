namespace massive_param_04._02._25_
{
    internal class Program
    {
        static void Sum(params int[] values)
        {
            int res = 0;
            foreach (var value in values)
            {
                res += value;
            }
            Console.WriteLine(res);
        }

        static int Factorial(int n)
        {
            if (n == 0 || n == 1)
            {
                return 1;
            }
            return n * Factorial(n - 1);

        }

        static void Compare(int[] num1, int[] num2)
        {
            int numbSum1 = 0;
            int numbSum2 = 0;

            foreach (var value in num1)
            {
                numbSum1 += value;
            }
            foreach (var value in num2)
            {
                numbSum2 += value;
            }

            if (numbSum1 > numbSum2)
            {
                Console.WriteLine("numbSum1 > numbSum2");
            }
            else if (numbSum1 < numbSum2)
            {
                Console.WriteLine("numbSum1 < numbSum2");
            }
            else
            {
                Console.WriteLine("numbSum1 = numbSum2");
            }
        }

        enum DayTime
        {
            Morning,
            Afternoon,
            Evening,
            Nigth
        }

        static void DbOp(double x, double y, Operation op)
        {
            double res = op switch
            {
                Operation.Add => x + y,
                Operation.Sub => x - y,
                Operation.Mult => x * y,
                Operation.Div => x / y
            };

            Console.WriteLine(res);
        }
        enum Operation
        {
            Add,
            Sub,
            Mult,
            Div
        }

        static void Main(string[] args)
        {
            int[] sum = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            Sum(sum);
            Sum(1, 2, 3, 4, 5, 6, 7, 8);
            Sum(1, 2, 3);

            int d = Factorial(5);
            Console.WriteLine(d);

            DayTime dayTime = DayTime.Morning;
            if (dayTime == DayTime.Morning)
            {
                Console.WriteLine("Goog morning!");
            }
            else
            {
                Console.WriteLine("Good sytki");
            }

            DbOp(20, 10, Operation.Mult);

        }
       
    }
}
