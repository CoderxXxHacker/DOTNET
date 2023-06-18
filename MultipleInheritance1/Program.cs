using System;
namespace MultipleInheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            MultipleInheritanceTest obj = new MultipleInheritanceTest();
            obj.Test();
            //You cannot call the Show method using obj
            //obj.Show();

            //Using Interface Reference call the Show method
            Interface1 i1 = obj;
            i1.Show();

            //Typecase the object to interface type and call the show method
            ((Interface2)obj).Show();

            Console.ReadKey();
        }
    }

    public interface Interface1
    {
        void Test();
        void Show();
    }
    public interface Interface2
    {
        void Test();
        void Show();
    }

    public class MultipleInheritanceTest : Interface1, Interface2
    {
        //Normal Implementation
        public void Test()
        {
            Console.WriteLine("Test Method is Implemented in Child Class");
        }
        void Interface1.Test()
        {
            Console.WriteLine("Interface1 Test Method is Implemented in Child Class");
        }

        //Explicit Interface Implementation
        void Interface1.Show()
        {
            Console.WriteLine("Interface1 Show Method is Implemented in Child Class");
        }

        //Explicit Interface Implementation
        void Interface2.Show()
        {
            Console.WriteLine("Interface2 Show Method is Implemented in Child Class");
        }
    }
}