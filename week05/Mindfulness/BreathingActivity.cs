using System;
using System.Threading;

public class BreathingActivity : Activity
{
    public BreathingActivity() : base(
        "Breathing Activity", 
        "This activity will help you relax by guiding you through slow breathing.")
    {
    }

    public void Run()
    {
        DisplayStartingMessage();
        DateTime endTime = DateTime.Now.AddSeconds(_duration);

        while (DateTime.Now < endTime)
        {
            Console.Write("Breathe in... ");
            ShowCountDown(4);

            Console.WriteLine();

            Console.Write("Now breathe out... ");
            ShowCountDown(6);

            Console.WriteLine("\n");
        }

        DisplayEndingMessage();
    }
}

