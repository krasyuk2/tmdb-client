using System.Text.Json.Serialization;

namespace TmdbApi.Models.Account;

public class AccountDetails
{
    public Avatar? Avatar { get; set; }
    public int Id { get; set; }
    [JsonPropertyName("iso_639_1")]
    public string? Iso639_1 { get; set; }
    [JsonPropertyName("iso_3166_1")]
    public string? Iso3166_1 { get; set; }
    public string? Name { get; set; }
    public bool? IncludeAdult { get; set; }
    public string? Username { get; set; }
}
