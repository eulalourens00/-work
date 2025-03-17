using static Делигаты.Calc;

namespace Делигаты
{
    public delegate T AddDelegate<T>(T x, T y);

    class Exam
    {
        public int AddInt(int x, int y)
        {
            return x + y;
        }
        public double AddDouble(double x, double y) { return x + y; }
        public static char AddChar(char x, char y)
        {
            return (char)(x + y);
        }
    }



    internal class Program
    {
        delegate void Mess();
        static void Print()
        {
            Console.WriteLine("Print.");
        }

        static void FullName(Student student) {
            Console.WriteLine($"{student.LastName}\t{student.FirstName}");
        }
        static void Main(string[] args)
        {



            //Exam ex = new Exam(); 
            //AddDelegate<int> delInt = ex.AddInt;
            //Console.WriteLine($"AddInt {delInt(8, 3)}");

            //AddDelegate<double> delDouble = ex.AddDouble;
            //Console.WriteLine($"AddDouble {delDouble(45.6, 12.3)}");

            //AddDelegate<char> delChar = Exam.AddChar;
            //Console.WriteLine($"AddChar {delChar('S', 'h')}");

            //Mess mess; //создание перемеенной делегата
            //mess = Print; // присвоение метода переменной
            //mess(); //вызов метода

            //Calc calc = new Calc();
            //Console.Write("Enter an expression: ");
            //string expression = Console.ReadLine();
            //char sight = ' ';

            //foreach(char item in expression)
            //{
            //    if (item == '+' || item == '-' || item == '*' || item == '/')
            //    {
            //        sight = item;
            //        break;
            //    }
            //}

            //try
            //{
            //    string[] num = expression.Split(sight);
            //    CalcDelegate del = null;

            //    switch (sight)
            //    {
            //        case '+':
            //            del = new CalcDelegate(calc.Add);
            //            break;
            //        case '-':
            //            del = Calc.Sub;
            //            break;
            //        case '*':
            //            del = calc.Mul;
            //            break;
            //        case '/':
            //            del = calc.Div;
            //            break;
            //        default:
            //            throw new InvalidOperationException();
            //    }
            //    Console.Write($"Result: {del(double.Parse(num[0]), double.Parse(num[1]))}");
            //}
            //catch (Exception ex) { 
            //    Console.WriteLine(ex.Message);
            //}
        }
    }
}
