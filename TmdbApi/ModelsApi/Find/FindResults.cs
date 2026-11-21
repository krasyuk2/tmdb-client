using System.Text.Json;
using TmdbApi.Models.Common;

namespace TmdbApi.Models.Find;

public class FindResults
{
    public TrendingMovieItem[]? MovieResults { get; set; }
    public TrendingPersonItem[]? PersonResults { get; set; }
    public TrendingTvSeriesItem[]? TvResults { get; set; }
    public JsonElement[]? TvEpisodeResults { get; set; }
    public JsonElement[]? TvSeasonResults { get; set; }
}
