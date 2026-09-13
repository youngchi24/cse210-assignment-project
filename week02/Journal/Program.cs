using System;

class Program
{
    static void Main(string[] args)
    {
        // Creativity and Exceeding Requirements:

        // I exceeded the core requirements by creating eight different
        // journal prompts instead of the required five. This gives the
        // user more variety when writing journal entries.
        // I made the program randomly choose a prompt each time the
        // user writes a new entry.
        // I also added an empty-journal check when displaying the journal,
        // so the program gives the user a helpful message when there are
        // no entries instead of displaying nothing.
        // I organized the program into separate classes. The Entry class
        // handles individual journal entries, the Journal class manages
        // the collection of entries, and the Program class handles the
        // user interface. This demonstrates abstraction and keeps the
        // program organized.

        Journal journal = new Journal();

        List<string> prompts = new List<string>
        {
            "Who was the most interesting person I interacted with today?",
            "What was the best part of my day?",
            "How did I see the hand of the Lord in my life today?",
            "What was the strongest emotion I felt today?",
            "If I had one thing I could do over today, what would it be?",
            "What is one thing I learned today?",
            "What is something I am grateful for today?",
            "What goal do I want to accomplish tomorrow?"
        };

        Random random = new Random();

        bool running = true;

        while (running)
        {
            Console.WriteLine();
            Console.WriteLine("Journal Menu");
            Console.WriteLine("1. Write a new entry");
            Console.WriteLine("2. Display the journal");
            Console.WriteLine("3. Save the journal to a file");
            Console.WriteLine("4. Load the journal from a file");
            Console.WriteLine("5. Quit");
            Console.Write("Select a choice: ");

            string choice = Console.ReadLine();

            if (choice == "1")
            {
                int index = random.Next(prompts.Count);

                string prompt = prompts[index];

                Console.WriteLine();
                Console.WriteLine(prompt);
                Console.Write("> ");

                string response = Console.ReadLine();

                string date = DateTime.Now.ToString("yyyy-MM-dd");

                Entry newEntry = new Entry(date, prompt, response);

                journal.AddEntry(newEntry);

                Console.WriteLine("Entry added successfully!");
            }
            else if (choice == "2")
            {
                Console.WriteLine();

                if (journal._entries.Count == 0)
                {
                    Console.WriteLine("Your journal is empty.");
                }
                else
                {
                    journal.Display();
                }
            }
            else if (choice == "3")
            {
                Console.Write("Enter filename: ");
                string filename = Console.ReadLine();

                journal.SaveToFile(filename);

                Console.WriteLine("Journal saved successfully!");
            }
            else if (choice == "4")
            {
                Console.Write("Enter filename: ");
                string filename = Console.ReadLine();

                journal.LoadFromFile(filename);

                Console.WriteLine("Journal loaded successfully!");
            }
            else if (choice == "5")
            {
                running = false;
                Console.WriteLine("thank you for using Prosper Chi-Pee's Journal! Goodbye!");
            }
            else
            {
                Console.WriteLine("Invalid choice. Please try again.");
            }
        }
    }
}