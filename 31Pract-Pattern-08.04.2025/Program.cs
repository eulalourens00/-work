namespace _31Pract_Pattern_08._04._2025
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Client colaCl = new(new ColaF());
            colaCl.Print();

            Client pepsiCl = new(new PepsiF());
            pepsiCl.Print();
        }
    }
}
