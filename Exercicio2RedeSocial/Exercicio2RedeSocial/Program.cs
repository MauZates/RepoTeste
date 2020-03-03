using System;
using Exercicio2RedeSocial.Entities;

namespace Exercicio2RedeSocial
{
    class Program
    {
        static void Main(string[] args)
        {
            Comment c1 = new Comment("Have a nice trip!");
            Comment c2 = new Comment("Whow that's awesome!");

            Post p1 = new Post(
                DateTime.Parse("21/06/2018 13:05:44"),
                "Traveling to New Zeland",
                "I'm going to visit this wonderful country!",
                12
                );

            p1.AddComent(c1);
            p1.AddComent(c2);

            Comment c3 = new Comment("Have a nice trip!");
            Comment c4 = new Comment("Whow that's awesome!");

            Post p2 = new Post(
                DateTime.Parse("28/07/2018 23:14:19"),
                "Good night guys",
                "See you tomorrow",
                5
                );

            p2.AddComent(c3);
            p2.AddComent(c4);

            Console.WriteLine(p1);
            Console.WriteLine(p2);
        }
    }
}
