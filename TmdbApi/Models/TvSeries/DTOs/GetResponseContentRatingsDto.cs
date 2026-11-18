using System.Text.Json.Serialization;

namespace TmdbApi.Models.TvSeries.DTOs;

public class GetResponseContentRatingsDto
{
    public string[]? Descriptors { get; set; }
    
    [JsonPropertyName("iso_3166_1")]
    public string? ISO_3166_1 { get; set; }
    
    public string? Rating { get; set; }
}