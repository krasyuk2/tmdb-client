using TmdbApi.Models.Common;

namespace TmdbApi.Models.TvSeasons;

public class TvSeasonWatchProviders
{
    public int Id { get; set; }
    public Dictionary<string, WatchProviderCountry>? Results { get; set; }
}
