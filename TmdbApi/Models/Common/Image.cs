using System.Text.Json.Serialization;

namespace TmdbApi.Models.Common;

public class Image
{
    public double? AspectRatio { get; set; }
    public int? Height { get; set; }
    [JsonPropertyName("iso_639_1")]
    public string? Iso639_1 { get; set; }
    public string? FilePath { get; set; }
    public double? VoteAverage { get; set; }
    public int? VoteCount { get; set; }
    public int? Width { get; set; }
}
