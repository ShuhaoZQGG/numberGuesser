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
            Console.ForegroundColor = ConsoleColor.Yellow;

            // Write out app info
            Console.WriteLine("{0}: version: {1} by {2} ", appName, appVersion, appAuthor);

            // Ask user name
            Console.WriteLine("What is your name?");

            // Get user name
            string inputName = Console.ReadLine();

            Console.WriteLine("Hello {0}, Let's play a game",inputName);

            // iniate a correct number
            while(true) { 
                Random random = new Random();
                int correctNumber = random.Next(1, 11);
                int guess = 0;

                // Ask user for number
                Console.WriteLine("Guess a number between 1 and 10");

                // while guess is not correct
                while (guess != correctNumber)
                {
                    // Get user input
                    string input = Console.ReadLine();

                    // Cast to int and put in guess

                    if (!int.TryParse(input, out guess))
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Please Enter a number");
                        Console.ResetColor();

                        //keep going
                        continue;
                    }

                    guess = Int32.Parse(input);

                    if (guess != correctNumber)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;

                        Console.WriteLine("Wrong number, okease try again");

                        Console.ResetColor();
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Green;

                        Console.WriteLine("Nice, you made it!");

                        Console.ResetColor();

                        Console.WriteLine("Do you want to play again? [Y/N]");

                        string decision = Console.ReadLine().ToUpper();

                        if (decision == "Y")
                        {
                            continue;
                        }
                        else if (decision == "N")
                        {
                            return;
                        }
                        else
                        {
                            return;
                        }
                    }
                }
            }
            // Reset Text Color
            Console.ResetColor();
        }
    }
}
