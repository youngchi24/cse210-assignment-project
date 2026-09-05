using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello tech. World! welcome to Youngchi-Pee programming language of C#!.");

        Console.Write("This is your first name? ");
        string firstName = Console.ReadLine();

        Console.Write("What is your last name? ");
        string lastName = Console.ReadLine();

        Console.WriteLine($"Hello, {firstName} {lastName}!, let's check your grade percentage and see how you did in this course.");

        Console.Write("Enter your grade percentage: ");
        int userInput = int.Parse(Console.ReadLine());

    
        if (userInput >= 91)
        {
            Console.WriteLine("You got an A\nyou did an Excellent work!");
        }

        else if (userInput == 90)
        {
            Console.WriteLine("You got an A-\n marvelous work!");
        }

        else if (userInput > 80 && userInput < 90)
        {
            Console.WriteLine("You got a B\nWeldone! you did a good work!");
        }

        else if (userInput == 80)
        {
            Console.WriteLine("You got a B-!\nGreat work!");
        }

        else if (userInput == 70)
        {
            Console.WriteLine("You got a C!\npassed. You can do better!");
        }

        else if (userInput == 60)
        {
            Console.WriteLine("You got a D!\nPass. Keep trying!");
        }

        else
        {
            Console.WriteLine("You got an F!\nFailed! You need to work harder!");
        }

        Console.WriteLine("Thank you for testing and using this program by Prosper(Youngchipee). Have a great day!");
    }
}