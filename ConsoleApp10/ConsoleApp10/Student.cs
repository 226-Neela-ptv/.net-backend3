using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp10
{
    class Student : IStudent
    {
        public string GetLocation()
        {
            return "India";
        }
        public string GetName()
        {
            return " Neela";
        }
    }
}
