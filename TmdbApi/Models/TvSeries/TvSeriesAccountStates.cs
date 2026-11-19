using System.Text.Json;

namespace TmdbApi.Models.TvSeries;

public class TvSeriesAccountStates
{
    public int Id { get; set; }
    public bool? Favorite { get; set; }
    public JsonElement? Rated { get; set; }
    public bool? Watchlist { get; set; }
}
