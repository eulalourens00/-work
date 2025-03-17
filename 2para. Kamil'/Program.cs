namespace _2para._Kamil_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1.
            Rectangle rectangle = new Rectangle(5, 10);
            Console.WriteLine(rectangle.GetArea());
            //2
            Console.WriteLine();

            TrafficLights trafficLight = new TrafficLights(TrafficLights.Light.Red);
            Console.WriteLine(trafficLight); //  Red

            trafficLight.ChangeLight();
            Console.WriteLine(trafficLight); // Green

            trafficLight.ChangeLight();
            Console.WriteLine(trafficLight); //  Yellow

            trafficLight.ChangeLight();
            Console.WriteLine(trafficLight); //Red

            //3.
            Console.WriteLine();

            Person person = new Person("Leeky Suya", 17);
            Console.WriteLine(person);

            //4.
            Console.WriteLine();

            Vector3D vector1 = new Vector3D(3, 4, 5);
            Vector3D vector2 = new Vector3D(1, 2, 3);

            Vector3D result = vector1.Add(vector2);
            Console.WriteLine($"Summa of vectors: {result}");
            Console.WriteLine($"Length of the first: {Math.Round(vector1.Length(), 4)}");
            Console.WriteLine($"Length of the second: {Math.Round(vector2.Length(), 4)}");
            Console.WriteLine($"All length: {Math.Round(result.Length(), 4)}");

            //5.
            Console.WriteLine();

            Matrix2x2 matrix = new Matrix2x2(1, 2, 3, 4);
            Console.WriteLine();
        }
    }
}
