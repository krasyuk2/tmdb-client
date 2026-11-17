using TmdbApi.Models.TvSeries.DTOs;

namespace TmdbApi.Models.TvSeries;

public class GerResponseTvSeriesAggregateCreditsDto
{
    public GetResponseAggregateCreditsDto[]? Cast { get; set; }
    public int Id { get; set; }
}