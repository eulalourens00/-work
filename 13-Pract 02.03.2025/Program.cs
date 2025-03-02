namespace Numbers._Pract_02._03._2025
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1.
            EvenNumbers even = new EvenNumbers(1, 100);
            even.Result();

            Console.WriteLine();

            NotEvenNumbers noteven = new NotEvenNumbers(1, 100);
            noteven.Result();

            Console.WriteLine();

            EasyNumbers easy = new EasyNumbers(1, 100);
            easy.Result();

            Console.WriteLine();
            Febonacci fe = new Febonacci(0, 100);
            fe.Result();

            Console.Clear();
            //2.
            Triangle tri = new Triangle(5);
            tri.Draw();
            Console.WriteLine();

            Rectangle rec = new Rectangle(5, 10);
            rec.Draw();
            Console.WriteLine();

            Square squ = new Square(5);
            squ.Draw();
            Console.WriteLine();

            Console.Clear();
            //3.
            GuessNumber guess = new GuessNumber(12, 8, 15);
            guess.TryGuess();

            Console.Clear();

            //4.
            Company myCompany = new HouseChemicals("Shumonit", 100, 5.99, new DateTime(2025, 12, 31));
            UsingCompany usingCompany = new UsingCompany(myCompany);

            usingCompany.AddFlow(UsingCompany.FlowType.Incoming, 50);
            Console.WriteLine(myCompany);

            usingCompany.AddFlow(UsingCompany.FlowType.Sold, 20);
            Console.WriteLine(myCompany);

        }
    }
}
