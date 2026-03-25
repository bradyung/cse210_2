class ListingActivity : BaseActivity
{
    List<string> _prompts = new List<string>()
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When hav eyou felt the Holy Ghost this month?",
        "Who are some of your personal hereos?"
    };
    public ListingActivity()
        :base(
            "Listing",
            "This activity will help you reflect on the good things in your life by have you list as many things as you can in a certain area.")
    {
    }
    public void Run()
    {
        DisplayGreeting();
        DisplayDescription();
        SetDuration();
        PrepareToBegin();
        Console.Clear();

        Random random = new Random();
        string prompt = _prompts[random.Next(_prompts.Count)];

        Console.WriteLine("List as many responses as you can to the following prompt:");
        Console.WriteLine();
        Console.WriteLine($"--- {prompt} ---");
        Console.WriteLine();
        Console.Write("You may begin in : ");
        ShowCountDown(8);
        Console.WriteLine();

        int count = 0;
        DateTime endTime = DateTime.Now.AddSeconds(GetDuration());
        while ( DateTime.Now < endTime)
        {
            Console.ReadLine();
            count++;
        }
        Console.WriteLine($"You listed {count} items!");
        DisplayFarewell();
    }
}