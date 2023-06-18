using System;
using System.Diagnostics;
namespace ThreadingDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();
            Method1();
            Method2();
            Method3();
            stopWatch.Stop();

            TimeSpan ts = stopWatch.Elapsed;
            Console.WriteLine($"Runtime : {stopWatch.ElapsedMilliseconds} mS");

            Console.Read();
        }

        static void Method1()
        {
            for (int i = 1; i <= 50000000; i++)
            {
                //Console.WriteLine("Method1 :" + i);
            }
        }
        
        static void Method2()
        {
            for (int i = 1; i <= 50000000; i++)
            {
                //Console.WriteLine("Method2 :" + i);
            }
        }

        static void Method3()
        {
            for (int i = 1; i <= 50000000; i++)
            {
                //Console.WriteLine("Method3 :" + i);
            }
        }
    }
}
