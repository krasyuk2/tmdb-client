using System.Text.Json.Serialization;

namespace TmdbApi.Models.People;

public class TaggedImage
{
    public double? AspectRatio { get; set; }
    public string? FilePath { get; set; }
    public int? Height { get; set; }
    public string? Id { get; set; }
    [JsonPropertyName("iso_639_1")]
    public string? Iso639_1 { get; set; }
    public double? VoteAverage { get; set; }
    public int? VoteCount { get; set; }
    public int? Width { get; set; }
    public string? ImageType { get; set; }
    public TaggedImageMedia? Media { get; set; }
    public string? MediaType { get; set; }
}
