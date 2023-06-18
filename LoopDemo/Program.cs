using System;

namespace LoopDemo
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int i, n, j, k;
            Console.Write("Enter a Number : ");
            n = Convert.ToInt32(Console.ReadLine());
            i = 0;
            j = 1;
            Console.Write($"{i} {j}");
           
            k = i + j;
            while (k <= n)
            {
                Console.Write($" {k}");
                
                i = j;
                j = k;
                k = i + j;
            }
            Console.ReadKey();
        }
       
    }
}