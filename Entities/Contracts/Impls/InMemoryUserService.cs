using Entities.Models;

namespace Entities.Contracts.Impls;

public class InMemoryUserService : IUserService
{
    public async Task<User?> GetUserAsync(string username)
    {
        User? find = users.Find(user => user.UserName.Equals(username));
        return find;
    }

    public Task<User> AddAsync(User post)
    {
        throw new NotImplementedException();
    }

    public Task DeleteAsync(int id)
    {
        throw new NotImplementedException();
    }

    public Task UpdateAsync(User post)
    {
        throw new NotImplementedException();
    }

    private List<User> users = new()
    {
        new User("User1", "password"),
        new User("User2", "password"),
        new User("User3", "password")        
    };
    //not the best passwords, i know
}