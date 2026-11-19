using TmdbApi.Models.TvSeries.DTOs;

namespace TmdbApi.Models.TvSeasons.DTOs;

public class GetResponseAccountStatesDto
{
    public int Id { get; set; }
    public int? EpisodeNumber { get; set; }
    public Rate? Rated { get; set; }
}