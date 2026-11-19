using TmdbApi.Models.Common;

namespace TmdbApi.Models.TvSeasons;

public class TvSeasonImages
{
    public int Id { get; set; }
    public Image[]? Posters { get; set; }
}
