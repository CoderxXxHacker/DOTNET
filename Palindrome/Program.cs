// Program to find Palindrome number using recursion.......

using System;

namespace Check_Palindrome
{
    public class Ispalindrome
    {
        static int reverse = 0;
        public static int reverseNumber(int n)
        {
            if(n == 0)
                return reverse;
            
           
                reverse = 10 * reverse + n % 10;
                return reverseNumber(n / 10);
            
        }

        public static void Main(String[] args)
        {
            Console.WriteLine("=========PALINDROME NUMBER=========");
            Console.WriteLine("Enter the number......");
            int num = Convert.ToInt32(Console.ReadLine());

            int temp = num;
            

            Console.WriteLine(temp == reverseNumber(num) ? temp + " is Palindrome" : temp + " is not Palindrome");
        }
    }
}