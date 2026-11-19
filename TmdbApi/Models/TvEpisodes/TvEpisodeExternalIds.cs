namespace TmdbApi.Models.TvEpisodes;

public class TvEpisodeExternalIds
{
    public int Id { get; set; }
    public string? ImdbId { get; set; }
    public string? FreebaseMid { get; set; }
    public string? FreebaseId { get; set; }
    public int? TvdbId { get; set; }
    public int? TvrageId { get; set; }
    public string? WikidataId { get; set; }
}
