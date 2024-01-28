namespace BlogBackEnd.Models;

public class Post
{
    public int PostId { get; set; }
    public string Title { get; set; }
    public string Content { get; set; }
    public Image? Image { get; set; }

    public int? UserId { get; set; }
    public User? User { get; set; }
    
    public ICollection<Comment>? Comments { get; set; } = new List<Comment>();
    public ICollection<PostTag>? PostTags { get; set; } = new List<PostTag>();
}