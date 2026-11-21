namespace TmdbApi.Models.Collections;

public class CollectionDetails
{
    public int Id { get; set; }
    public string? Name { get; set; }
    public string? Overview { get; set; }
    public string? PosterPath { get; set; }
    public string? BackdropPath { get; set; }
    public CollectionPart[]? Parts { get; set; }
}
