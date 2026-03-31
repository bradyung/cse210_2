using System;

class Program
{
    static void Main(string[] args)
    {
        Address address1 = new Address("123 Main St", "Toronto", "Ontario", "Canada");
        Customer customer1 = new Customer("John Doe", address1);

        Order order1 = new Order(customer1);
        order1.AddProduct(new Product("Toilet Paper", "P100", 0.99, 10));
        order1.AddProduct(new Product("Paper Towels", "P101", 1.99, 5));
        order1.AddProduct(new Product("Hand Sanitizer", "P102", 3.99, 2));

        Address address2 = new Address("141 1st Ave", "Rexburg", "ID", "USA");
        Customer customer2 = new Customer("Skylar Wilde", address2);

        Order order2 = new Order(customer2);
        order2.AddProduct(new Product("Headphones", "P200", 29.99, 1));
        order2.AddProduct(new Product("Phone Case", "P201", 19.99, 2));
        order2.AddProduct(new Product("Phone Charger", "P202", 14.99, 1));

        Console.WriteLine("Order 1:");
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine($"Total Cost: ${order1.CalculateTotalCost():0.00}");

        Console.WriteLine();

        Console.WriteLine("Order 2:");
        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine($"Total Cost: ${order2.CalculateTotalCost():0.00}");


    }
}