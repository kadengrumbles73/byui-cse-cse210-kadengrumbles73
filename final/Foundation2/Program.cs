using System;

class Program
{
    static void Main(string[] args)
    {
        Address a1 = new Address("123 Winner St", "Rexburg", "ID", "USA");
        Customer c1 = new Customer("Kaden Grumbles", a1);
        Order o1 = new Order(c1);
        o1.AddProduct(new Product("Laptop", "A1", 250.00, 1));
        o1.AddProduct(new Product("Football", "B2", 15.00, 7));

        Address a2 = new Address("6767 Ice Rd", "Vancouver", "BC", "Canada");
        Customer c2 = new Customer("Meagan Grumbles", a2);
        Order o2 = new Order(c2);
        o2.AddProduct(new Product("Hockey Stick", "C3", 35.00, 2));
        o2.AddProduct(new Product("Skates", "D4", 80.50, 5 ));
        o2.AddProduct(new Product("Gum", "E5", 00.50, 32));

        List<Order> orders = new List<Order> { o1, o2 };
        foreach (var order in orders)
        {
            Console.WriteLine(order.ShippingLabel());
            Console.WriteLine(order.PackingLabel());
            Console.WriteLine($"Total Price: ${order.CalculateTotal():0.00}");
            Console.WriteLine("-----------------------------------");
        }
    }
}