using System.Text.Json;

namespace TmdbApi.Models.People;

public class PersonExternalIds
{
    public int Id { get; set; }
    public string? FreebaseMid { get; set; }
    public string? FreebaseId { get; set; }
    public string? ImdbId { get; set; }
    public int? TvrageId { get; set; }
    public string? WikidataId { get; set; }
    public string? FacebookId { get; set; }
    public string? InstagramId { get; set; }
    public string? TiktokId { get; set; }
    public string? TwitterId { get; set; }
    public JsonElement? YoutubeId { get; set; }
}
