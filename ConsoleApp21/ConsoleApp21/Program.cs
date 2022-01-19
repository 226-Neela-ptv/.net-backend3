using System;
using System.Collections;

namespace ConsoleApp21
{
    class Program
    {
        static void Main()
        {
            ArrayList arrayList1 = new ArrayList();
            arrayList1.Add(1);
            arrayList1.Add("Two");
            arrayList1.Add(3);
            arrayList1.Add(4.5);

            int firstElement = (int)arrayList1[0];
            string secondElement =(string)arrayList1[1];
            int thirdElement = (int)arrayList1[2];
            double fourthElemnt = (double)arrayList1[3];
            Console.WriteLine(secondElement);

        }
    }
}
