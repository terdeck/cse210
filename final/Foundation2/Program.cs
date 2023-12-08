using System;

class Program
{
    static void Main(string[] args)
    {
        Address add1 = new("1112 Main St", "Middle Merica", "AB", "USA");

        Address add2 = new("2111 South St", "Paris", "Paris", "France");

        Customer cust1 = new("Sandy Scranton", add1);

        Customer cust2 = new("Pepe Le Pew", add2);

        // List <Product> prod1 = new();
        // List <Product> prod2 = new();

        Product p1 = new();
        p1.SetProdName("Sandals");
        p1.SetProdID(44422);
        p1.SetProdPrice(15.68);
        p1.SetProdQuantity(2);
        p1.ProductOrder();
        p1.ProductPrice();

        Product p2 = new();
        p2.SetProdName("Hat");
        p2.SetProdID(22223);
        p2.SetProdPrice(15.99);
        p2.SetProdQuantity(1);
        p2.ProductOrder();
        p2.ProductPrice();

        Product p3 = new();
        p3.SetProdName("Necklace");
        p3.SetProdID(11984);
        p3.SetProdPrice(9.50);
        p3.SetProdQuantity(1);
        p3.ProductOrder();
        p3.ProductPrice();

        Product p4 = new();
        p4.SetProdName("Perfume");
        p4.SetProdID(22334);
        p4.SetProdPrice(15.68);
        p4.SetProdQuantity(1);
        p4.ProductOrder();
        p4.ProductPrice();

        Product p5 = new();
        p5.SetProdName("Flower Bouquet");
        p5.SetProdID(33221);
        p5.SetProdPrice(15.99);
        p5.SetProdQuantity(1);
        p5.ProductOrder();
        p5.ProductPrice();

        Product p6 = new();
        p6.SetProdName("Assorted Chocolates");
        p6.SetProdID(00221);
        p6.SetProdPrice(9.50);
        p6.SetProdQuantity(1);
        p6.ProductOrder();
        p6.ProductPrice();
        
        Order o1 = new(cust1);
        o1.AddProduct(p1);
        o1.AddProduct(p2);
        o1.AddProduct(p3);

        Console.WriteLine();
        Console.WriteLine($"   Order Details:   ");
        Console.WriteLine();
        Console.WriteLine($"Packing Label: \n{o1.PackingLabel()}");
        Console.WriteLine($"Shipping Label: \n{o1.ShippingLabel()}");
        Console.WriteLine();
        Console.WriteLine($"Total Price: ${o1.TotalCost()}");

        Order o2 = new(cust2);
        o2.AddProduct(p4);
        o2.AddProduct(p5);
        o2.AddProduct(p6);

        Console.WriteLine("\n");
        Console.WriteLine($"   Order Details:   ");
        Console.WriteLine();
        Console.WriteLine($"Packing Label: \n{o2.PackingLabel()}");
        Console.WriteLine($"Shipping Label: \n{o2.ShippingLabel()}");
        Console.WriteLine();
        Console.WriteLine($"Total Price: ${o2.TotalCost()}");
    }
}