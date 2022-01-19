using System;
using System.Collections;

namespace ConsoleApp23
{
    class Program
    {
        static void Main()
        {
            Queue q = new Queue();
            {
                q.Enqueue(2);
                q.Enqueue(3);
                q.Enqueue(4);

                foreach (var item in q)
                Console.WriteLine(item);
            }







        }
    }
}
