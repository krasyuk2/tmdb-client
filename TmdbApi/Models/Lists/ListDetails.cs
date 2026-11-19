using System.Text.Json.Serialization;
using TmdbApi.Models.Common;

namespace TmdbApi.Models.Lists;

public class ListDetails
{
    public string? CreatedBy { get; set; }
    public string? Description { get; set; }
    public int? FavoriteCount { get; set; }
    public string? Id { get; set; }
    public MediaListItem[]? Items { get; set; }
    public int? ItemCount { get; set; }
    [JsonPropertyName("iso_639_1")]
    public string? Iso639_1 { get; set; }
    public string? Name { get; set; }
    public string? PosterPath { get; set; }
}
