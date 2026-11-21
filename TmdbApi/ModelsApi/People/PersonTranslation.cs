using System.Text.Json.Serialization;

namespace TmdbApi.Models.People;

public class PersonTranslation
{
    [JsonPropertyName("iso_3166_1")]
    public string? Iso3166_1 { get; set; }
    [JsonPropertyName("iso_639_1")]
    public string? Iso639_1 { get; set; }
    public string? Name { get; set; }
    public string? EnglishName { get; set; }
    public PersonTranslationData? Data { get; set; }
}
