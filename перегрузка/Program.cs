namespace перегрузка
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Point point = new Point { X = 12, Y = 12 };
            //Console.WriteLine($"Start point: {point} ");

            //Console.WriteLine( ++point );
            //Console.WriteLine(point++);
            //Console.WriteLine( --point);
            //Console.WriteLine( -point );

            //Console.WriteLine($"Finish point: {point} ");

            //Point p1 = new Point { X = 2, Y = 3 };
            //Point p2 = new Point { X = 3, Y = 1 };

            //Vector v1 = new Vector(p1, p2);
            //Vector v2 = new Vector{X = 2, Y = 3};

            //Console.WriteLine($"{v1} \n {v2}");
            //Console.WriteLine($"== {v1 + v2}");
            //Console.WriteLine($"== {v1 - v2}");

            //Console.Write("Num: ");
            //Int32.TryParse(Console.ReadLine(), out int n);
            //v1 *= n;
            //Console.WriteLine($"Now = {v1}"); 

            //CPoint cp = new CPoint { X = 10, Y = 10 };
            //CPoint cp1 = new CPoint { X = 10, Y = 10 };
            //CPoint cp2 = cp1;

            //Console.WriteLine($"ReferenceEquals(cp, cp1) = {ReferenceEquals(cp, cp1)}"); //false
            //Console.WriteLine($"ReferenceEquals(cp1, cp2) = {ReferenceEquals(cp1, cp2)}"); //true

            //SPoint sp = new SPoint { X = 10, Y = 10};
            //Console.WriteLine((object) sp);
            //Console.WriteLine((object)sp);


            //Console.WriteLine($"ReferenceEquals(sp, sp) = {ReferenceEquals(sp, sp)}");
            //Console.WriteLine($"Equals(cp, cp1) = {Equals(cp, cp1)}");
            //SPoint sp1 = new SPoint { X = 10, Y = 10 };
            //Console.WriteLine($"Equals(sp, sp1) = {Equals(sp, sp1)}");

            //Point point = new Point {X = 10, Y = 10 };
            //Console.WriteLine(point.Equals(point));

            //Console.Write("Enter coordinates: ");
            //Point ponint = new Point { X = int.Parse(Console.ReadLine()), Y = int.Parse(Console.ReadLine()) };
            //if (point)
            //{
            //    Console.WriteLine("Not start point");
            //}
            //else
            //{
            //    Console.WriteLine("Start point");
            //}

            //Rectangle rectangle = new Rectangle { Width = 5, Height = 10 };
            //Square square = new Square { Length = 7 };
            //Rectangle rectSquare = square;
            //Console.WriteLine($"Неявное преобразование квадрата в прямоугольник = {rectSquare}");
            //rectSquare.Draw();

            //Square squareRect = (Square)rectangle;
            //Console.WriteLine($"Явное преобразование прямоугольника в квадрат = {squareRect}");
            //square.Draw();

            //Console.Write("NUm = ");
            //Int32.TryParse(Console.ReadLine(), out int num);
            //Square sq1 = num;
            //Console.WriteLine($"Неявное преобразование целого числа к квадрату: {sq1}");
            //sq1.Draw();

            //num = (int)square;
            //Console.WriteLine($"Явное преобразование квадратa к целому числу: {num}");

            //square.Draw();

            //Shop laptops = new Shop(3);
            //laptops[0] = new Laptop {Vendor = "SAmsung", Price = 5200 };
            //laptops[1] = new Laptop { Vendor = "IO", Price = 3456 };
            //laptops[2] = new Laptop { Vendor = "SARR", Price = 2300 };

            //try
            //{
            //    for (int i = 0; i < laptops.Length; i++)
            //    {
            //        Console.WriteLine(laptops[i]);
            //    }
            //}
            //catch(Exception ex){ Console.WriteLine(ex.Message); }

            MultArray mult = new MultArray(2, 3);
            for (int i = 0; i < mult.Row; i++)
            {
                for (int j = 0; j < mult.Column; j++)
                {
                    mult[i, j] = i + j;
                    Console.WriteLine($"{mult[i, j]} ");
                }
                Console.WriteLine();
            }
        
        }
    }
}
