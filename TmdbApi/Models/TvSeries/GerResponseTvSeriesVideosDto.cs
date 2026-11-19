using TmdbApi.Models.TvSeries.DTOs;

namespace TmdbApi.Models.TvSeries;

public class GerResponseTvSeriesVideosDto
{
    public int  Id { get; set; }
    public GetResponseVideosDto[]? Results { get; set; }
}