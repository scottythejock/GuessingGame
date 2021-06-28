using System;

namespace GuessingGame
{
    class Program
    {
        static void Main(string[] args)
        {
            string secretWord = "giraffe";
            string guess = "";
            int guessCount = 0;
            int guessLimit = 3;
            bool outOfGuesses = false;


            Console.WriteLine("  ///////////////////////////////");
            Console.WriteLine(" //// GUESS THE SECRET WORD ////");
            Console.WriteLine("///////////////////////////////");
            Console.WriteLine(" ");
            

            while(guess != secretWord && !outOfGuesses)
            {
                if (guessCount < guessLimit)
                {
                    Console.WriteLine("Enter guess: ");
                    guess = Console.ReadLine();
                    guessCount++;
                } else
                {
                    outOfGuesses = true;
                }
                
            }
            Console.WriteLine(" ");
            if (outOfGuesses)
            {
                Console.WriteLine("You ran out of guesses!");
            } else
            {
                Console.WriteLine("You guessed the secret word (" + secretWord + ")!");
            }
            

            Console.ReadLine();
        }
    }
}
