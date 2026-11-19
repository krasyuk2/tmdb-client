using System.Text.Json.Serialization;

namespace TmdbApi.Models.TvSeries.DTOs;

public class GetResponseVideosDto
{
    [JsonPropertyName("iso_639_1")]
    public string? ISO_639_1 {get; set;}
       
    [JsonPropertyName("iso_3166_1")]
    public string? ISO_3166_1 {get; set;}
    
    public string? Name { get; set; }
    public string? Key { get; set; }
    public string? Site { get; set; }
    public int? Size { get; set; }
    public string? Type { get; set; }
    public bool? Official { get; set; }
    public DateTime? PublishedAt { get; set; }
    public string? Id { get; set; }
}