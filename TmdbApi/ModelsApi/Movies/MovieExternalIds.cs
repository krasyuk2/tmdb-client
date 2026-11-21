namespace TmdbApi.Models.Movies;

public class MovieExternalIds
{
    public int Id { get; set; }
    public string? ImdbId { get; set; }
    public string? WikidataId { get; set; }
    public string? FacebookId { get; set; }
    public string? InstagramId { get; set; }
    public string? TwitterId { get; set; }
}
