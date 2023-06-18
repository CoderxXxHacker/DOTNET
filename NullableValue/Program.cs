using System;

namespace  NullableValue
{
    class Program
    {
       // static int j = null;  Compile error....
        public static void Main(string[] args)
        {
            Nullable<int> i = null;

            if(i.HasValue)
                Console.WriteLine(i.Value);
            else
                Console.WriteLine("Null");


            Console.WriteLine($"i = {i}");
        }
        
    }
}