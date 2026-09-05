using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Welcome to CSE 210! the Home of Tech.");

        Console.Write("What is your first name? ");
        string firstName = Console.ReadLine();

        Console.Write("What is your last name? ");
        string lastName = Console.ReadLine();
        
        Console.WriteLine($"Nice to meet you, {lastName} {firstName}!. This is your first program in C#.");

    }
}