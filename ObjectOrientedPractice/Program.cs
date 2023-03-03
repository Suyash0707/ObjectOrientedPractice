using ObjectOrientedPractice;

public class Program
{

    public static void Main()
    {
        //CreateDemofunction()
    }

    public static void CreateDemofunction()     // this is copied and pasted from Main() just for demo
    {
        Employee object1;               // Employee is user defined variable
        object1 = new Employee();

        object1.Id = 10;
        object1.Name = "Suyash";
        object1.Address = "pune";

        Console.WriteLine("Object1.Id=" + object1.Id);
        Console.WriteLine("Object1.Name=" + object1.Name);
        Console.WriteLine("Object1.Address=" + object1.Address);


        Employee object2;
        object2 = new Employee();

        object2.Id = 20;
        object2.Name = "Vijay";
        object2.Address = "Mumbai";

        Console.WriteLine("Object1.Id=" + object2.Id);
        Console.WriteLine("Object1.Name=" + object2.Name);
        Console.WriteLine("Object1.Address=" + object2.Address);


        Employee employee;
        employee = new Employee();

        Console.WriteLine("Please enter the value for employee id");
        employee.Id = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Please enter the value for employee name");
        employee.Name = Convert.ToString(Console.ReadLine());

        Console.WriteLine("Please enter the value for address");
        employee.Address = Convert.ToString(Console.ReadLine());

        Console.WriteLine("employee.Id=" + employee.Id);
        Console.WriteLine("employee.Name=" + employee.Name);
        Console.WriteLine("employee.Address=" + employee.Address);

    }
}