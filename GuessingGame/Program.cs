using System;

namespace GuessingGame
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] secretWord = new string[10];
            secretWord[0] = "Country";
            secretWord[1] = "Library";
            secretWord[2] = "Motorcycle";
            secretWord[3] = "Aerodynamic";
            secretWord[4] = "Liberal";
            secretWord[5] = "Processor";
            secretWord[6] = "Gigantic";
            secretWord[7] = "Overblown";
            secretWord[8] = "Keyboard";
            secretWord[9] = "Yodel";

            Random random = new Random();
            int randomNumber = random.Next(0, 9);
           
            string selectedsecretWord = secretWord[randomNumber];

            string guess = "";
            int guessCount = 0;
            int guessLimit = 3;
            bool outOfGuesses = false;

            int wordLength = selectedsecretWord.Length;
            int indexLength = (selectedsecretWord.Length-1);
            string firstLetter = selectedsecretWord.Substring(0,1);
            string lastLetter = selectedsecretWord.Substring(indexLength, 1);

            // Get a random letter from the word (not first or last) as a clue
            int randomLetterNumber1 = random.Next(1, indexLength);
            int randomLetterNumber2 = random.Next(1, indexLength);

            string randomLetter1 = selectedsecretWord.Substring(randomLetterNumber1, 1);
            string randomLetter2 = selectedsecretWord.Substring(randomLetterNumber2, 1);

            Console.WriteLine("  ///////////////////////////////");
            Console.WriteLine(" //// GUESS THE SECRET WORD ////");
            Console.WriteLine("///////////////////////////////");
            Console.WriteLine(" ");
            Console.WriteLine("CLUES:");
            Console.WriteLine("The secret word is " + wordLength + " letters long.");
            Console.WriteLine("It begins with " + firstLetter + " and ends with " + lastLetter + ".");
            //Add 1 to the randomLetterNumber values to shift them from the 0 start position
            Console.WriteLine("Letter " + (randomLetterNumber1+1) + " is " + randomLetter1 + " and letter " + (randomLetterNumber2+1) + " is " + randomLetter2 + ".");
            Console.WriteLine(" ");

            while (guess != selectedsecretWord && !outOfGuesses)
            {
                if (guessCount < guessLimit)
                {
                    if (guessCount == 0)
                    {
                        Console.WriteLine("Enter guess: ");
                    } else
                    {
                        Console.WriteLine("Incorrect, enter guess: ");
                    }
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
                Console.WriteLine("You guessed the secret word (" + selectedsecretWord + ")!");
            }
            

            Console.ReadLine();
        }

    }
}
