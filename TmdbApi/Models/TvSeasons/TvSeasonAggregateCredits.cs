using TmdbApi.Models.Common;

namespace TmdbApi.Models.TvSeasons;

public class TvSeasonAggregateCredits
{
    public AggregateCast[]? Cast { get; set; }
    public AggregateCrew[]? Crew { get; set; }
    public int Id { get; set; }
}
