using System.Collections;
using Entities.Contracts;
using Entities.Models;
using System.Text.Json;
//using Newtonsoft.Json;
//using JsonSerializer = System.Text.Json.JsonSerializer;

namespace FileData.DataAccess;

public class PostFileContext
{
    
    private string _filePath = "postList.json";
    private ICollection<Post>? _posts;
    
    public ICollection<Post> Posts
    {
        get
        {
            if (_posts == null)
            {
                LoadData();
            }

            return _posts!;
        }
    }

    public PostFileContext()
    {
        if (!File.Exists(_filePath))
        {
            Seed();
        }
    }


    private void Seed()
    {
        // User user = new User("name", "pass");
        // Vote vote = new Vote(1, user);
        // List<Vote> votes = new List<Vote> {vote};
        // Comment comment = new Comment(user, "some comment", votes);
        // List<Comment> comments = new List<Comment> {comment};

        Post[] ts = {
            new Post("Post1", "some") {
                Id = 1,
                // Votes = votes,
                // Comments = comments
            },
            new Post("Post2", "body") {
                Id = 2,
                // Votes = votes,
                // Comments = comments
            },
            new Post("Post3", "once told me") {
                Id = 3,
                // Votes = votes,
                // Comments = comments
            },
        };
        _posts = ts.ToList();
        SaveChanges();
    }
    public void SaveChanges()
    {
        string serialize = JsonSerializer.Serialize(Posts);
        File.WriteAllText(_filePath,serialize);
        _posts = null;
    }
    private void LoadData()
    {
        string content = File.ReadAllText(_filePath);
        _posts = JsonSerializer.Deserialize<List<Post>>(content);
        //_posts = JsonConvert.DeserializeObject<List<Post>>(content);
    }
}