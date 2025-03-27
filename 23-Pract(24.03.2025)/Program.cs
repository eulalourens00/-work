namespace _23_Pract_24._03._2025_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1.
            Triangle triangle = new Triangle(5);
            triangle.Draw();
            Console.WriteLine();

            Square square = new Square(7);
            square.Draw();
            Console.WriteLine();

            Rectangle rectangle = new Rectangle(4, 7);
            rectangle.Draw();
            Console.WriteLine();

            //2.
            GuessNumber guessNumber = new GuessNumber(47, 0, 100);
            guessNumber.TryGuess();

            //3.
            GenerText gen = new GenerText(5, 10, 20);
            gen.Gener();

            //4.
            Money money = new Money(5000);
            money.TopUpBalance();
            money.TopDownBalance();

            money.CenteMinus();
        }
    }
}
