namespace первая_пара_шарпы
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello, World!");

            //int a = 1;
            //if (a == 1)
            //{
            //    Console.WriteLine("1");
            //}
            //else if (a == 2)
            //{
            //    Console.WriteLine("2");
            //} else if (a == 3)
            //{
            //    Console.WriteLine("3");
            //}
            //else
            //{
            //    Console.WriteLine(">3");
            //}

            //int[] nums = new int[4];
            //int[] nums2 = new int[4] { 1, 2, 3, 4 };
            //int[] nums3 = new int[] { 1, 2, 3, 4 };
            //int[] nums4 = new[] { 1, 2, 3, 4 };
            //int[] nums5 = { 1, 2, 3, 4 };


            //Console.WriteLine(nums2[0]);
            //Console.WriteLine(nums2[1]);
            //Console.WriteLine();
            //Console.WriteLine("Massiv: ");
            //foreach (int i in nums2)
            //{
            //    Console.WriteLine($"nums2[] = {i}");
            //}

            //Console.WriteLine();
            //for (int i = 0; i < nums2.Length; i++) {
            //    Console.WriteLine($"nums2[{i}] = {nums2[i]}");
            //}

            //Console.WriteLine();
            //Console.WriteLine(nums2[nums.Length - 1]);

            //Console.WriteLine(nums2[^1]);

            //Console.WriteLine();
            //for (int i = nums2.Length - 1; i >= 0; i--)
            //{
            //    Console.WriteLine($"nums2[{i}] = {nums2[i]}");
            //}

            //int[,] darray = { { 1, 2, 3 }, { 4, 5, 6 } };
            //int[,] darray2 = new int[3, 4];
            //int[,,] a3d = new int[4, 5, 6];

            //foreach (int i in darray) {
            //    Console.WriteLine($"{i}");
            //}

            //int rows = darray.GetUpperBound(0) + 1;
            //int col = darray.Length / rows;

            //for (int i = 0; i < rows; i++) {
            //    for (int j = 0; j < col; j++)
            //    {
            //        Console.WriteLine($"{i}");
            //    }
            //    Console.WriteLine();
            //}

            //int[][] zub = new int[3][];
            //zub[0] = new int[] { 1, 4, 7 };
            //zub[1] = new int[] { 1, 4, 7, 10, 44, 7, 8, 8 };
            //zub[2] = new int[] { 1, 3 };
            //foreach (int[] i in zub)
            //{
            //    foreach (int j in i)
            //    {
            //        Console.WriteLine($"{j} ");
            //    }
            //    Console.WriteLine();
            //}

            //Console.WriteLine(darray.Length);
            //Console.WriteLine(darray.Rank);
            //Console.WriteLine(darray.GetLength(0));


            //Console.Read();
            //Console.ReadLine();
            //Console.ReadKey();

            //ConsoleKeyInfo info = Console.ReadKey();
            //do {
            //        info = Console.ReadKey();
            //        switch (info.Key)
            //        {
            //            case ConsoleKey.F1:
            //                {
            //                    Console.WriteLine("F1");
            //                    break;
            //                }
            //            case ConsoleKey.F2:
            //                {
            //                    Console.WriteLine("F2");
            //                    break;
            //                }
            //            case ConsoleKey.F3:
            //                {
            //                    Console.WriteLine("F3");
            //                    break;
            //                }
            //        }
            //} 
            //while(info.Key != ConsoleKey.None); 


            //Console.WriteLine("Its a string");
            //Console.ForegroundColor = ConsoleColor.Cyan;

            //Console.Write("Bistro");
            //Console.ForegroundColor = ConsoleColor.Magenta;

            //Console.Write("Bistro3");
            //Console.ForegroundColor = ConsoleColor.DarkYellow;

            //string? name = Console.ReadLine();

            //for(int i = 0; i<16; i++)
            //{
            //    Console.ForegroundColor = (ConsoleColor)i;
            //    Console.WriteLine((ConsoleColor)i);
            //}

            //Console.BackgroundColor = ConsoleColor.DarkGreen;
            //Console.Clear();

            //Console.Title = "Help";
            //Console.ReadKey();

            //Console.WriteLine($"Width of bufer {Console.BufferWidth}");
            //Console.WriteLine($"Heigth of bufer {Console.BufferHeight}");

            //Console.BufferHeight = Console.WindowTop + Console.WindowHeight;
            //int currTop = 7;

            //Console.CursorTop = currTop;

            //for (int i = 0; i < 11; i++) {
            //    Console.CursorLeft = (Console.BufferWidth - 20) / 2;
            //    for(int j = 0; j < 11; j++)
            //    {
            //        Console.ForegroundColor = (ConsoleColor)i;
            //        Console.Write($"{j - 1} ");
            //        Thread.Sleep(100);
            //    }
            //    currTop++;
            //    Console.CursorTop = currTop;
            //    Thread.Sleep(100);

            //}

            Print("Leeky Suya", 23, "Leekorees");
            Print("Leeky Suya", 23);
            Print("Leeky Suya");

            Console.WriteLine();

            Print("Leeky Suya", company: "Leekorees", age:27);
        }

        static void Print(string name, int age = 1, string company = "None")
        {
            Console.WriteLine($"{name} - {age} - {company}");
        }

    }
}
