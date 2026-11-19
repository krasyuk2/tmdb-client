using TmdbApi.Models.TvSeasons.DTOs;

namespace TmdbApi.Models.TvSeasons;

public class GetResponseTvSeasonsAccountStatesDto
{
    public int Id { get; set; }
    public GetResponseAccountStatesDto[]? Results { get; set; }
}