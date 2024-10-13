using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Video v1 = new Video("Apremde C#", "Bryan Brains", 500);
        Video v2 = new Video("Curso de JavaScript", "Jhon Reed", 750 );
        Video v3 = new Video("Come and learn program", "Alejandra Smith", 800);

        v1.AddComment(new Comment("Marcus","Thank you to share your knowledge"));
        v1.AddComment(new Comment("Jose", "Great course!!!"));
        v1.AddComment(new Comment("Heyli", " Could you explain about encapsulation?"));

        v2.AddComment(new Comment("Saul", "God Job"));
        v2.AddComment(new Comment("Leonardo", "I love it "));
        v2.AddComment(new Comment("Saul", "You could explain better"));

        v3.AddComment(new Comment("Daniel", "Very clear explanations"));
        v3.AddComment(new Comment("Enzo", "Good way to start!"));
        v3.AddComment(new Comment("Jose", "Amazing!"));


        List<Video> videos = new List<Video>{v1, v2, v3};

        foreach (var video in videos)
        {
            video.display();
            
        }
        







    }
}