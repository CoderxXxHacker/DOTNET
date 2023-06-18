using System;
namespace JumpStatementDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("C#Tutorials ");
            Console.Write("Welcome ");
            XYZ:
                Console.Write("X ");
                Console.Write("Y ");
                goto ABC;
                Console.Write("Programming ");
            ABC:
                Console.Write("Hello1 ");
                Console.Write("Hello2");

            Console.ReadKey();
        }
    }
}
