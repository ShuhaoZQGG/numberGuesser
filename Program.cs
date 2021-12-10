using System;

// Namespace
namespace numberGuesser
{
    //Main Class
    internal class Program
    {
        //Entry Point Method
        static void Main(string[] args)
        {
            // Code Start Here
            string appName = "Number Guesser";
            string appVersion = "1.0.0";
            string appAuthor = "Shuhao Zhang";

            // Change text color
            Console.ForegroundColor = ConsoleColor.Green;

            // Write out app info
            Console.WriteLine("{0}: version: {1} by {2} ", appName, appVersion, appAuthor);
            
            // Reset Text Color
            Console.ResetColor();
        }
    }
}
