using System;

class Program
{
    static void Main(string[] args)
    {
        string playAgain = "yes";
        Random randomGenerator = new Random();

        while (playAgain.ToLower() == "yes")
        {
            int magicNumber = randomGenerator.Next(1, 101);
            int guess;
            int guessCount = 0;

            Console.WriteLine("Guess My Number Game!");

            do
            {
                Console.Write("What is your guess? ");
                guess = int.Parse(Console.ReadLine());
                guessCount++;

                if (guess < magicNumber)
                {
                    Console.WriteLine("Higher");
                }
                else if (guess > magicNumber)
                {
                    Console.WriteLine("Lower");
                }
                else
                {
                    Console.WriteLine("You guessed it!");
                    Console.WriteLine($"It took you {guessCount} guesses.");
                }
            } while (guess != magicNumber);

            Console.Write("Do you want to play again? (yes/no): ");
            playAgain = Console.ReadLine();
        }

        Console.WriteLine("Thanks for playing!");
    }
}