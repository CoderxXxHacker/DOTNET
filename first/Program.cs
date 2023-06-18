//Program to show the use of Console Class Properties and Beep Method
using System;
namespace First
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;
            Console.Title = "Understanding Console Class";
            Console.WriteLine("BackgroundColor: Blue");
            Console.WriteLine("ForegroundColor: White");
            Console.WriteLine("Title: Understanding Console Class");

            //It will make Beep Sound
            Console.Beep();

            Console.ReadKey();
        }
    }
}