using System.Collections;
using System.Collections.Generic;

namespace dictionary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ArrayList arrayList = new ArrayList(5);
            //ArrayList arrayList2 = new ArrayList(new int[] { 1, 5, 22});

            //ArrayList arr3 = new ArrayList();
            //Console.WriteLine($"Capasiry: {arr3.Capacity}\n");
            //arr3.Add("one");
            //Console.WriteLine($"Capasiry: {arr3.Capacity}\n");

            //arr3.AddRange(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 });
            //Console.WriteLine($"Capsiti: {arr3.Capacity}\n");

            //Stack st1 = new Stack();
            //Console.WriteLine("Method Push()");
            //st1.Push("one");
            //st1.Push("two");
            //st1.Push("three");
            //foreach(var i in st1)
            //{
            //    Console.WriteLine(i + " ");
            //}
            //Console.WriteLine();
            //Console.WriteLine("Method Pop()");
            //st1.Pop();
            //foreach(var i in st1)
            //{
            //    Console.Write(i + " ");
            //}
            //Console.WriteLine();
            //Console.WriteLine($"Method Peek {st1.Peek()}");

            //Console.WriteLine(st1.Contains("row")); //false
            //Console.WriteLine(st1.Contains("one")); //true

            //Console.WriteLine("CopyTo()");
            //string[] strArr = new string[st1.Count];
            //st1.CopyTo(strArr, 0); 
            //foreach(var i in strArr)
            //{
            //    Console.Write(i + " ");
            //}

            //Console.WriteLine() ;
            //Console.WriteLine(st1.Count);
            //st1.Clear();

            //FIFO
            //Queue queue1 = new Queue();

            //for (int i = 0; i < 4; i++) { queue1.Enqueue(i); }
            //foreach (var o in queue1) { Console.Write( $"{o}" ); }
            //Console.WriteLine($"Dequeque: {queue1.Dequeue()}");
            //Console.WriteLine($"Contsins: {queue1.Contains(1)}");

            Auditory auditory = new Auditory();
            foreach(Student st in auditory)
            {
                Console.WriteLine(st);
            }


        }
    }
}
