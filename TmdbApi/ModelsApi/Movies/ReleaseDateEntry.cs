using System.Text.Json.Serialization;

namespace TmdbApi.Models.Movies;

public class ReleaseDateEntry
{
    public string? Certification { get; set; }
    public string[]? Descriptors { get; set; }
    [JsonPropertyName("iso_639_1")]
    public string? Iso639_1 { get; set; }
    public string? Note { get; set; }
    public string? ReleaseDate { get; set; }
    public int? Type { get; set; }
}
