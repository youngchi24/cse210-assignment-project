class ReflectingActivity : Activity
{
    private List<string> _prompts = new List<string>
    {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
    };

    private List<string> _questions = new List<string>
    {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times when you were not as successful?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience that applies to other situations?",
        "What did you learn about yourself through this experience?",
        "How can you keep this experience in mind in the future?"
    };

    public ReflectingActivity()
        : base(
            "Reflection Activity",
            "This activity will help you reflect on times in your life when you have shown strength and resilience.",
            0)
    {
    }

    public void Run()
    {
        DisplayStartingMessage();

        ShowPrompt();

        int duration = GetDuration();
        DateTime endTime = DateTime.Now.AddSeconds(duration);

        ShowQuestions(endTime);

        DisplayEndingMessage();
    }

    private void ShowPrompt()
    {
        Random random = new Random();
        int index = random.Next(_prompts.Count);
        string prompt = _prompts[index];

        Console.WriteLine("\nConsider the following prompt:");
        Console.WriteLine($"--- {prompt} ---");

        Console.Write("\nWhen you have something in mind, press Enter to continue.");
        Console.ReadLine();
    }

    private void ShowQuestions(DateTime endTime)
    {
        Random random = new Random();

        while (DateTime.Now < endTime)
        {
            int index = random.Next(_questions.Count);
            string question = _questions[index];

            Console.WriteLine();
            Console.Write(question );
            Console.ReadLine();

            ShowSpinner(8);
        }
    }
}