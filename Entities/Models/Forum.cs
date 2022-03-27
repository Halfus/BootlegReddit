namespace Entities.Models;

public interface Forum
{
    ICollection<Post> posts();
    ICollection<User> users();
}