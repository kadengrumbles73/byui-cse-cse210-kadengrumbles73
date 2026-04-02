using System;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> activities = new List<Activity>();

        activities.Add(new Running(new DateOnly(2026, 04, 1), 30, 4.8));
        activities.Add(new Cycling(new DateOnly(2026, 04, 2), 45, 20.5));
        activities.Add(new Swimming(new DateOnly(2026, 04, 4), 20, 20));

        foreach (Activity activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}