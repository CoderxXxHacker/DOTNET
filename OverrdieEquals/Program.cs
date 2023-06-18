using System;
namespace UnderstandingObjectClassMethods
{
    public class Program
    {
        public static void Main()
        {
            Customer C1 = new Customer();
            C1.FirstName = "Pranaya";
            C1.LastName = "Rout";

            Customer C2 = new Customer();
            C2.FirstName = "Pranaya";
            C2.LastName = "Rout";

            var hashcode1 = C1.GetHashCode();
            var hashcode2 = C2.GetHashCode();

            Console.WriteLine($"C1.GetHashCode == C2.GetHashCode:{hashcode1 == hashcode2}");
            Console.WriteLine($"C1 == C2:{C1 == C2}");
            Console.WriteLine($"C1.Equals(C2):{C1.Equals(C2)}");

            Console.ReadKey();
        }
    }
    public class Customer
    {
        public string? FirstName { get; set; }
        public string? LastName { get; set; }

        public override bool Equals(object obj)
        {
            // If the passed object is null
            if (obj == null)
            {
                return false;
            }
            if (!(obj is Customer))
            {
                return false;
            }
            return (this.FirstName == ((Customer)obj).FirstName)
                && (this.LastName == ((Customer)obj).LastName);
        }

        //Overriding the GetHashCode method
        //GetHashCode method generates hashcode for the current object
        public override int GetHashCode()
        {
            //Performing BIT wise OR Operation on the generated hashcode values
            //If the corresponding bits are different, it gives 1.
            //If the corresponding bits are the same, it gives 0.
            return FirstName.GetHashCode() ^ LastName.GetHashCode();
        }
    }
}