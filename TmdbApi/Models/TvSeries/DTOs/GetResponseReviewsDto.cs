namespace TmdbApi.Models.TvSeries.DTOs;

public class GetResponseReviewsDto 
{
    public string? Author { get; set; }
    public Author? AuthorDetails { get; set; }
    public string? Content { get; set; }
    public DateTime? CreatedAt { get; set; }
    public string? Id { get; set; }
    public DateTime? UpdatedAt { get; set; }
    public string? Url { get; set; }
}

public class Author
{
    public string? Name { get; set; }
    public string? Username { get; set; }
    public string? AvatarPath { get; set; }
    public int? Rating { get; set; }
}