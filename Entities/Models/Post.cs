using System.ComponentModel.DataAnnotations;

namespace Entities.Models;

public class Post
{
    public Post(string title, string body)
    {
        Title = title;
        Body = body;
    }

    public string Title { get; set; }
    [Key]
    public int Id { get; set; }
    
    [Required]
    public string Body { get; set; }
    
    // public List<Vote> Votes { get; set; }
    // public List<Comment> Comments { get; set; }

    public Post()
    {
    }
}