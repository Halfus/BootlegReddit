using Entities.Contracts;
using Entities.Models;

namespace FileData.DataAccess;

public class PostFileDAO : IPostHome
{
    private PostFileContext _fileContext;

    public PostFileDAO(PostFileContext fileContext)
    {
        _fileContext = fileContext;
    }
    
    public ICollection<User> Users { get; set; }
    
    public async Task<ICollection<Post>> GetAsync()
    {
        ICollection<Post> posts = _fileContext.Posts;
        return posts;
    }

    public async Task<Post> GetByIdAsync(int id)
    {
        return _fileContext.Posts.First(t => t.Id == id);
    }

    public async Task<Post> AddAsync(Post post)
    {
        int largestId = _fileContext.Posts.Max(t => t.Id);
        int nextId = largestId + 1;
        post.Id = nextId;
        _fileContext.Posts.Add(post);
        _fileContext.SaveChanges();
        return post;
    }

    public async Task DeleteAsync(int id)
    {
        Post toDelete = _fileContext.Posts.First(t => t.Id == id);
        _fileContext.Posts.Remove(toDelete);
        _fileContext.SaveChanges();
    }

    public async Task UpdateAsync(Post post)
    {
        Post toUpdate = _fileContext.Posts.First(t => t.Id == post.Id);
        toUpdate.Title = post.Title;
        toUpdate.Body = post.Body;
        _fileContext.SaveChanges();
    }
}