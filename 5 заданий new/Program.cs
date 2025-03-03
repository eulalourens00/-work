using System.Linq.Expressions;

namespace _5_заданий_new
{
    internal class Program
    {

        static void Main(string[] args)
        {
            //1.
            Console.Write("Enter your name: ");
            string name = Console.ReadLine();
            Console.WriteLine("Hello, {0}", name);

            //3.
            Console.Write("Age: ");
            Int32.TryParse(Console.ReadLine(), out int age);
            try
            {
                if (age > 0)
                {
                    Console.WriteLine("okay.");
                }
                else { throw new MyException(); }
                
            }
            catch (MyException my) { Console.WriteLine(my.Message); Console.WriteLine(my.TimeException); }
            catch (Exception ex) { Console.WriteLine(ex.Message); }
        }
    }
}
