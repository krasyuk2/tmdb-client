using TmdbApi.Models.Common;

namespace TmdbApi.Models.TvSeries;

public class TvSeriesWatchProviders
{
    public int Id { get; set; }
    public Dictionary<string, WatchProviderCountry>? Results { get; set; }
}
