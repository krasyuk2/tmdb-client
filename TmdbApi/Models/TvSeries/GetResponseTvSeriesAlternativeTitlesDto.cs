using TmdbApi.Models.TvSeries.DTOs;

namespace TmdbApi.Models.TvSeries;

public class GetResponseTvSeriesAlternativeTitlesDto
{
    public int Id { get; set; }
    public GetResponseAlternativeTitlesDto[]? Results { get; set; }
}