class ListingActivity : Activity
{
    private List<string> _prompts = new List<string>
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };

    public ListingActivity()
        : base(
            "Listing Activity",
            "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.",
            0)
    {
    }

    public void Run()
    {
        DisplayStartingMessage();

        ShowPrompt();

        int duration = GetDuration();
        DateTime endTime = DateTime.Now.AddSeconds(duration);

        List<string> items = GetListFromUser(endTime);

        Console.WriteLine($"\nYou listed {items.Count} items!");

        DisplayEndingMessage();
    }

    private void ShowPrompt()
    {
        Random random = new Random();
        int index = random.Next(_prompts.Count);

        Console.WriteLine("\nList as many responses as you can to the following prompt:");
        Console.WriteLine($"--- {_prompts[index]} ---");

        Console.Write("\nYou may begin in: ");
        ShowCountDown(5);

        Console.WriteLine();
    }

    private List<string> GetListFromUser(DateTime endTime)
    {
        List<string> items = new List<string>();

        while (DateTime.Now < endTime)
        {
            Console.Write("> ");
            string item = Console.ReadLine();

            if (!string.IsNullOrWhiteSpace(item))
            {
                items.Add(item);
            }
        }

        return items;
    }
}