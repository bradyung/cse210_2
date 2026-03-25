

class BreathingActivity : BaseActivity
{
    public BreathingActivity()
        : base(
            "Breathing",
            "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.")
    {
    }

    public void Run()
    {
        DisplayGreeting();
        DisplayDescription();
        SetDuration();
        PrepareToBegin();
        Console.Clear();
        DateTime endTime = DateTime.Now.AddSeconds(GetDuration());
        while (DateTime.Now < endTime)
        {
            Console.Write("Breath in... ");
            ShowCountDown(6);
            if (DateTime.Now >= endTime)
            {
                break;
            }
            Console.Write("Breath out... ");
            ShowCountDown(6);
        }
        DisplayFarewell();
    }
}