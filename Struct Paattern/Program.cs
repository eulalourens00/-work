namespace Struct_Paattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ITarget target = new Adapter();
            target.Request();
        }
    }
}
