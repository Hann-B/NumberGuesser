﻿using System;
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
            Random rnd = new Random();
            int targetNumber = rnd.Next(100) + 1;
            int userGuess = 0;
            int guessCount = 0;
            int[] pastGuessesArray = new int[5];

            Console.WriteLine("You have 5 guesses to get the right number!");
            Console.WriteLine("Guess a number between 1 and 100");

            while (userGuess != targetNumber && guessCount < 5)
            {
                pastGuessesArray[guessCount] = userGuess;
                int.TryParse(Console.ReadLine(), out userGuess);

                if (userGuess < targetNumber)
                {
                    guessCount++;
                    Console.WriteLine($"The number I am thinking of is higher than {userGuess}, Try again");
                }
                else if (userGuess > targetNumber)
                {
                    guessCount++;
                    Console.WriteLine($"The number I am thinking of is lower than {userGuess}, Try again");
                }
                else if (guessCount == 4)
                {
                    //guessCount++;
                    Console.WriteLine("You Lose, Whomp Whomp.");
                }
                else
                {
                    Console.WriteLine("Great job! You guessed right!");
                }
            }
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"Your guesses this game have been {pastGuessesArray}");
            }
        }
    }
}

