using Entities.Contracts;
using Entities.Models;

namespace FileData.DataAccess;

public class UserFileDAO : IUserService
{
    private UserFileContext _fileContext;
    
    public UserFileDAO(UserFileContext fileContext)
    {
        this._fileContext = fileContext;
    }
    
    public ICollection<User>? Users { get; set; }

    // public async Task<ICollection<User>> GetAsync()
    // {
    //     ICollection<User> users = _fileContext.Users;
    //     return users;
    // }

    // public async Task<User> GetByUsername(string userName)
    // {
    //     return _fileContext.Users.First(t => t.UserName == userName);
    // }

    public Task<User> GetUserAsync(string username)
    {
        throw new NotImplementedException();
    }

    public async Task<User> AddAsync(User user)
    {
        throw new NotImplementedException();
    }

    public async Task DeleteAsync(int id)
    {
        throw new NotImplementedException();
    }

    public async Task UpdateAsync(User user)
    {
        throw new NotImplementedException();
    }
}