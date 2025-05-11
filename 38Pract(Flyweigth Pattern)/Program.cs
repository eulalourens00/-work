using System.Drawing;

namespace _38Pract_Flyweigth_Pattern_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var factory = new GlyphFactory();

            var a1 = factory.GetCharacter('A');
            var a2 = factory.GetCharacter('A');
            var b = factory.GetCharacter('B');

            a1.Draw(10, 20);
            a2.Draw(30, 40);
            b.Draw(50, 60);

            Console.WriteLine($"a1 и a2 это один объект: {ReferenceEquals(a1, a2)}");

            var row = factory.GetRow();
            var column = factory.GetColumn();

            row.Draw(0, 100);
            column.Draw(200, 0);
        }
    }
}
