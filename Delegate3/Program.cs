using System;
using System.Reflection;

namespace DelegatesDemo
{
    public delegate void DoSomeMethodHandler(string message);

    class Program
    {
        static void Main(string[] args)
        {
            SomeClass obj = new SomeClass();
            DoSomeMethodHandler del1 = new DoSomeMethodHandler(obj.DoSomework);

            MethodInfo Method = del1.Method;
            object Target = del1.Target;
            Delegate[] InvocationList = del1.GetInvocationList();

            Console.WriteLine($"Method Property: {Method}");
            Console.WriteLine($"Target Property: {Target}");
           
            foreach (var item in InvocationList)
            {
                Console.WriteLine($"InvocationList: {item}");
            }
            
            Console.ReadKey();
        }
    }

    public class SomeClass
    {
        public void DoSomework(string message)
        {
            Console.WriteLine("DoSomework Executed");
            Console.WriteLine($"Hello: {message}, Good Morning");
        }
    }
}
