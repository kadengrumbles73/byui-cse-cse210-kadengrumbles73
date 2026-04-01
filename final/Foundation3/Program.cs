using System;

class Program
{
    static void Main(string[] args)
    {
        Address addr1 = new Address("123 BYU Ln", "Rexburg", "ID", "USA");
        Address addr2 = new Address("456 Temple Ave", "Orem", "UT", "USA");
        Address addr3 = new Address("789 Beach Blvd", "Orlando", "FL", "USA");

        Lecture lecture = new Lecture("Tech Talk", "AI in 2026", new DateTime(2026, 10, 21, 14, 0, 0), addr1, "Brother Gibbons", 100);
        Reception reception = new Reception("Kaden and Meagan Wedding", "We getting sealed", new DateTime(2027, 1, 2, 10, 30, 0), addr2, "kaden.grumbles@gmail.com");
        Outdoor outdoor = new Outdoor("Space Launch", "Artemis 2 Launch", new DateTime(2026, 4, 1, 4, 20, 0), addr3, "Sunny");
    
        List<Event> eventList = new List<Event> { lecture, reception, outdoor };

foreach (Event ev in eventList)
{
    Console.WriteLine("----------------------------------");
    Console.WriteLine("\nFULL DESCRIPTION:");
    Console.WriteLine(ev.FullDesc());
    
    Console.WriteLine("\nSHORT DESCRIPTION:");
    Console.WriteLine(ev.ShortDesc());
    Console.WriteLine("----------------------------------\n");
}
    }
}