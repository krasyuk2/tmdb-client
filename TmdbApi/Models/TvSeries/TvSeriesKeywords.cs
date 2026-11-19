using TmdbApi.Models.Common;

namespace TmdbApi.Models.TvSeries;

/// <summary>
/// GET /3/tv/{series_id}/keywords — Keywords<br/>
/// </summary>
public class TvSeriesKeywords
{
    public int Id { get; set; }
    public Keyword[]? Results { get; set; }
}
