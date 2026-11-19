using System.Text.Json;

namespace TmdbApi.Models.Movies;

public class MovieAccountStates
{
    public int Id { get; set; }
    public bool? Favorite { get; set; }
    public JsonElement? Rated { get; set; }
    public bool? Watchlist { get; set; }
}
