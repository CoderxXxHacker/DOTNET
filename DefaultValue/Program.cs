using System;
namespace DefaultValue
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Default Value of Byte: {default(byte)} ");
            Console.WriteLine($"Default Value of Integer: {default(int)}");
            Console.WriteLine($"Default Value of Float: {default(float)}");
            Console.WriteLine($"Default Value of Long: {default(long)}");
            Console.WriteLine($"Default Value of Double: {default(double)}");
            Console.WriteLine($"Default Value of Character: {default(char)}");
            Console.WriteLine($"Default Value of Boolean: {default(bool)}");
            Console.ReadKey();
        }
    }
} 