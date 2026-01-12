using System;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        string input = Console.ReadLine();
        int answer = int.Parse(input);

        while(answer != 0)
        {
            numbers.Add(answer);
            Console.WriteLine("Enter Number: ");
            answer = int.Parse(Console.ReadLine());
        }
        int sum = 0;
        int count = 0;

        foreach (int i in numbers)
        {
            sum += i;
            count += 1;
        }
        float average = sum / count;
        int max = numbers.Max();
        Console.WriteLine($"Sum of list: {sum}");
        Console.WriteLine($"Average of list: {average}");
        Console.WriteLine($"The largest number is: {max}");
    }
}