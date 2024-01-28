using Microsoft.EntityFrameworkCore;
using BlogBackEnd.Models;



namespace BlogBackEnd;

public class BlogDb : DbContext
{
    public DbSet<User> Users { get; set; }
    public DbSet<Post> Posts { get; set; }
    public DbSet<Comment> Comments { get; set; }
    public DbSet<Tag> Tags { get; set; }
    public DbSet<Image> Images { get; set; }
    public DbSet<PostTag> PostTags { get; set; }
    
    public BlogDb(DbContextOptions<BlogDb> options)
        : base(options) { }
    
    // protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    // {
    //     optionsBuilder.UseNpgsql("your_postgresql_connection_string");
    // }
}