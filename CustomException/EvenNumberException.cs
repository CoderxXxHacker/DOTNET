using System;
namespace ExceptionHandlingDemo
{
    //Creating our own Exception Class by inheriting Exception class
    public class OddNumberException : Exception
    {
        public OddNumberException()
        {
        }

        public OddNumberException(string message)
            : base(message)
        {
        }

        public OddNumberException(string message, Exception inner)
            : base(message, inner)
        {
        }
      
        //Overriding the HelpLink Property
        public override string HelpLink
        {
            get
            {
                return "Get More Information from here: https://dotnettutorials.net/lesson/create-custom-exception-csharp/";
            }
        }
    }
}