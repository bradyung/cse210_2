

using System.Diagnostics;

public class BreathingActivity : BaseActivity
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
        DateTime endTime = DateTime.Now.AddSeconds(GetDuration());
        while (DateTime.Now < endTime)
        {
            Console.Write("Breathe in... ");
            ShowCountDown(4);
            if (DateTime.Now >= endTime)
            {
                break;
            }
            Console.Write("Breath out... ");
            ShowCountDown();
        }
        DisplayFarwell();
    }
}