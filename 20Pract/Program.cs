namespace _20Pract
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1.
            City city = new City();
            city.AddData();
            Console.WriteLine(city.ToString());

            Console.WriteLine();
            city.GetCountry();
            city.GetCodePhone();

            //2.
            Employee employee = new Employee();
            employee.AddData();
            Console.WriteLine(employee.ToString());

            Console.WriteLine();
            employee.GetEmail();
            employee.GetPhone();

            //3.
            Airplane air = new Airplane();
            air.AddData();
            Console.WriteLine(air.ToString());

            Console.WriteLine();
            air.GetManufacturer();
            air.GetName();

            //4.
            Matrix matrix = new Matrix(1, 2, 3, 4);
            matrix.Deter();
            matrix.MaxMin();
        }
    }
}
