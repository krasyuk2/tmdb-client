using TmdbApi.Models.TvSeries.DTOs;

namespace TmdbApi.Models.TvSeries;

public class GerResponseTvSeriesListsDto : ResponsePageDto<GetResponseListsDto>
{
    public int Id { get; set; }
}