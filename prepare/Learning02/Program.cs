using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning02 World!");

        Job job1 = new Job();
        job1._jobTitle = "Lifeguard";
        job1._company = "City of Bellingham";
        job1._startYear = 2021;
        job1._endYear = 2025;

        Job job2 = new Job();
        job2._jobTitle = "Paraeducator";
        job2._company = "Ferndale School District";
        job2._startYear = 2024;
        job2._endYear = 2025;
        
        Resume resume1 = new Resume();


        resume1._name = "Kaden Grumbles";

        resume1._jobs.Add(job1);
        resume1._jobs.Add(job2);

        resume1.Display();
    }
}