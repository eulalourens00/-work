namespace ПР_4__03._02._2025_
{
    internal class Program
    {
        //1.
        static void minMax()
        {
            // 1 rect
            Console.WriteLine("Enter the coordinates for the first rectangle.");
            Console.Write("Bottom left corner (x1_min, y1_min): ");
            string[] firstLowerLeft = Console.ReadLine().Split();
            double x1_min = double.Parse(firstLowerLeft[0]);
            double y1_min = double.Parse(firstLowerLeft[1]);

            Console.Write("Top right corner (x1_max, y1_max): ");
            string[] firstUpperRight = Console.ReadLine().Split();
            double x1_max = double.Parse(firstUpperRight[0]);
            double y1_max = double.Parse(firstUpperRight[1]);

            // 2 rect
            Console.WriteLine("Enter the coordinates for the second rectangle.");
            Console.Write("Bottom left corner (x2_min, y2_min): ");
            string[] secondLowerLeft = Console.ReadLine().Split();
            double x2_min = double.Parse(secondLowerLeft[0]);
            double y2_min = double.Parse(secondLowerLeft[1]);

            Console.Write("Top-right corner (x2_max, y2_max): ");
            string[] secondUpperRight = Console.ReadLine().Split();
            double x2_max = double.Parse(secondUpperRight[0]);
            double y2_max = double.Parse(secondUpperRight[1]);


            double minX = Math.Min(x1_min, x2_min);
            double minY = Math.Min(y1_min, y2_min);
            double maxX = Math.Max(x1_max, x2_max);
            double maxY = Math.Max(y1_max, y2_max);

            Console.WriteLine($"Bottom left corner of the rectangle: ({minX}, {minY})");
            Console.WriteLine($"Top right corner of the rectangle: ({maxX}, {maxY})");
        }
        //2.
        static bool square_circle()
        {
            Console.Write("Enter a S of square and circle: ");
            string[] s = Console.ReadLine().Split();
            int square = int.Parse(s[0]);
            int circle = int.Parse(s[1]);

            double side = Math.Sqrt(square);
            double diameter = Math.Sqrt(circle / Math.PI);
            diameter *= 2;
            double diagonal = side * Math.Sqrt(2);
            if (diameter <= side) { Console.WriteLine("Circle can be in square. "); return true; }
            if (diagonal <= diameter) { Console.WriteLine("Square can be in circle. "); return true; }
            return false;
        }
        //3.
        static bool interval()
        {
            Console.Write("Enter number:");
            int x = int.Parse(Console.ReadLine());
            if (x <= 3 && x >= -5) { Console.WriteLine("True."); return true; }
            return false;
        }
        //4.
        static bool bigger_number()
        {
            Console.Write("Enter a 3-digit number: ");
            int x = int.Parse(Console.ReadLine());
            int last = x % 10;
            int middle = (x / 10) % 10;
            int start = x / 100;

            if (start > last) { Console.WriteLine($"The start number '{start}' more last '{last}'"); return true; }
            else { Console.WriteLine($"The last number '{last}' more start '{start}'"); return true; }

            if (start > middle) { Console.WriteLine($"The start number {start} more middle {middle}"); return true; }
            else { Console.WriteLine($"The middle number '{middle}' more start '{start}'"); return true; }

            if (last > middle) { Console.WriteLine($"The last number '{last}' more middle '{middle}'"); return true; }
            else { Console.WriteLine($"The middle number '{middle}' more last '{last}'"); return true; }
            
            return false;
        }
        static bool kirpich()
        {
            Console.Write("Enter A, B, C (Kirpich) and X Y (Sides): ");
            string[] strings = Console.ReadLine().Split();
            int a = int.Parse(strings[0]);
            int b = int.Parse(strings[1]);  
            int c = int.Parse(strings[2]);
            int x = int.Parse(strings[3]);
            int y = int.Parse(strings[4]);

            if ((a <= x && b <= y) || (a <= y && b <= x) ||
            (a <= x && c <= y) || (a <= y && c <= x) ||
            (b <= x && c <= y) || (b <= y && c <= x))
            {
                Console.WriteLine("Complete.");
                return true;
            }
            return false;
        }
        static void Main(string[] args)
        {
            //1.
            minMax();
            //2.
            square_circle();
            //3.
            interval();
            //4.
            bigger_number();
            //5.
            kirpich();
        }
    }
}
