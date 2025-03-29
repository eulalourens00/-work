namespace _25Pract__28._03._2025_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1.
            IntArray intArray = new IntArray(5);
            intArray.FillArray(new int[] { 10, 20, 30, 40, 50});
            for(int i = 0; i <= 10; i++) { Console.WriteLine($"El: {intArray.CurrentValue}"); intArray.CurrentValue = i * 20; }
            intArray.PrintArray();

            //2.
            DigitOfTheNumber digit = new DigitOfTheNumber();
            digit[0] = 4;
            digit[1] = 5;
            digit[2] = 3;
            digit[3] = 1;
            Console.WriteLine($"1-digits: {digit[0]}");
            Console.WriteLine($"10-digits: {digit[1]}");
            Console.WriteLine($"100-digits: {digit[2]}");
            Console.WriteLine($"1000-digits: {digit[3]}");

            Console.WriteLine($"Full: {digit[0] + digit[1] * 10 + digit[2] * 100 + digit[3] * 1000}");

            //3.
            string[] initialArray = { "Leeky", "Suya", "I cant take it anymore" };
            TextArray textArray = new TextArray(initialArray);

            // одномерный индексатор
            Console.WriteLine(textArray[0]);
            textArray[1] = "Its mee";
            Console.WriteLine(textArray[1]);

            // двумерный индексатор
            Console.WriteLine(textArray[0, 1]); // e (второй символ в "Leeky")
            textArray[0, 1] = 'a';
            Console.WriteLine(textArray[0]);

            Console.WriteLine(textArray[3]);
            Console.WriteLine(textArray[1, 10]);
        }
    }
}
