using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp26
{
   public  class Department
    {
        public void GetDepartmentName()
        {
            string name = "IT Department";
            Console.WriteLine("Department name of the employee is : " + name);

        }
        public void GetNumberofDepartments()
        {
            int number = 5;
            Console.WriteLine("The number of departments are present inthe company are : " + number);
        }
        public virtual void GetDepartmentDetails()
        {
            Console.WriteLine("this method is used to get details of the employee : ");
        }
    }
}
