using System;
namespace MultipleInheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            MultipleInheritanceTest obj = new MultipleInheritanceTest();
            obj.Test();
            Console.ReadKey();
        }
    }

    public interface Interface1
    {
        void Test();
    }
    public interface Interface2
    {
        void Test();
    }

    public class MultipleInheritanceTest : Interface1, Interface2
    {
        public void Test()
        {
            Console.WriteLine("Test Method is Implemented in Child Class");
        }
    }
}
