using System;
using System.Data.SqlTypes;

class Program
{
    static void Main(string[] args)
    {
        Address address1 = new Address("1234 W South Temple", "Salt Lake City", "UT", "USA");
        Address address2 = new Address("Las Americas 222", "Chiclayo", "Lambayeque", "PERU");

        Customer customer1 = new Customer("Dallin Suman", address1);
        Customer customer2 = new Customer("Renato Sanchez", address2);

        Product product1 = new Product("Laptop", "P001", 800.00, 1);
        Product product2 = new Product("mouse", "P002", 50, 1);
        Product product3 = new Product("Charger","P003", 15, 1);
        Product product4 = new Product("Audifonos", "P004", 25, 1);

        Order order1= new Order(new List<Product> {product1, product2},customer1);
        Order order2= new Order(new List<Product>{product3, product4}, customer2);

        DisplayOrderDetails(order1);

        DisplayOrderDetails(order2);
    }

    public static void DisplayOrderDetails(Order order)
    {
        Console.WriteLine("Order Details:");

        string packingLabel = order.GetPackingLabel();
        Console.WriteLine(packingLabel);

        String shippingLabel1 = order.GetShippingLabel();
        Console.WriteLine(shippingLabel1);

        double totalCost = order.CalculateTotal();
        Console.WriteLine($"Total Cost: ${totalCost}");


    }
}