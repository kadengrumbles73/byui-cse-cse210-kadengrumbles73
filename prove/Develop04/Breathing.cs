public class BreathingActivity : Activity
{
    public BreathingActivity() : base("Breathing Activity", 
        "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.")
    {
    }
    public void Run()
    {
        DisplayStartingMessage();
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);
        
        while (DateTime.Now < endTime)
        {
            /*// breathe in
            Console.WriteLine();
            Console.Write("breathe in...");
            ShowCountDown(4);

            // breathe out
            Console.WriteLine();
            Console.Write("breathe out...");
            ShowCountDown(6);*/

            ShowBreathAnimation(10);
        }
        
        DisplayEndingMessage();
    }
    
    
    
}