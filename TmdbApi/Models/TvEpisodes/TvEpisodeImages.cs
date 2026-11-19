using TmdbApi.Models.Common;

namespace TmdbApi.Models.TvEpisodes;

public class TvEpisodeImages
{
    public int Id { get; set; }
    public Image[]? Stills { get; set; }
}
