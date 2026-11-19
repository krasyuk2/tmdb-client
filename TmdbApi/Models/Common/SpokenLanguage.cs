using System.Text.Json.Serialization;

namespace TmdbApi.Models.Common;

public class SpokenLanguage
{
    public string? EnglishName { get; set; }
    [JsonPropertyName("iso_639_1")]
    public string? Iso639_1 { get; set; }
    public string? Name { get; set; }
}
