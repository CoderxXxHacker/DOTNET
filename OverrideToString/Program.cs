using System;
namespace UnderstandingObjectClassMethods
{
    public class Program
    {
        public static void Main()
        {
            Employee emp = new Employee();
            emp.FirstName = "Pranaya";
            emp.LastName = "Rout";
            Console.WriteLine(emp.ToString());       // To get result we have to override the toString method.....
            Console.ReadKey();
        }
    }

    public class Employee
    {
        public string? FirstName;
        public string? LastName;
        //Overriding the Virtual ToString method of Object class
        //Overriding the Virtual method using override modifier
        public override string ToString()
        {
            return FirstName + ", " + LastName;
        }
    }
}