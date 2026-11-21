using System.Text.Json.Serialization;

namespace TmdbApi.Models.Account;

public class AccountDetails
{
    public int? AccentColor { get; set; }
    public Avatar? Avatar { get; set; }
    public string? BackgroundImage { get; set; }
    public string? Description { get; set; }
    public int Id { get; set; }
    [JsonPropertyName("iso_639_1")]
    public string? Iso639_1 { get; set; }
    [JsonPropertyName("iso_3166_1")]
    public string? Iso3166_1 { get; set; }
    public string? Name { get; set; }
    public ContentSetting? ContentSettings { get; set; }
    public bool? IncludeAdult { get; set; }
    public RegionalSetting? RegionalSettings { get; set; }
    public SocialLink? SocialLink { get; set; }
    public string? Username { get; set; }
}
