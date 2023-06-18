using System;

namespace ThreadingDemo
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Thread t = Thread.CurrentThread;

            t.Name = "My Thread";

            Console.WriteLine("Current executing Thread : "+t.Name);
            Console.WriteLine("Current executing Thread : "+Thread.CurrentThread.Name);
        }
    }
}
