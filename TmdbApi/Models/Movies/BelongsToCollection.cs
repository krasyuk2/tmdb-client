namespace TmdbApi.Models.Movies;

public class BelongsToCollection
{
    public int Id { get; set; }
    public string? Name { get; set; }
    public string? PosterPath { get; set; }
    public string? BackdropPath { get; set; }
}
