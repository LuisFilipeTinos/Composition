using Composição.Entities;
using System;

namespace Composição
{
    class Program
    {
        static void Main(string[] args)
        {
            Post p1 = new Post(DateTime.Parse("21/06/2018 13:05:44"),
                "Traveling to New Zealand", "I´m going to visit this wonderfull country!", 12);

            Comment comment1 = new Comment("Have a nice trip!");
            Comment comment2 = new Comment("Wow that´s awesome!");

            p1.AddComment(comment1);
            p1.AddComment(comment2);

            Post p2 = new Post(DateTime.Parse("28/07/2018 23:14:19"), "Good night guys",
                "See you tomorrow", 5);

            Comment comment3 = new Comment("Good night");
            Comment comment4 = new Comment("May the force be with you");

            p2.AddComment(comment3);
            p2.AddComment(comment4);

            Console.WriteLine(p1);
            Console.WriteLine(p2);
        }
    }
}
