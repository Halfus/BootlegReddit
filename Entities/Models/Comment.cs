namespace Entities.Models;

public class Comment
{
    public Comment(User user, string body, ICollection<Vote>? votes)
    {
        WrittenBy = user;
        Body = body;
        Votes = votes;
    }

    public Comment(User user, string body)
    {
        WrittenBy = user;
        Body = body;
    }

    public string Body { get; set; }
    public ICollection<Vote>? Votes { get; set; }
    public User WrittenBy { get; set; }
    

}