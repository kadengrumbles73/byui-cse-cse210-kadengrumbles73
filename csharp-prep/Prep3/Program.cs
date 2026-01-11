using System;

class Program
{
    static void Main(string[] args)
    {
        Random random = new Random();

        int num = random.Next(1, 101);

        int guess = -1;
        
        int count = 0;

        while(guess != num)
        {
            Console.WriteLine("What is your Guess? ");
            guess = int.Parse(Console.ReadLine());
            if(guess > num)
            {
                Console.WriteLine("Lower");
                count++;
                Console.WriteLine($"Guess count: {count}");
            }
            else if(guess < num)
            {
                Console.WriteLine("Higher");
                count++;
                Console.WriteLine($"Guess count: {count}");
            }
            else  
            {
                Console.WriteLine("You guessed it!");
                count++;
                Console.WriteLine($"Guess count: {count}");
            }
        }
    }
}