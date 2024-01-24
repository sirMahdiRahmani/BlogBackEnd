namespace BlogBackEnd.Models;


public class User
{
    public int UserId { get; set; }
    public string? UserName { get; set; }
    public ICollection<Post> Posts { get; set; } = new List<Post>();
}

public class Post
{
    public int PostId { get; set; }
    public string? Title { get; set; }
    public string? Content { get; set; }
    public int UserId { get; set; }
    public User? User { get; set; }
    public ICollection<Comment> Comments { get; set; } = new List<Comment>();
    public ICollection<Tag> Tags { get; set; } = new List<Tag>();
    public Image? Image { get; set; }
}

public class Comment
{
    public int CommentId { get; set; }
    public string? Content { get; set; }
    public int PostId { get; set; }
    public Post? Post { get; set; }
}

public class Tag
{
    public int TagId { get; set; }
    public string? Name { get; set; }
    public ICollection<Post> Posts { get; set; } = new List<Post>();
}

public class Image
{
    public int ImageId { get; set; }
    public string? Url { get; set; }
    public int PostId { get; set; }
    public Post? Post { get; set; }
}