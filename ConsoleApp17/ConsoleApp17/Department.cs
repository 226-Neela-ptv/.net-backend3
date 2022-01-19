using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp17
{
    class Department
    {
        public Department()
        {
            Console.WriteLine("Department constructor");
        }
        public void DepartmentName()
        {
            Console.WriteLine("Department name is ITDepartment");
        }
        public  void NumberOfDepartments()
        {
            Console.WriteLine("there are 5 departments");
        }
        public virtual void GetDepartmentDetails()
        {
            Console.WriteLine("Department name is ITDepartment and there are 5 Departments");
        }

    }
    class Employee : Department
    {
        public Employee()
        {
            Console.WriteLine("Employee constructor is created");
        }
        public void EmpFirstName()
        {
            Console.WriteLine("firstName is neela");
        }
        public void  EmpLastName()
        {
            Console.WriteLine("LastName  is ptv");

        }
        public override void GetDepartmentDetails()
        {
            Console.WriteLine("Department name is ITDepartment and there are 5 Departments");
        }

    };
    }

