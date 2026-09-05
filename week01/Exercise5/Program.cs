using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayMessage();
        string name = UserName();
        int number = UserNumber();
        int Square = SquareNumber(number);
        DisplayResult(name, Square);
    }
    static void DisplayMessage()
    {
        Console.WriteLine("Welcome to the program!.");
    }

    static string UserName()
    {
        Console.Write("Please enter your full name: ");
        string name = Console.ReadLine();
        return name;
    }

    static int UserNumber()
    {
        Console.Write("Enter a lucky number: ");
        int number = int.Parse(Console.ReadLine());
            return number;
    }

    static int SquareNumber(int number)
    {
        int square = number * number;
        return square;
    }

    static void DisplayResult(string name, int square)
    {
        Console.WriteLine($"{name}, the square of your number is {square}");
    }
}