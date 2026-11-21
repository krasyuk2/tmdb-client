namespace TmdbApi.Models.TvEpisodeGroups;

public class EpisodeGroupItem
{
    public string? Id { get; set; }
    public string? Name { get; set; }
    public int? Order { get; set; }
    public EpisodeGroupEpisode[]? Episodes { get; set; }
    public bool? Locked { get; set; }
}
