using System;

namespace NumberGuesser // Note: actual namespace depends on the project name.
{
     class Program
    {
        static void Main(string[] args)
        {
            string appName = "Number Guesser";
            string appVersion = "1.0.0";
            string appAuthor = "Lilitha Ngele";

            Console.ForegroundColor = ConsoleColor.DarkMagenta;

            Console.WriteLine("{0}: Version {1} by {2}", appName, appVersion, appAuthor);

            Console.ResetColor();

            Console.WriteLine("What is your name?");

            string inputName = Console.ReadLine();

            Console.WriteLine("Hello {0}, let's play a game...", inputName);

            while (true)

            {
                // int correctNumber = 7;

                Random random = new Random();
                int correctNumber = random.Next(1, 10);

                int guess = 0;

                Console.WriteLine("Guess a number between 1 and 10 ");

                while (guess != correctNumber)
                {
                    string input = Console.ReadLine();

                    if (!int.TryParse(input, out guess))
                    {
                        Console.ForegroundColor = ConsoleColor.Red;

                        Console.WriteLine("Please enter an actual number");

                        Console.ResetColor();

                        continue;
                    }

                    guess = int.Parse(input);

                    if (guess != correctNumber)
                    {

                        Console.ForegroundColor = ConsoleColor.Red;

                        Console.WriteLine("Wrong number, please try again");

                        Console.ResetColor();
                    }

                }


                Console.ForegroundColor = ConsoleColor.Green;

                Console.WriteLine($"Correct numbver, Well done!");

                Console.ResetColor();

                Console.WriteLine("Play againg? [Y or N]");

                string answer = Console.ReadLine().ToUpper();

                if (answer =="Y" )
                {
                    continue;
                }
                else if (answer =="N")
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
}