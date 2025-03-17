using System.Collections;
using System.Collections.Generic;
namespace Generic
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ArrayList arrayList = new ArrayList();
            //arrayList.Add(10);
            //try
            //{
            //    short a = (short)arrayList[0];
            //}
            //catch (Exception e)
            //{
            //    Console.WriteLine(e.Message);
            //}

            //object obj = 45;
            //Console.WriteLine("Boxing: " + obj);
            //int b = (int)obj;
            //Console.WriteLine("Unboxing: " + b);

            //List<int> list = new List<int> { 1, 2, 3 };


            //ValueTypePerfTest();

            InheritClass obj = new InheritClass();
            obj.M1(34);
            obj.M1(45);

            int[] arrInt = new int[] { 22, 63, 718, 14, 5 };
            Console.WriteLine($"Max: {MaxElem<int>(arrInt)}");

            A<int>.Inner a = new A<int>.Inner();   
            Console.WriteLine(a);

            static T MaxElem<T>(T[] arr) where T: IComparable<T>
            {
                T max = arr[0];
                foreach (T t in arr)
                {
                    if(t.CompareTo(max) > 0) { max = t; }
                }
            }
        }

        private static void ValueTypePerfTest()
        {
            const int count = 10000;
            using (new OperationTimer("List"))
            {
                List<int> list = new List<int>();
                for(int i = 0; i < count; i++)
                {
                    list.Add(i);
                    int x = list[i];
                }
                list = null;
            }
            using (new OperationTimer("ArrayList"))
            {
                ArrayList list = new ArrayList();
                for (int i = 0; i < count; i++)
                {
                    list.Add(i);
                    int x = (int)list[i];
                }
                list = null;
            }
        }
    }
}
