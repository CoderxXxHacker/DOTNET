using System;
namespace ExtensionMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            string myWord = "Welcome to Dotnet Tutorials Extension Methods Article #";
            int wordCount = myWord.GetWordCount();
            Console.WriteLine("string : " + myWord);
            Console.WriteLine("Count : " + wordCount);
            Console.Read();
        }
    }
}