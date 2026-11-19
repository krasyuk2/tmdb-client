namespace TmdbApi.Models.Common;

public class WatchProviderCountry
{
    public string? Link { get; set; }
    public WatchProvider[]? Flatrate { get; set; }
    public WatchProvider[]? Rent { get; set; }
    public WatchProvider[]? Buy { get; set; }
    public WatchProvider[]? Ads { get; set; }
    public WatchProvider[]? Free { get; set; }
}
