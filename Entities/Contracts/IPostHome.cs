using Entities.Models;

namespace Entities.Contracts;

public interface IPostHome
{
    public Task<ICollection<Post>> GetAsync();
    public Task<Post> GetByIdAsync(int id);
    public Task<Post> AddAsync(Post post);
    public Task DeleteAsync(int id);
    public Task UpdateAsync(Post post);
}