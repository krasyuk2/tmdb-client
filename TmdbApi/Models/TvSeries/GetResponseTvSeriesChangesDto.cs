using TmdbApi.Models.TvSeries.DTOs;

namespace TmdbApi.Models.TvSeries;

public class GetResponseTvSeriesChangesDto
{
    public GetResponseChangesDto[]? Changes { get; set; }
}