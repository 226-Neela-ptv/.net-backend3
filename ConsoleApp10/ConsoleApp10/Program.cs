using System;
 
namespace ConsoleApp10
{
    class program

    {
        static void Main()
        {
            Student stud = new Student();
            string name = stud.GetName();
            string location = stud.GetLocation();
            Console.WriteLine(name + " is located at " + location);
        }
    }
}

