using System;
using System.Net;

class Program
{
    static void Main(string[] args)
    {
        Address add1 = new("828 Broadway", "New York", "NY", 10003);
        //strand bookshop

        Address add2 = new("1731 S Convention Center Dr", "St. George", "UT", 84790);
        // Hilton Inn 

        Address add3 = new("4399 YMCA Camp Rd", "Cleveland", "SC", 29635);
        //pretty place chapel

        Lecture lec1 = new(add1);
        lec1.SetTitle("Author Lecture");
        lec1.SetDescription("Come enjoy an intimate gathering to celebrate the printing of Gaiman and Pratchett's newest publication");
        lec1.SetDate("July 10, 1990");
        lec1.SetTime("8pm MT");
        lec1.SetLecture("Neil Gaiman and Terry Pratchett", 80);

        Console.WriteLine();
        Console.WriteLine(lec1.FullDetails());
        Console.WriteLine(lec1.ShortDescription());
        Console.WriteLine();

        Reception rec1 = new(add2);
        rec1.SetTitle("Wedding Reception");
        rec1.SetDescription("Celebrate the union of Matt & Britt");
        rec1.SetDate("Dec 12th, 2022");
        rec1.SetTime("4pm");
        rec1.SetReception("email@address.com");

        Console.WriteLine(rec1.FullDetails());
        Console.WriteLine(rec1.ShortDescription());
        Console.WriteLine();

        Outdoor out1 = new(add3);
        out1.SetTitle("Outdoor Sunrise Worship");
        out1.SetDescription("Join us amidst the beautiful fall foliage to raise our voices in praise");
        out1.SetDate("Oct. 28th, 2023");
        out1.SetTime("7am");
        out1.SetOutdoor("Sunny, with slight wind chill");

        Console.WriteLine(out1.FullDetails());
        Console.WriteLine(out1.ShortDescription());
        Console.WriteLine(); 
    }
}