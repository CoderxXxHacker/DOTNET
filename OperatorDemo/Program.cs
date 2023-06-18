using System;
namespace OperatorDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            int Result;
            int Num1 = 20, Num2 = 10;

            // Addition Operation
            Result = (Num1 + Num2);
            Console.WriteLine($"Addition Operator: {Result}" );

            // Subtraction Operation
            Result = (Num1 - Num2);
            Console.WriteLine($"Subtraction Operator: {Result}");

            // Multiplication Operation
            Result = (Num1 * Num2);
            Console.WriteLine($"Multiplication Operator: {Result}");

            // Division Operation
            Result = (Num1 / Num2);
            Console.WriteLine($"Division Operator: {Result}");

            // Modulo Operation
            Result = (Num1 % Num2);
            Console.WriteLine($"Modulo Operator: {Result}");

            bool x = true, y = false, z;
            //Logical AND operator
            z = x && y;
            Console.WriteLine("Logical AND Operator (&&) : " + z);
            //Logical OR operator
            z = x || y;
            Console.WriteLine("Logical OR Operator (||) : " + z);
            //Logical NOT operator
            z = !x;
            Console.WriteLine("Logical NOT Operator (!) : " + z);

            int a = 12, b = 25;
            // Bitwise AND Operator
            Result = a & b;
            Console.WriteLine($"Bitwise AND: {Result}");
            // Bitwise OR Operator
            Result = a | b;
            Console.WriteLine($"Bitwise OR: {Result}");
            // Bitwise XOR Operator
            Result = a ^ b;
            Console.WriteLine($"Bitwise XOR: {Result}");

            //Bitwise operations on bool variables is equivalent to logical operators....
            bool c = true, d = false, Result1;
            // Bitwise AND Operator
            Result1 = c & d;
            Console.WriteLine($"Bitwise AND: {Result1}");
            // Bitwise OR Operator
            Result1 = c | d;
            Console.WriteLine($"Bitwise OR: {Result1}");
            // Bitwise XOR Operator
            Result1 = c ^ d;
            Console.WriteLine($"Bitwise XOR: {Result1}");

            Console.ReadKey();
        }
    }
}