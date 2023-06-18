// Programm to fond fibonacci series triangle..

using System;

public class Program
{

    public  static void Main(String[] args)
    {
        int num, a=0, b=1,sum;
        Console.WriteLine("Enter the number..........");
        num = int.Parse(Console.ReadLine());

        for(int i=1; i<=num; i++)
        {
            Console.Write(0+"\t"+1+"\t");
            a = 0;
            b = 1;
            for(int j=1; j<i; j++)
            {
                sum = a + b;
                Console.Write(sum+"\t");
                a = b;
                b = sum;
            }
            Console.WriteLine();
        }
    }

}
