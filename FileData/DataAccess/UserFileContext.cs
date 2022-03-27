using Entities.Contracts;
using Entities.Models;
using System.Text.Json;

namespace FileData.DataAccess;

public class UserFileContext
{
    private string FilePath = "users.json";
    private ICollection<User>? users;
    
    public ICollection<User> Users
    {
        get
        {
            if (users == null)
            {
                LoadData();
            }

            return users!;
        }
    }

    public UserFileContext()
    {
        if (!File.Exists(FilePath))
        {
            Seed();
        }
    }


    private void Seed()
    {
        User[] ts = {
            new User("uname1", "pass") {
                
            },
            new User("uname2", "pass") {
                
            },
            new User("uname3", "pass") {
                
            },
        };
        users = ts.ToList();
        SaveChanges();
    }
    public void SaveChanges()
    {
        string serialize = JsonSerializer.Serialize(Users);
        File.WriteAllText(FilePath,serialize);
        users = null;
    }
    private void LoadData()
    {
        string content = File.ReadAllText(FilePath);
        users = JsonSerializer.Deserialize<List<User>>(content);
    }
}