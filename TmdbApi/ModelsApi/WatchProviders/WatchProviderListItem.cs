namespace TmdbApi.Models.WatchProviders;

public class WatchProviderListItem
{
    public Dictionary<string, int>? DisplayPriorities { get; set; }
    public int? DisplayPriority { get; set; }
    public string? LogoPath { get; set; }
    public string? ProviderName { get; set; }
    public int? ProviderId { get; set; }
}
