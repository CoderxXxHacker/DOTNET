using System;
namespace Recursion1
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 1;
            //fun1(x);
            fun2(x);
            Console.ReadKey();
        }

        static void fun1(int n)
        {
            if (n > 0)
            {
                Console.Write($"{n} ");
                fun1(n - 1);
            }
        }

        static void fun2(int n)
        {
            if (n < 100)
            {
                fun2(n + 1);
                Console.Write($"{n} ");
            }
        }
    }
}
