using TmdbApi.Models.Common;

namespace TmdbApi.Models.TvSeries;

public class TvSeriesAlternativeTitles
{
    public int Id { get; set; }
    public AlternativeTitle[]? Results { get; set; }
}
