using System;
namespace DataTypeByte
{
    class Program
    {
        static void Main(string[] args)
        {
            byte b1 = 66;
            //You cannot store negative number using byte data type.
            //The following statement will give compile time error
            //byte b2 = -100;

            //The following Statement will give compile time error
            //The maximum value you can store in a byte variable is 255
            //byte b3 = 256;

            Console.WriteLine($"Decimal: {b1}");
            Console.WriteLine($"ASCII Equivalent Character of {b1} is {(char)b1}");
            Console.WriteLine($"Byte Min Value:{sbyte.MinValue} and Max Value:{sbyte.MaxValue}");
            Console.WriteLine($"Byte Size:{sizeof(sbyte)} Byte");
            
            sbyte sb1 = 66;
            //You can store negative number using sbyte data type.
            //The following statement will not give compile time error
            sbyte sb2 = -100;

            //The following Statement will give compile time error
            //The maximum value you can store in a sbyte variable is 128
            //sbyte sb3 = 128;

            //The following Statement will give compile time error
            //The minimum value you can store in a sbyte variable is -128
            //sbyte sb4 = -129;

            Console.WriteLine($"\nDecimal: {sb1}");
            Console.WriteLine($"ASCII Equivalent Character of {sb1} is {(char)sb1}");
            Console.WriteLine($"ASCII Equivalent Character of {sb2} is {(char)sb2}");
            Console.WriteLine($"SByte Min Value:{sbyte.MinValue} and Max Value:{sbyte.MaxValue}");
            Console.WriteLine($"SByte Size:{sizeof(sbyte)} Byte");

            string str = "ABC";
            var howManyBytes = str.Length * sizeof(Char);
            Console.WriteLine($"str Value: {str}");
            Console.WriteLine($"str Size: {howManyBytes}");

            //  Int16 num1 = 123;
            // Int32 num2 = 456;
            // Int64 num3 = 789;
            // Console.WriteLine($"Int16 Min Value:{Int16.MinValue} and Max Value:{Int16.MaxValue}");
            // Console.WriteLine($"Int16 Size:{sizeof(Int16)} Byte");
            // Console.WriteLine($"Int32 Min Value:{Int32.MinValue} and Max Value:{Int32.MaxValue}");
            // Console.WriteLine($"Int32 Size:{sizeof(Int32)} Byte");
            // Console.WriteLine($"Int64 Min Value:{Int64.MinValue} and Max Value:{Int64.MaxValue}");
            // Console.WriteLine($"Int64 Size:{sizeof(Int64)} Byte");

             short num1 = 123;
            //Int32 num2 = 456;
            int num2 = 456;
            // Int64 num3 = 789;
            long num3 = 789;
            Console.WriteLine($"short Min Value:{short.MinValue} and Max Value:{short.MaxValue}");
            Console.WriteLine($"short Size:{sizeof(short)} Byte");
            Console.WriteLine($"int Min Value:{int.MinValue} and Max Value:{int.MaxValue}");
            Console.WriteLine($"int Size:{sizeof(int)} Byte");
            Console.WriteLine($"long Min Value:{long.MinValue} and Max Value:{long.MaxValue}");
            Console.WriteLine($"long Size:{sizeof(long)} Byte");

            Single a = 1.123f; //float
            Double b = 1.456;   //double
            Decimal c = 1.789M;  //decimal
            
            Console.WriteLine($"Single Size:{sizeof(Single)} Byte");
            Console.WriteLine($"Single Min Value:{Single.MinValue} and Max Value:{Single.MaxValue}");
            Console.WriteLine($"Double Size:{sizeof(Double)} Byte");
            Console.WriteLine($"Double Min Value:{Double.MinValue} and Max Value:{Double.MaxValue}");
            Console.WriteLine($"Decimal Size:{sizeof(Decimal)} Byte");
            Console.WriteLine($"Decimal Min Value:{Decimal.MinValue} and Max Value:{Decimal.MaxValue}");


            Console.ReadKey();
        }
    }
}