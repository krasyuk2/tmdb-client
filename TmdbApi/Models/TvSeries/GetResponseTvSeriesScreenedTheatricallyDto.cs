using TmdbApi.Models.TvSeries.DTOs;

namespace TmdbApi.Models.TvSeries;

public class GetResponseTvSeriesScreenedTheatricallyDto
{
    public int Id { get; set; }
    public GetResponseScreenedTheatricallyDto[]? Results { get; set; }
}