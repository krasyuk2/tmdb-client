using TmdbApi.Models.TvSeasons.DTOs;

namespace TmdbApi.Models.TvSeasons;

public class GetResponseTvSeasonsAggregateCreditsDto
{
    public GetResponseAggregateCreditsDto[]? Cast {get; set;}
    public int Id {get; set;}
}