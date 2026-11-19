using System.Text.Json.Serialization;

namespace TmdbApi.Models.TvSeries.DTOs;

public class GetResponseTranslationsDto
{
    [JsonPropertyName("iso_639_1")]
    public string? ISO_639_1 {get; set;}
       
    [JsonPropertyName("iso_3166_1")]
    public string? ISO_3166_1 {get; set;}
    
    public string? Name { get; set; }
    public string? EnglishName { get; set; }
    public TranslationData? Data { get; set; }
    
}

public class TranslationData
{
    public string? Name { get; set; }
    public string? Overview { get; set; }
    public string? Homepage { get; set; }
    public string? Tagline { get; set; }
}