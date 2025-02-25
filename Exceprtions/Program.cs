namespace Exceprtions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //try {
            //    int x = 5;
            //    int y = x / 0;
            //    Console.WriteLine($"Result: {y}");
            //}
            //catch { }
            //MyExp exp = new MyExp();
            //Console.WriteLine(exp.Message);
            Console.Write("Enter two numbers: ");
            string[] numbers = Console.ReadLine().Split();
            int num1 = int.Parse(numbers[0]);
            int num2 = int.Parse(numbers[1]);
            int res = 0;

            try
            {
                res = num1 / num2;
                if (res % 2 != 0)
                {
                    throw new MyException();
                }
                Console.WriteLine($"Result: {res}");
            }
            catch (MyException my)
            {
                Console.WriteLine(my.Message);
                Console.WriteLine(my.TimeException);
            }

            catch(Exception ex) // база класса, должен быть всегда в конце
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
