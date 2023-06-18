using System;

namespace UnderstandingObjectClassMethods
{
    public class Program
    {
        public static void Main()
        {
            Customer C1 = new Customer();
            Convert.ToString(C1);
            Console.WriteLine(C1);

            String Name = "anil";
            Convert.ToString(Name);

            Console.WriteLine(Name);

            Console.WriteLine("No Error");
            Console.ReadKey();
        }
    }
    public class Customer
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}