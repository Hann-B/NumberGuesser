using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var targetNumber = new Random().Next(1, 101);
            //int targetNumber = rnd.Next(100) + 1;
            var pastGuesses = new int[5];
            int guessCount = 0;
            int userGuess = 0;

            Console.WriteLine("You have 5 guesses to get the right number!");
            Console.WriteLine("Guess a number between 1 and 100");

            while (userGuess != targetNumber && guessCount < 5)
            {
                int.TryParse(Console.ReadLine(), out userGuess);

                var wasAlreadyGuess = false;
                foreach(var guess in pastGuesses)
                {
                    if (guess == userGuess)
                    {
                        wasAlreadyGuess = true;
                    }
                }
                if (wasAlreadyGuess)
                {
                    Console.WriteLine("You already guessed that, fool");
                }
                pastGuesses[guessCount] = userGuess;

                if (userGuess < targetNumber && guessCount < 4)
                { 
                    Console.WriteLine($"The number I am thinking of is higher than {userGuess}, Try again");
                }
                else if (userGuess > targetNumber && guessCount < 4)
                {
                    Console.WriteLine($"The number I am thinking of is lower than {userGuess}, Try again");
                }
                guessCount++;
                Console.WriteLine("Here are you previous guesses: ");
            }
                foreach (int guess in pastGuesses)
                {
                    if (guess != 0)
                    {
                        Console.Write($"{guess},");
                    }
                }
            if (guessCount > 4)
            {
                Console.WriteLine("You Lose, Whomp Whomp.");
            }
            else
            {
                Console.WriteLine("Great job! You guessed right!");
            }
        }

    }
}

