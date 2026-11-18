using System.Text.Json.Serialization;

namespace TmdbApi.Models.TvSeries.DTOs;

public class GetResponseAlternativeTitlesDto
{
    [JsonPropertyName("iso_3166_1")]
    public string? ISO_3166_1 { get; set; }
    
    public string? Title { get; set; }
    public string? Type { get; set; }
}