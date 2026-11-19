using System.Text.Json;
using System.Text.Json.Serialization;

namespace TmdbApi.Models.Common;

public class ChangeItem
{
    public string? Id { get; set; }
    public string? Action { get; set; }
    public string? Time { get; set; }
    [JsonPropertyName("iso_639_1")]
    public string? Iso639_1 { get; set; }
    [JsonPropertyName("iso_3166_1")]
    public string? Iso3166_1 { get; set; }
    public JsonElement? Value { get; set; }
    public JsonElement? OriginalValue { get; set; }
}
