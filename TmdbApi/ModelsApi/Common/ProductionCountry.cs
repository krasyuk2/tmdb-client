using System.Text.Json.Serialization;

namespace TmdbApi.Models.Common;

public class ProductionCountry
{
    [JsonPropertyName("iso_3166_1")]
    public string? Iso3166_1 { get; set; }
    public string? Name { get; set; }
}
