using System;

class Program
{
    static void Main(string[] args)
    {
        Video v1 = new Video("How to Shoot a Basketball", "Shot Mechanics", 720);
        Video v2 = new Video("Top 10 Movies of All Time", "Screenrant", 1350);
        Video v3 = new Video("1 Hour of Study Music", "Lofi Tunez", 3600);

        v1.AddComment(new Comment("StephCurry30", "Thanks for the tips! Lets go win the finals!"));
        v1.AddComment(new Comment("MJ23", "Easy Money!!"));
        v1.AddComment(new Comment("Wemby1", "Lets 1v1 in Paris"));

        v2.AddComment(new Comment("TVlover67", "I agree with this."));
        v2.AddComment(new Comment("RandomDude11", "Bruh the does not make sense!!!")); 
        v2.AddComment(new Comment("CaptianAmerica237", "I love the Avengers!"));

        v3.AddComment(new Comment("CSstudent42", "This helps with the 50 hours of final projects i have to do."));
        v3.AddComment(new Comment("Musicrocks96", "Music to my ears!"));
        v3.AddComment(new Comment("Randomguy372", "Can you make this video 24 hours long?"));

        List<Video> videoList = new List<Video> { v1, v2, v3 };

        foreach (Video v in videoList)
        {
            v.DisplayVideoDetails();
        }
    }
}