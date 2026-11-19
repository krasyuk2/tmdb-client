using System.Text.Json;

namespace TmdbApi.Models.TvSeasons;

public class EpisodeAccountStates
{
    public int Id { get; set; }
    public int? EpisodeNumber { get; set; }
    public JsonElement? Rated { get; set; }
}
