using TmdbApi.Models.TvSeries.DTOs;

namespace TmdbApi.Models.TvSeries;

public class GetResponseTvSeriesReviewsDto : ResponsePageDto<GetResponseRecommendationsDto>
{
    public int Id { get; set; }
}