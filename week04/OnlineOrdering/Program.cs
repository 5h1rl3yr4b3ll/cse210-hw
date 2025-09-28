using System;

class Program
{
    static void Main(string[] args)
    {
        // ORDER 1: USA Customer

        Console.WriteLine("           ORDER 1: USA CUSTOMER");
        Console.WriteLine("========================================");

        //Create Address and Customer
        Address address1 = new Address("123 Main St", "Salt Lake City", "UT", "USA");
        Customer customer1 = new Customer("John Smith", address1);

        //Create Products
        Product productA = new Product("Laptop Charger", 1001, 15.50f, 2); // Cost: $31.00
        Product productB = new Product("Wireless Mouse", 1002, 25.00f, 1);  // Cost: $25.00

        //Create Order and add products
        Order order1 = new Order(customer1);
        order1.AddProducts(productA);
        order1.AddProducts(productB);

        //Display results
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine("\n" + order1.ShippingLabel());

        //Total Order
        Console.WriteLine($"\nOrder Total Price (with $5.00 shipping): ${order1.TotalPrice():0.00}");
        
        // ORDER 2: International Customer
        Console.WriteLine("\n       ORDER 2: INTERNATIONAL CUSTOMER");
        Console.WriteLine("========================================");

        //Create Address and Customer
        Address address2 = new Address("45 P. de la Reforma", "Mexico City", "CDMX", "Mexico");
        Customer customer2 = new Customer("Maria Garcia", address2);

        //Create Products
        Product productC = new Product("Webcam HD", 2005, 50.00f, 1);    // Cost: $50.00
        Product productD = new Product("Gaming Headset", 2006, 40.00f, 3); // Cost: $120.00

        //Create Order and add products
        Order order2 = new Order(customer2);
        order2.AddProducts(productC);
        order2.AddProducts(productD);

        //Display results
        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine("\n" + order2.ShippingLabel());

        //Total order
        Console.WriteLine($"\nOrder Total Price (with $35.00 shipping): ${order2.TotalPrice():0.00}");

    }
}