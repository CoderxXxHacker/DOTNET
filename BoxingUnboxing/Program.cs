using System;
using System.Diagnostics;
namespace BoxingUnboxingDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Stopwatch stopwatch1 = new Stopwatch();
            stopwatch1.Start();
            for(int i = 1; i<= 1000000; i++)
            {
                Boxing();
            }
            
            stopwatch1.Stop();
            Console.WriteLine($"Boxing took: {stopwatch1.ElapsedMilliseconds} MS");

            Stopwatch stopwatch2 = new Stopwatch();
            stopwatch2.Start();
            for (int i = 1; i <= 1000000; i++)
            {
                WithoutBoxing();
            }
            stopwatch2.Stop();
            Console.WriteLine($"Without Boxing took: {stopwatch2.ElapsedMilliseconds} MS");

            Stopwatch stopwatch3 = new Stopwatch();
            stopwatch3.Start();
            for(int i = 1; i<= 1000000; i++)
            {
                Unboxing();
            }
            
            stopwatch3.Stop();
            Console.WriteLine($"Unboxing took: {stopwatch3.ElapsedMilliseconds} MS");
            Console.ReadKey();
        }


        //With Boxing
        public static void Boxing()
        {
            int i = 100;
            object j = i; //Boxing
        }

        //Without Boxing
        public static void WithoutBoxing()
        {
            int i = 100;
            int j = i; //No Boxing and No Unboxing
        }

         public static void Unboxing()
        {
            object j = 100;
            int i = (int) j; //Unboxing
        }
    }
}
