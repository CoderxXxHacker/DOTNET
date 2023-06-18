using System;

namespace ControlFlowDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 1;
            do
            {
                
                number++;
                Console.Write($"{number} ");
            } while (number <= 5);

            Console.ReadKey();
        }
    }
}