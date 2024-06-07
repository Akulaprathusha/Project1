using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module1
{
    internal class Assignment2_2
    {
        public void GuessingGame()
        {
            Random random = new Random();
            int randomNumber = random.Next(1, 101);

            Console.WriteLine("Welcome to the Guessing Game!");
            Console.WriteLine("I'm thinking of a number between 1 and 100.");
            Console.WriteLine("You have 10 guesses.\n");

            int numberOfGuesses = 10;
            for (int guessNumber = 1; guessNumber <= numberOfGuesses; guessNumber++)
            {
                Console.Write($"Guess {guessNumber}: ");
                int userGuess = Convert.ToInt32(Console.ReadLine());

                if (userGuess < randomNumber)
                {
                    Console.WriteLine("Too low!");
                }
                else if (userGuess > randomNumber)
                {
                    Console.WriteLine("Too high!");
                }
                else
                {
                    Console.WriteLine($"Congratulations! You guessed the number in {guessNumber} guesses!");
                    return; 
                }
            }
            Console.WriteLine($"Sorry, you couldn't guess the number. It was {randomNumber}.");
        }
    }
}
