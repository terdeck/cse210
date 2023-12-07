using System;

class Program
{
    static void Main(string[] args)
    {
        Video v1 = new();
        v1._vidTitle = "Getaway Car";
        v1._vidAuthor = "Taylor Swift";
        v1._vidLength = 233;

        Video v2 = new();
        v2._vidTitle = "invisible string";
        v2._vidAuthor = "Taylor Swift";
        v2._vidLength = 253;

        Video v3 = new();
        v3._vidTitle = "Wonderland";
        v3._vidAuthor = "Taylor Swift";
        v3._vidLength = 250;

        Comment c1 = new();  // 1
        c1._name = "Sarah5123";
        c1._text = "This is my jam forever and ever!";

        Comment c2 = new();  // 1
        c2._name = "Ash7123";
        c2._text = "this song just begs for a music video";

        Comment c3 = new();  // 1
        c3._name = "Cake53";
        c3._text = "This song never ever gets old. Even after 4 whole yrs.";

        Comment c4 = new();  // 2
        c4._name = "ProudMom";
        c4._text = "This was my daughter's wedding song and it was absolutely perfect";

        Comment c5 = new();  // 2
        c5._name = "SwiftieDude";
        c5._text = "This is a MASTERPIECE";

        Comment c6 = new();  // 2
        c6._name = "LZo000";
        c6._text = "This entire album is like reading a poem.";

        Comment c7 = new();  // 3
        c7._name = "CharChar22";
        c7._text = "I love wonderland it's my fav song on 1989";

        Comment c8 = new();  // 3
        c8._name = "Love11";
        c8._text = "I love how this version sounds soo full of life and happier. ";

        Comment c9 = new();  // 3
        c9._name = "yaya77";
        c9._text = "Love the whole album, and these videos are amazing!";


        v1._vidComments.Add(c1);
        v1._vidComments.Add(c2);
        v1._vidComments.Add(c3);

        v2._vidComments.Add(c4);
        v2._vidComments.Add(c5);
        v2._vidComments.Add(c6);

        v3._vidComments.Add(c7);
        v3._vidComments.Add(c8);
        v3._vidComments.Add(c9);

        Console.Clear();
        Console.WriteLine();
        v1.VidDetails();
        Console.WriteLine();
        v2.VidDetails();
        Console.WriteLine();
        v3.VidDetails();
        Console.WriteLine();
    }
}