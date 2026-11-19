using System.Text.Json.Serialization;

namespace TmdbApi.Models.TvSeries;

public class ContentRating
{
    public string[]? Descriptors { get; set; }
    [JsonPropertyName("iso_3166_1")]
    public string? Iso3166_1 { get; set; }
    public string? Rating { get; set; }
}
