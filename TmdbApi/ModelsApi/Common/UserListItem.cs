using System.Text.Json.Serialization;

namespace TmdbApi.Models.Common;

public class UserListItem
{
    public string? Description { get; set; }
    public int? FavoriteCount { get; set; }
    public int Id { get; set; }
    public int? ItemCount { get; set; }
    [JsonPropertyName("iso_639_1")]
    public string? Iso639_1 { get; set; }
    public string? ListType { get; set; }
    public string? Name { get; set; }
    public string? PosterPath { get; set; }
}
