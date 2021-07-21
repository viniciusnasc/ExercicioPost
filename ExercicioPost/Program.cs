using ExercicioPost.Entities;
using System;

namespace ExercicioPost
{
    class Program
    {
        static void Main(string[] args)
        {
            Coment c1 = new("Have a nice trip!");
            Coment c2 = new("Wow that's awesome!");
            Post p1 = new(DateTime.Parse("21/06/2018 13:04:044"),
                          "Traveling to New Zealand",
                          "I'm going to visit this wonderful country!",
                          12);
            p1.AddComent(c1);
            p1.AddComent(c2);

            Coment c3 = new("Good Night!");
            Coment c4 = new("May the force be with you!");
            Post p2 = new(DateTime.Parse("28/07/2018 23:14:19"),
                          "Good night guys!",
                          "See you tomorrow",
                          5);
            p2.AddComent(c3);
            p2.AddComent(c4);
        }
    }
}
