//  Function overloading.......

using System;
namespace FunctionOverloading
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 10, b = 2, c = 15, d;
            c = add(a, b);
            Console.WriteLine($"Sum of {a} and {b} is {c}");
            d = add(a, b, c);
            Console.WriteLine($"Sum of {a} and {b} and {c} is {d}");
            Console.WriteLine($"Sum of 10.5 and 25.6 is {add(10.5f, 25.6f)}");
            Console.ReadKey();
        }
        static int add(int x, int y)
        {
            return x + y;
        }
        static int add(int x, int y, int z)
        {
            return x + y + z;
        }

        static float add(float x, float y)
        {
            return x + y;
        }

    }
}
