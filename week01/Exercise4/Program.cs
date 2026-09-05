using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello tech. World! Welcome to Youngchi-Pee programming language of C#!.");

        List<int> numbers = new List<int>();

        do
        {
            Console.Write("Enter a number or type 0 to finish: ");
            string input = Console.ReadLine();

            if (int.TryParse(input, out int number))
            {
                if (number == 0)
                {
                    break;
                }

                numbers.Add(number);
                Console.WriteLine($"{number} was added.");
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid number.");
            }

        } while (true);

        Console.WriteLine("\nNumbers you entered are:");

        foreach (int number in numbers)
        {
            Console.WriteLine(number);
        }
    }
}