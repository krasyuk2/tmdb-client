using TmdbApi.Models.TvSeries.DTOs;

namespace TmdbApi.Models.TvSeries;

public class GetResponseTvSeriesTranslationsDto
{
    public int Id { get; set; }
    public GetResponseTranslationsDto[]? Translations { get; set; }
}