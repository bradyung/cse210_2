

class BaseActivity
{
    private string _name;
    private string _description;
    private int _duration;
    private DateTime _endTime;

    public BaseActivity(string name, string description)
    {
        _name = name;
        _description = description;
        _duration = 0;
        _endTime = DateTime.Now;
    }
    public void DisplayGreeting()
    {
        Console.Clear();
        Console.WriteLine($"Welcome to the {_name} activity.");
    }
    public void DisplayFarewell()
    {
        DisplaySpinner("Well done! ", 3);
    }
    public void DisplayDescription()
    {
        Console.WriteLine(_description);
    }
    public void DisplaySpinner(string message, int seconds)
    {
        DateTime currentTime = DateTime.Now;
        DateTime endTime = currentTime.AddSeconds(seconds);
        int sleepTime = 200;
        string animationString = "-\\|/";
        int index = 0;

        Console.Write($"{message} ");

        while(DateTime.Now < endTime)
        {
            Console.Write(animationString[index++ % animationString.Length]);
            Thread.Sleep(sleepTime);
            Console.Write("\b");
        }

    }
    public void ShowCountDown(int seconds)
    {
        int sleepTime = 1000;

        for (int i = seconds; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(sleepTime);
            Console.Write("\b \b");
        }
    }
    public int GetDuration()
    {
        return _duration;
    }
}