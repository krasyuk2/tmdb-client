using TmdbApi.Models.TvSeries.DTOs;

namespace TmdbApi.Models.TvSeries;

public class GetResponseTvSeriesKeywordDto
{
    public int Id { get; set; }
    public GetResponseKeywordsDto[]? Results { get; set; }
}