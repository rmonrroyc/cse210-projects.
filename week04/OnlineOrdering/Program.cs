using System;

class Program
{
    static void Main(string[] args)
    {
        // Customer 1 (USA)
        Address addr1 = new Address("123 Main St", "Springfield", "IL", "USA");
        Customer cust1 = new Customer("John Doe", addr1);
        Order order1 = new Order(cust1);
        order1.AddProduct(new Product("Widget", "W123", 10.0, 2));
        order1.AddProduct(new Product("Gadget", "G456", 15.5, 1));

        // Customer 2 (International)
        Address addr2 = new Address("456 Elm St", "Toronto", "ON", "Canada");
        Customer cust2 = new Customer("Jane Smith", addr2);
        Order order2 = new Order(cust2);
        order2.AddProduct(new Product("Thingamajig", "T789", 7.25, 3));
        order2.AddProduct(new Product("Doohickey", "D012", 12.0, 2));

        // Display results for both orders
        DisplayOrder(order1);
        Console.WriteLine("-------------------------");
        DisplayOrder(order2);
    }

    static void DisplayOrder(Order order)
    {
        Console.WriteLine("Packing Label:");
        Console.WriteLine(order.GetPackingLabel());
        Console.WriteLine("Shipping Label:");
        Console.WriteLine(order.GetShippingLabel());
        Console.WriteLine($"Total Price: ${order.GetTotalPrice():0.00}");
    }
}