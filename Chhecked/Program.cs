using System;
namespace CheckedUncheckedDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 2147483647;
            int b= 2147483647;

            //int c = checked(a + b);    // Checks for max value........of int data types.
            // produces system overflow exception.....

            int c = unchecked(a + b);
                     
            Console.WriteLine(c);
            Console.ReadKey();
        }
    }
}
