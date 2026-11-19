using TmdbApi.Models.Common;

namespace TmdbApi.Models.TvSeasons;

public class TvSeasonVideos
{
    public int Id { get; set; }
    public Video[]? Results { get; set; }
}
