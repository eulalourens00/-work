namespace практика__3_c_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1. x y true
            Console.Write("Enter x: ");
            double x = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter y: ");
            double y = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"You entered x:{x}; y: {y}");
            int count = 0;

            
                if( x < 2 && y < 3) {
                    Console.WriteLine($"a. Condition {x} < 2 && {y} < 3 is right");
                    count++;
                    continue;
                }
                else if(x >= 2)
                {
                    Console.WriteLine($"b. Condition {x} >= 2 is right");
                    count++;
                    continue;
                }
                else if(x < 1 || y < 2) {
                    Console.WriteLine($"c. Condition {x} < 1 || {y} < 2 is right");
                    count++;
                    continue;
                }
                else if (x >= 0 && x >=5)
                {
                    Console.WriteLine($"d. Condition {x} >= 0 && {x} >= 5 is right");
                    count++;
                    continue;
                }
                else if (x < 0 && y > 5)
                {
                    Console.WriteLine($"e. Condition {x} < 0 && {y} > 5 is right");
                    count++;
                    continue;
                }
                else if (10 < x && x < 20)
                {
                    Console.WriteLine($"f. Condition 10 < {x} < 20 is right");
                    count++;
                    continue;
                }
                else if (x > 3 || x < 1)
                {
                    Console.WriteLine($"g. Condition {x} > 3 || {x} < 1 is right");
                    count++;
                    continue;
                }
                else if (0 < y && y < 4 && x < 5)
                {
                    Console.WriteLine($"h. Condition 0 < {y} < 4 && {x} < 5 is right");
                    count++;
                    continue;
                }
                else if (x > 3 && x< 10)
                {
                    Console.WriteLine($"i. Condition {x} > 3 0 && {x} < 10 is right");
                    count++;
                    break;
                }
            
            Console.WriteLine("Finish.");
            Console.WriteLine($"Result: {count}/9 right conditions");

            if(count == 9)
            {
                Console.WriteLine("Everything is right. TRUE");
            }
            else
            {
                Console.WriteLine("Something is not right. FALSE");
            }

        }
    }
}
