using System.Text.Json.Serialization;

namespace TmdbApi.Models.Configuration;

public class ConfigurationLanguage
{
    [JsonPropertyName("iso_639_1")]
    public string? Iso639_1 { get; set; }
    public string? EnglishName { get; set; }
    public string? Name { get; set; }
}
