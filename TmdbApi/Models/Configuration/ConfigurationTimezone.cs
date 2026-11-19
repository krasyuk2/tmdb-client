using System.Text.Json.Serialization;

namespace TmdbApi.Models.Configuration;

public class ConfigurationTimezone
{
    [JsonPropertyName("iso_3166_1")]
    public string? Iso3166_1 { get; set; }
    public string[]? Zones { get; set; }
}
