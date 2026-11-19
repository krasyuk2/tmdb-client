using TmdbApi.Models.Common;

namespace TmdbApi.Models.TvEpisodes;

public class TvEpisodeVideos
{
    public int Id { get; set; }
    public Video[]? Results { get; set; }
}
