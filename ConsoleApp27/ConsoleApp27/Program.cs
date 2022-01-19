using System;
public struct Employee
{
    public int Id;
    public string name;
    public int salary;

    public void SetEmployee(int id, string Name, int Salary)
    {
        Id = id;
      name = Name;
        salary = Salary;
    }
    public void DisplayEmployee()
    {
        Console.WriteLine("Employee:");
        Console.WriteLine("\tId  : " + Id);
        Console.WriteLine("\tName  : " + name);
        Console.WriteLine("\tSalary  :" + salary);
        Console.WriteLine("\n");

    }
}
class Details { 

    static void Main(string[] args)
    {

        Employee[] emp = {
            new Employee(),
            new Employee(),
            new Employee()
        };


        emp[0].SetEmployee(1, "Neela", 40000);
        emp[1].SetEmployee(2, "Ammu", 45000);
        emp[2].SetEmployee(3, "Kousik", 50000);

        emp[0].DisplayEmployee();
        emp[1].DisplayEmployee();
        emp[2].DisplayEmployee();

    }
}


