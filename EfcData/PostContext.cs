using Entities.Models;
using Microsoft.EntityFrameworkCore;

namespace EfcData;

public class PostContext : DbContext
{
    public DbSet<Post> Posts { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite("Data Source = Post.db");
    }
    
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Post>().HasKey(post => post.Id);
    }
    
    public void Seed()
    {
        if (Posts.Any()) return;

        Post[] ts =
        {
            new Post("Title1", "some body"),
            new Post("Title2", "some body"),
            new Post("Title3", "some body"),
        };
        Posts.AddRange(ts);
        SaveChanges();
    }
}