using System;

class Program
{
    static void Main(string[] args)
    {
        // First Order (USA customer)
        Address address1 = new Address("123 Main St", "New York", "NY", "USA");
        Customer customer1 = new Customer("John Smith", address1);

        Order order1 = new Order(customer1);
        order1.AddProduct(new Product("Laptop", "P001", 999.99, 1));
        order1.AddProduct(new Product("Mouse", "P002", 19.99, 2));

        // Second Order (Non-USA customer)
        Address address2 = new Address("456 Queen St", "Toronto", "ON", "Canada");
        Customer customer2 = new Customer("Alice Brown", address2);

        Order order2 = new Order(customer2);
        order2.AddProduct(new Product("Phone", "P003", 799.99, 1));
        order2.AddProduct(new Product("Charger", "P004", 29.99, 1));
        order2.AddProduct(new Product("Case", "P005", 15.99, 2));

        // Display first order
        Console.WriteLine("----- Order 1 -----");
        Console.WriteLine("Packing Label:\n" + order1.GetPackingLabel());
        Console.WriteLine("Shipping Label:\n" + order1.GetShippingLabel());
        Console.WriteLine($"Total Cost: ${order1.GetTotalCost():0.00}\n");

        // Display second order
        Console.WriteLine("----- Order 2 -----");
        Console.WriteLine("Packing Label:\n" + order2.GetPackingLabel());
        Console.WriteLine("Shipping Label:\n" + order2.GetShippingLabel());
        Console.WriteLine($"Total Cost: ${order2.GetTotalCost():0.00}");
    }
}
