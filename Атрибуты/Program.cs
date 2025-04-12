using System.Reflection;

namespace Атрибуты
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\tAttributes of cclass Employee: ");
            foreach (var attr in typeof(Emp).GetCustomAttributesData()) { 
                Console.WriteLine($"{attr.GetType().Name}");
            }
            foreach(MemberInfo info in typeof(Emp).GetMembers())
            {
                foreach(var attr in info.GetCustomAttributes(true))
                {
                    Console.WriteLine(attr);
                }
            }
        }
    }
}
