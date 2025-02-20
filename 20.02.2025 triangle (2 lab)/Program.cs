class Triangle
{
    private int a;
    private int b;
    private int c;
    private string type = "";

    public Triangle(int a, int b, int c)
    {
        if (a <= 0 || b <= 0 || c <= 0)
        {
            throw new Exception("Invalid input. Sides need to be more 0.");
        }

        if (a + b <= c || a + c <= b || b + c <= a)
        {
            throw new Exception("Invalid input. Summa of less sides have to be more the biggest side.");
        }

        this.a = a;
        this.b = b;
        this.c = c;
    }

    public string Type()
    {
        if (a == b && b == c)
        {
            type += "Sides is same.";
        }
        else if (a == b || a == c || b == c)
        {
            type += "Ravnobedrenniy. ";
        }
        else
        {
            type += "Not same sides. ";
        }

        if (Math.Pow(a, 2) + Math.Pow(b, 2) == Math.Pow(c, 2))
        {
            type += "90-rectangle";
        }
        else if ((Math.Pow(a, 2) + Math.Pow(b, 2) < Math.Pow(c, 2)))
        {
            type += "More 90-rectangle";
        }
        else
        {
            type += "Less 90-rectangle";
        }

        return type;
    }

    public double Area()
    {
        double p = (a + b + c) / 2;
        return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
    }

    public int Perimeter()
    {
        return a + b + c;
    }
}

public class Code
{
    public static void Main()
    {
        try
        {
            Console.Write("Side a, b, c: ");
            string[] sides = Console.ReadLine().Split();
            int a = int.Parse(sides[0]);
            int b = int.Parse(sides[1]);
            int c = int.Parse(sides[2]);

            Triangle triangle = new Triangle(a, b, c);

            Console.WriteLine($"Type: {triangle.Type()}");
            Console.WriteLine($"Area: {triangle.Area()}");
            Console.WriteLine($"Perimeter: {triangle.Perimeter()}");
        }
        catch (Exception ex)
        {
            Console.WriteLine("Invalid: " + ex.Message);
        }

    }
}