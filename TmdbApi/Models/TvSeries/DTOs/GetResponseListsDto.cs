using System.Text.Json.Serialization;

namespace TmdbApi.Models.TvSeries.DTOs;

public class GetResponseListsDto
{
    public string? Description { get; set; }
    public int? FavoriteCount { get; set; }
    public int Id { get; set; }
    public int? ItemCount { get; set; }
    [JsonPropertyName("iso_639_1")]
    public string? ISO_639_1 {get; set;}
       
    [JsonPropertyName("iso_3166_1")]
    public string? ISO_3166_1 {get; set;}
    
    public string? Name { get; set; }
    public string? PosterPath { get; set; }
}