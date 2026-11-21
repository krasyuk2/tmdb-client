using System.Text.Json.Serialization;
using TmdbApi.Models.Common;

namespace TmdbApi.Models.Reviews;

public class ReviewDetails
{
    public string? Id { get; set; }
    public string? Author { get; set; }
    public AuthorDetails? AuthorDetails { get; set; }
    public string? Content { get; set; }
    public string? CreatedAt { get; set; }
    [JsonPropertyName("iso_639_1")]
    public string? Iso639_1 { get; set; }
    public int? MediaId { get; set; }
    public string? MediaTitle { get; set; }
    public string? MediaType { get; set; }
    public string? UpdatedAt { get; set; }
    public string? Url { get; set; }
}
