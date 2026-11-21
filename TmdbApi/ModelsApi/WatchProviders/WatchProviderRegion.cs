using System.Text.Json.Serialization;

namespace TmdbApi.Models.WatchProviders;

public class WatchProviderRegion
{
    [JsonPropertyName("iso_3166_1")]
    public string? Iso3166_1 { get; set; }
    public string? EnglishName { get; set; }
    public string? NativeName { get; set; }
}
