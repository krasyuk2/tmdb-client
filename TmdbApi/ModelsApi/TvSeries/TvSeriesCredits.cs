using TmdbApi.Models.Common;

namespace TmdbApi.Models.TvSeries;

public class TvSeriesCredits
{
    public Cast[]? Cast { get; set; }
    public Crew[]? Crew { get; set; }
    public int Id { get; set; }
}
