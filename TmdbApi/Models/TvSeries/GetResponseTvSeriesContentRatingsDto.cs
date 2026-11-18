using TmdbApi.Models.TvSeries.DTOs;

namespace TmdbApi.Models.TvSeries;

public class GetResponseTvSeriesContentRatingsDto
{
    public GetResponseContentRatingsDto[]? Results { get; set; }
}