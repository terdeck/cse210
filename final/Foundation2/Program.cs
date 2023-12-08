using System;

class Program
{
    static void Main(string[] args)
    {
        Address a1 = new("1112 Main St", "Middle Merica", "AB", "USA");
        // a1.GetAddress();

        Address a2 = new("2111 South St", "Paris", "Paris", "France");
        // a2.GetAddress();

        Customer c1 = new("Sandy Scranton", a1);
        c1.Region();

        Customer c2 = new("Pepe Le Pew", a2);
        c2.Region();
        
        // List <Product> p1 = new();

        // List <Product> p2 = new();

        Product p1 = new("Sandals", 44422, 14.99, 2);
        p1.ProductOrder();
        p1.ProductPrice();

        Product p2 = new("Hat", 22223, 12.99, 1);
        p2.ProductOrder();
        p2.ProductPrice();

        Product p3 = new("Necklace", 11984, 12.55, 1);
        p3.ProductOrder();
        p3.ProductPrice();

        Product p4 = new("Perfume", 22334, 15.68, 1);
        p4.ProductOrder();
        p4.ProductPrice();

        Product p5 = new("Flower Bouquet", 33221, 15.99, 1);
        p5.ProductOrder();
        p5.ProductPrice();

        Product p6 = new("Assorted Chocolates", 00221, 9.50, 1);
        p6.ProductOrder();
        p6.ProductPrice();
        
        Order o1 = new();
        o1.PackingLabel();
        o1.ShippingLabel();
        o1.PackingLabel(); // ???
        // public Order(double prices, Product product, Customer customer)
        // Order o2 = new();

        o1.PackingLabel();
        Console.WriteLine(o1.ShippingLabel());
        Console.WriteLine(o1.TotalCost());

        
    }
}