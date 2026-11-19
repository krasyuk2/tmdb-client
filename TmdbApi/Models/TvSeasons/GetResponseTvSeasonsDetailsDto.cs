using System.Text.Json.Serialization;
using TmdbApi.Models.TvSeasons.DTOs;
using TmdbApi.Models.TvSeries.DTOs;
using GetResponseDetailsDto = TmdbApi.Models.TvSeasons.DTOs.GetResponseDetailsDto;

namespace TmdbApi.Models.TvSeasons;

public class GetResponseTvSeasonsDetailsDto
{
    [JsonPropertyName("_id")]
    public string? _id { get; set; }
    public DateTime AirDate { get; set; }
    public GetResponseDetailsDto[]? Episodes { get; set; }
    public string? Name { get; set; }
    public Network[]? Networks { get; set; }
    public string? Overview { get; set; }
    public int Id { get; set; }
    public string? PosterPath { get; set; }
    public int? SeasonNumber { get; set; }
    public double? VoteAverage { get; set; }
}