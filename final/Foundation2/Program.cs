using System;

class Program
{
    static void Main(string[] args)
    {
        Address add1 = new("1112 Main St", "Middle Merica", "AB", "USA");

        Address add2 = new("2111 South St", "Paris", "Paris", "France");

        Customer cust1 = new("Sandy Scranton", add1);

        Customer cust2 = new("Pepe Le Pew", add2);

        List <Product> prod1 = new();
        List <Product> prod2 = new();

        Product p1 = new();
        p1.SetProdName("Sandals");
        p1.SetProdID(44422);
        p1.SetProdPrice(14.99);
        p1.SetProdQuantity(2);
        p1.ProductOrder();
        p1.ProductPrice();

        Product p2 = new();
        p1.SetProdName("Hat");
        p1.SetProdID(22223);
        p1.SetProdPrice(12.9);
        p1.SetProdQuantity(1);
        p2.ProductOrder();
        p2.ProductPrice();

        Product p3 = new();
        p1.SetProdName("Necklace");
        p1.SetProdID(11984);
        p1.SetProdPrice(12.55);
        p1.SetProdQuantity(1);
        p3.ProductOrder();
        p3.ProductPrice();

        Product p4 = new();
        p1.SetProdName("Perfume");
        p1.SetProdID(22334);
        p1.SetProdPrice(15.68);
        p1.SetProdQuantity(1);
        p4.ProductOrder();
        p4.ProductPrice();

        Product p5 = new();
        p1.SetProdName("Flower Bouquet");
        p1.SetProdID(33221);
        p1.SetProdPrice(15.99);
        p1.SetProdQuantity(1);
        p5.ProductOrder();
        p5.ProductPrice();

        Product p6 = new();
        p1.SetProdName("Assorted Chocolates");
        p1.SetProdID(00221);
        p1.SetProdPrice(9.50);
        p1.SetProdQuantity(1);
        p6.ProductOrder();
        p6.ProductPrice();

        prod1.Add(p1);
        prod1.Add(p2);
        prod1.Add(p3);

        prod2.Add(p4);
        prod2.Add(p5);
        prod2.Add(p6);
        
        Order o1 = new(cust1);
        o1.PackingLabel();
        o1.ShippingLabel();
        o1.TotalCost(); 

        foreach (Product p1 in prod1)
        {
            
            
            Console.WriteLine(o1.TotalCost());
            Console.WriteLine(o1.ShippingLabel());
            Console.WriteLine(o1.TotalCost());
        }


        Order o2 = new(cust2);
        o2.PackingLabel();
        o2.ShippingLabel();
        o2.TotalCost(); 

        Console.WriteLine(o1.TotalCost());
        Console.WriteLine(o1.ShippingLabel());
        Console.WriteLine(o1.TotalCost());
    }
}