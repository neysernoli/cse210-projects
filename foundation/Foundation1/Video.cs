using System.Transactions;
using System.Collections.Generic;


public class Video
{
    public string Title {get; set;}
    public string Author {get; set;}
    public double Length {get; set;}

    public List<Comment> _comments = new List<Comment>();

    public Video(string titulo, string autor, double duracion)
    {
        Title = titulo;
        Author = autor;
        Length = duracion;
    }
    public void AddComment(Comment comment)
    {
        _comments.Add(comment);
    }

    public int GetNumberOfComments()
    {
        return _comments.Count;
    }
    
    public void display()
    {
        Console.WriteLine($"Title: {Title}");
        Console.WriteLine($"Autor: {Author}");
        Console.WriteLine($"Duracion: {Length} segundos.");
        Console.WriteLine($" {GetNumberOfComments()} Comentarios: ");

        foreach (var comment in _comments)
        {
            Console.WriteLine($"- {comment.Name}: {comment.Text}");
        }
    }    
}
