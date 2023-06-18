using System;
namespace StaticVari
{
    internal class Program
    {

         const float PI = 3.14f; //Constant Variable
        static int x = 100; //Static Variable
        int y = 200; //Non-Static or Instance Variable

        public Program(int a)
        {
            y = a;
        }


        static void Main(string[] args)
        {
            int z = 1000; //Static Variable

            Console.WriteLine($"Z: {z}");
            Console.WriteLine($"PI value: {PI}");
           // Program obj = new Program();
            Program obj1 = new Program(300);
            Program obj2 = new Program(400);

            Console.WriteLine($"x value: {x}");
            
            Console.WriteLine($"obj1 y value: {obj1.y}");
            Console.WriteLine($"obj2 y value: {obj2.y}");
            Console.Read();
        }
    }
}