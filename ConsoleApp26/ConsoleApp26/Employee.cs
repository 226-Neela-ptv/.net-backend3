using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp26
{
   public  class Employee : Department
    {
        public void GetFirstName()
        {
            string name1 = "neela";
            Console.WriteLine("The first name is :" + name1);
        }
        public void GetLastName()
        {
            string name2 = "ptv";
            Console.WriteLine("The last name is  :" + name2);
        }
        public override void GetDepartmentDetails()
        {
            Console.WriteLine("this method isusedfor department class to override the methods of employee class by using virtual method");
        }

    }
}
