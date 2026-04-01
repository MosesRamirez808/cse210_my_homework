using System;

class Program
{
    static void Main(string[] args)
    {
        // Order 1: Local (Kihei, HI)
        Address addr1 = new Address("123 Wailea Alanui Dr", "Kihei", "HI", "USA");
        Customer cust1 = new Customer("Moe Ramirez", addr1);
        Order order1 = new Order(cust1);
        order1.AddProduct(new Product("Sourdough Starter Kit", "SD-01", 25.00m, 1));
        order1.AddProduct(new Product("Mushroom Coffee Blend", "MC-05", 15.50m, 2));

        // Order 2: International
        Address addr2 = new Address("456 Maple Leaf Way", "Toronto", "ON", "Canada");
        Customer cust2 = new Customer("Melissa Ramirez", addr2);
        Order order2 = new Order(cust2);
        order2.AddProduct(new Product("Mastiff Training Whistle", "DOG-99", 12.00m, 1));
        order2.AddProduct(new Product("Heavy Duty Dog Leash", "DOG-100", 20.00m, 1));

        // Display Order 1
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine($"Total Cost: ${order1.CalculateTotal()}\n");

        Console.WriteLine("-------------------------------------------\n");

        // Display Order 2
        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine($"Total Cost: ${order2.CalculateTotal()}\n");
    }
}