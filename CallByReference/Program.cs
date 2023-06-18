using System;
namespace CallByreference
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 15;
            UpdateValue(out a);               //ref keywords can be used ..
            Console.WriteLine(a);
            Console.ReadKey();
        }

        static void UpdateValue(out int b)     //ref keywords can be used ..
        {
            b = 30;
        }
    }
}
