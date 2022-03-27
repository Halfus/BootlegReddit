using System.Collections.Generic;
using System.Threading.Tasks;
using Entities.Models;

namespace Entities.Contracts;

//Class given by assignment (renamed from "ForumContainer")
public interface IUserService
{
    //public Task<ICollection<User>> GetAsync();
    //public Task<User> GetByUsername(string userName);
    public Task<User> GetUserAsync(string username);
    public Task<User> AddAsync(User post);
    public Task DeleteAsync(int id);
    public Task UpdateAsync(User post);
}