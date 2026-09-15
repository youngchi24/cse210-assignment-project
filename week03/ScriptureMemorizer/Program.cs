class Program
{
    static void Main(string[] args)
    {
        // Creativity feature:
        // This program can be easily changed to use different
        // scriptures by changing the reference and scripture text.
        // Create the scripture reference
        Reference reference = new Reference("John", 3, 16);

        // Create the scripture
        Scripture scripture = new Scripture(
            reference,
            "For God so loved the world that he gave his only begotten Son"
        );

        // Display the complete scripture
        Console.WriteLine(scripture.GetDisplayText());

        // Continue until all words are hidden
        while (!scripture.IsCompletelyHidden())
        {
            Console.WriteLine();
            Console.Write("Press Enter to hide words or type 'quit' to exit: ");

            string input = Console.ReadLine();

            if (input.ToLower() == "quit")
            {
                break;
            }

            // Hide 3 random words
            scripture.HideRandomWords(3);

            // Clear the screen
            Console.Clear();

            // Display the scripture again
            Console.WriteLine(scripture.GetDisplayText());
        }

        Console.WriteLine();
        Console.WriteLine("All words are hidden. Program finished.");
    }
}