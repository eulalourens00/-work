namespace Struct_Pattern_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Target target = new Adapter();
            target.Requst();
        }
    }
}
