using System;
namespace ConstructorDemo
{
    class Employee
    {
        public int Id, Age;
        public string Address, Name;
        public bool IsPermanent;

        //User Defined Parameterized Constructor
        public Employee(int id, int age, string name, string address, bool isPermanent)
        {
            Id = id;
            Age = age;
            Address = address;
            Name = name;
            IsPermanent = isPermanent;
        }

        public void Display()
        {
            Console.WriteLine("Employee Id is:  " + Id);
            Console.WriteLine($"Employee Age is:  {Age}");
            Console.WriteLine("Employee Address is:  " + Address);
            Console.WriteLine("Employee Name is:  " + Name);
            Console.WriteLine("Is Employee Permanent:  " + IsPermanent);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Employee e1 = new Employee(101, 30, "Pranaya", "Mumbai", true);
            e1.Display();
            Console.WriteLine();

            Employee e2 = new Employee(102, 28, "Rout", "BBSR", false);
            e2.Display();
            Console.ReadKey();
        }
    }
}