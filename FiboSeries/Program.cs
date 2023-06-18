using System;

namespace FiboSeries
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the range...");
            int n = int.Parse(Console.ReadLine());
            for(int i=n ; i>=0; i--)
                Console.Write(fib(n-i)+"\t");
        }

        public static int fib(int m)
        {
            if(m <= 1)
                return m;
            
            return fib(m-1) + fib(m-2);
        }
    }
}