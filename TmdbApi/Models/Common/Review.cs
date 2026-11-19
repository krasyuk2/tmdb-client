namespace TmdbApi.Models.Common;

public class Review
{
    public string? Author { get; set; }
    public AuthorDetails? AuthorDetails { get; set; }
    public string? Content { get; set; }
    public string? CreatedAt { get; set; }
    public string? Id { get; set; }
    public string? UpdatedAt { get; set; }
    public string? Url { get; set; }
}
