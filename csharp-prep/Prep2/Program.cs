using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep 2 World!");
        Console.WriteLine("What is your class percentage");
        string answer = Console.ReadLine();
        int percentage = int.Parse(answer);
        if (percentage >= 70)
        {
            Console.WriteLine("You passed the class");                            
        }
        else
        {
            Console.WriteLine("Do better");
        }
        
        if (percentage >= 90)
        {
            Console.WriteLine("Grade: A");
        }
        else if (percentage >= 80)
        {
            Console.WriteLine("Grade: B");
        }
        else if (percentage >= 70)
        {
            Console.WriteLine("Grade: C");
        }
        else if (percentage >= 60)
        {
            Console.WriteLine("Grade: D");
        }
        else
        {
            Console.WriteLine("Grade: F");
        }
    }
}