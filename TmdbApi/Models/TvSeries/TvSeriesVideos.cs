using TmdbApi.Models.Common;

namespace TmdbApi.Models.TvSeries;

/// <summary>
/// GET /3/tv/{series_id}/videos — Videos<br/>
/// </summary>
public class TvSeriesVideos
{
    public int Id { get; set; }
    public Video[]? Results { get; set; }
}
