namespace BlogBackEnd.Models;

public class Tag
{
    public int TagId { get; set; }
    public string? Name { get; set; }
    public ICollection<PostTag> Posts { get; set; } = new List<PostTag>();
}
