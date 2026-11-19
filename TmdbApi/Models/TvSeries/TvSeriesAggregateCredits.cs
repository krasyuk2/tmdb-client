using TmdbApi.Models.Common;

namespace TmdbApi.Models.TvSeries;

/// <summary>
/// GET /3/tv/{series_id}/aggregate_credits — Aggregate Credits<br/>
/// </summary>
public class TvSeriesAggregateCredits
{
    public AggregateCast[]? Cast { get; set; }
    public AggregateCrew[]? Crew { get; set; }
    public int Id { get; set; }
}
