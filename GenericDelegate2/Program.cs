using System;
namespace LambdaExpressionDemo
{
    public class LambdaExpression
    {
        public delegate string GreetingsDelegate(string name);

        static void Main(string[] args)
        {


            //Using lamda function......

            GreetingsDelegate obj = (name) =>
            {
                return "Hello @" + name + " welcome to Dotnet Tutorials";
            };

            string GreetingsMessage = obj.Invoke("Anil");
            Console.WriteLine(GreetingsMessage);
            Console.ReadKey();
        }

        public static string Greetings(string name)
        {
            return "Hello @" + name + " welcome to Dotnet Tutorials";
        }
    }
}
