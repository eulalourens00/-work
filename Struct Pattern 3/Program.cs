namespace Struct_Pattern_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Driver driver = new Driver();
            Auro auro = new Auro();
            driver.Travel(auro);

            Console.WriteLine();

            Camel camel = new Camel();
            ITransport camelTram = new CamelToTransportAdapter(camel);
            driver.Travel(camelTram);
        }
    }
}
