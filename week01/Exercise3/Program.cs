using System;

class Program
{
    static void Main(string[] args)
    {
        int magicNumber = 12;
        int userGuess;

        do
        {
            Console.Write("Guess a number to match the magic number: ");
            userGuess = int.Parse(Console.ReadLine());

            if (userGuess > magicNumber)
            {
                Console.WriteLine("Wrong guess! try guessing lower.");
            }

            else if (userGuess < magicNumber)
            {
                Console.WriteLine("Wrong guess! try guessing higher.");
            }

            else
            {
                Console.WriteLine("Congratulations! You guessed the magic number!");
                Console.WriteLine("Thank you for testing and using this program by Prosper(Youngchipee). Have a great day!");
            }
        
        } while (userGuess != magicNumber);
    }
}