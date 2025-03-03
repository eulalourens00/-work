namespace Практика_3_03._03._2025
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1.1
            GeometryFigures triangle = new Triangle(16, 21, 21, 27);
            triangle.Area();
            triangle.Perimeter();

            GeometryFigures square = new Square(15);
            square.Area();
            square.Perimeter();

            GeometryFigures rhombus = new Rhombus(10, 12, 26);
            rhombus.Area();
            rhombus.Perimeter();

            GeometryFigures rectangle = new Rectangle(15, 17);
            rectangle.Area();
            rectangle.Perimeter();

            GeometryFigures parallelogram = new Parallelogram(12, 8, 4);
            parallelogram.Area();
            parallelogram.Perimeter();

            GeometryFigures trapetion = new Trapetion(24, 16, 6, 4, 8);
            trapetion.Area();
            trapetion.Perimeter();

            GeometryFigures circle = new Circle(15);
            circle.Area();
            circle.Perimeter();

            GeometryFigures ellipse = new Ellipse(1, 3);
            ellipse.Area();
            ellipse.Perimeter();

            Console.Clear();
            //1.2
            CompositeShape compositeShape = new CompositeShape();
            Circle circle1 = new Circle(15);
            Rectangle rectangle1 = new Rectangle(10, 7);
            compositeShape.AddFigures(circle1);
            compositeShape.AddFigures(rectangle1);
            compositeShape.Area();
            compositeShape.Perimeter();

            Console.Clear();

            //2.
            DateTime birth = new DateTime(2007, 12, 27);
            ToStringMethods person = new ToStringMethods("Suya", "Leeky", 17, birth, "dancing and gym");
            Console.WriteLine(person.ToString());

        }
    }
}
