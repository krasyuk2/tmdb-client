using TmdbApi.Models.TvSeries.DTOs;

namespace TmdbApi.Models.TvSeries;

public class GetResponseTvSeriesWatchProvidersDto
{
    public int Id { get; set; }
    public GetResponseWatchProvidersDto[]? Results { get; set; }
}