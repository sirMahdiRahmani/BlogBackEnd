using Microsoft.AspNetCore.Identity;

namespace BlogBackEnd.Models;

public class User : IdentityUser
{
    // You can add custom properties here if needed
}

public class Post
{
    public int PostId { get; set; }
    public string Title { get; set; }
    public string Content { get; set; }
    public Image Image { get; set; }

    public string UserId { get; set; }
    public User User { get; set; }

    public ICollection<Comment> Comments { get; set; } = new List<Comment>();
    public ICollection<PostTag> PostTags { get; set; }
}

public class Comment
{
    public int CommentId { get; set; }
    public string? Content { get; set; }
    public DateTime CreatedAt { get; set; }
    
    public int UserId { get; set; }
    public User User { get; set; }
    
    public int PostId { get; set; }
    public Post Post { get; set; }
}

public class Tag
{
    public int TagId { get; set; }
    public string? Name { get; set; }
    public ICollection<PostTag> Posts { get; set; }
}

public class PostTag
{
    public int PostId { get; set; }
    public Post Post { get; set; }
    
    public int TagId { get; set; }
    public Tag Tag { get; set; }
}

public class Image
{
    public int ImageId { get; set; }
    public string Url { get; set; }
    
    public int PostId { get; set; }
    public Post? Post { get; set; }
}