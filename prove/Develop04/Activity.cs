using System;
public abstract class Activity
{
    protected string _name;
    protected string _description;
    protected int _duration;
    public Activity(string name, string description)
    {
        _name = name;
        _description = description;
    }

    public void DisplayStartingMessage()
    {
        Console.Clear();
        Console.WriteLine($"Welcome to the {_name}.");
        Console.WriteLine();
        Console.WriteLine(_description);
        Console.WriteLine();
        Console.Write("How long, in seconds, would you like for your session? ");
        
        // Storing the duration for use in the Run() loops
        _duration = int.Parse(Console.ReadLine());

        Console.Clear();
        Console.WriteLine("Get ready...");
        ShowSpinner(3);
    }

    public void DisplayEndingMessage()
    {
        Console.WriteLine();
        Console.WriteLine("Well done!!");
        ShowSpinner(3);
        Console.WriteLine($"You have completed another {_duration} seconds of the {_name}.");
        ShowSpinner(3);
    }
    public void ShowSpinner(int seconds)
    {
        List<string> animationStrings = new List<string> { "|", "/", "-", "\\" };

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(seconds);

        int i = 0;

        while (DateTime.Now < endTime)
        {
            string s = animationStrings[i];
            Console.Write(s);
            Thread.Sleep(250);
            Console.Write("\b \b"); 

            i++;

            if (i >= animationStrings.Count)
            {
                i = 0;
            }
        }
        
    }

    public void ShowCountDown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }

    public void ShowBreathAnimation(int seconds)
    {
        int halfTime = seconds / 2;

        // Breathe In
        Console.Write("Breathe in");
        for (int i = 0; i < halfTime; i++)
        {
            Console.Write(".");
            Thread.Sleep(1000);
        }

        // Clear the dots 
        for (int i = 0; i < halfTime; i++)
        {
            Console.Write("\b \b");
        }

        // Breathe Out 
        // overwrite "Breathe in" with "Breathe out"
        Console.Write("\b\b\b\b\b\b\b\b\b\b"); // Clear "Breathe in"
        Console.Write("Breathe out...");

        for (int i = 3; i > 0; i--)
        {
            Thread.Sleep(1000);
            Console.Write("\b \b"); // Remove one dot at a time
        }
        Console.WriteLine();
    }
}

