using TmdbApi.Models.Common;

namespace TmdbApi.Models.Movies;

public class MovieWatchProviders
{
    public int Id { get; set; }
    public Dictionary<string, WatchProviderCountry>? Results { get; set; }
}
