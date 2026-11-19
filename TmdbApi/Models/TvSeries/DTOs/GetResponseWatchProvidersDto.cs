namespace TmdbApi.Models.TvSeries.DTOs;

public class GetResponseWatchProvidersDto
{
    public WatchProviderData? AE { get; set; }
    public WatchProviderData? AR { get; set; }
    public WatchProviderData? AT { get; set; }
    public WatchProviderData? AU { get; set; }
    public WatchProviderData? BA { get; set; }
    public WatchProviderData? BB { get; set; }
    public WatchProviderData? BE { get; set; }
    public WatchProviderData? BG { get; set; }
    public WatchProviderData? BO { get; set; }
    public WatchProviderData? BR { get; set; }
    public WatchProviderData? BS { get; set; }
    public WatchProviderData? CA { get; set; }
    public WatchProviderData? CH { get; set; }
    public WatchProviderData? CI { get; set; }
    public WatchProviderData? CL { get; set; }
    public WatchProviderData? CO { get; set; }
    public WatchProviderData? CR { get; set; }
    public WatchProviderData? CZ { get; set; }
    public WatchProviderData? DE { get; set; }
    public WatchProviderData? DK { get; set; }
    public WatchProviderData? DO { get; set; }
    public WatchProviderData? DZ { get; set; }
    public WatchProviderData? EC { get; set; }
    public WatchProviderData? EG { get; set; }
    public WatchProviderData? ES { get; set; }
    public WatchProviderData? FI { get; set; }
    public WatchProviderData? FR { get; set; }
    public WatchProviderData? GB { get; set; }
    public WatchProviderData? GF { get; set; }
    public WatchProviderData? GH { get; set; }
    public WatchProviderData? GQ { get; set; }
    public WatchProviderData? GT { get; set; }
    public WatchProviderData? HK { get; set; }
    public WatchProviderData? HN { get; set; }
    public WatchProviderData? HR { get; set; }
    public WatchProviderData? HU { get; set; }
    public WatchProviderData? ID { get; set; }
    public WatchProviderData? IE { get; set; }
    public WatchProviderData? IL { get; set; }
    public WatchProviderData? IQ { get; set; }
    public WatchProviderData? IT { get; set; }
    public WatchProviderData? JM { get; set; }
    public WatchProviderData? JP { get; set; }
    public WatchProviderData? KE { get; set; }
    public WatchProviderData? KR { get; set; }
    public WatchProviderData? LB { get; set; }
    public WatchProviderData? LT { get; set; }
    public WatchProviderData? LY { get; set; }
    public WatchProviderData? MD { get; set; }
    public WatchProviderData? MK { get; set; }
    public WatchProviderData? MU { get; set; }
    public WatchProviderData? MX { get; set; }
    public WatchProviderData? MY { get; set; }
    public WatchProviderData? MZ { get; set; }
    public WatchProviderData? NE { get; set; }
    public WatchProviderData? NG { get; set; }
    public WatchProviderData? NL { get; set; }
    public WatchProviderData? NO { get; set; }
    public WatchProviderData? NZ { get; set; }
    public WatchProviderData? PA { get; set; }
    public WatchProviderData? PE { get; set; }
    public WatchProviderData? PH { get; set; }
    public WatchProviderData? PL { get; set; }
    public WatchProviderData? PS { get; set; }
    public WatchProviderData? PT { get; set; }
    public WatchProviderData? PY { get; set; }
    public WatchProviderData? RO { get; set; }
    public WatchProviderData? RS { get; set; }
    public WatchProviderData? RU { get; set; }
    public WatchProviderData? SA { get; set; }
    public WatchProviderData? SC { get; set; }
    public WatchProviderData? SE { get; set; }
    public WatchProviderData? SG { get; set; }
    public WatchProviderData? SI { get; set; }
    public WatchProviderData? SK { get; set; }
    public WatchProviderData? SN { get; set; }
    public WatchProviderData? SV { get; set; }
    public WatchProviderData? TH { get; set; }
    public WatchProviderData? TR { get; set; }
    public WatchProviderData? TT { get; set; }
    public WatchProviderData? TW { get; set; }
    public WatchProviderData? TZ { get; set; }
    public WatchProviderData? UG { get; set; }
    public WatchProviderData? US { get; set; }
    public WatchProviderData? UY { get; set; }
    public WatchProviderData? VE { get; set; }
    public WatchProviderData? ZA { get; set; }
    public WatchProviderData? ZM { get; set; }
}

public class WatchProviderData
{
    public string? Link { get; set; }
    public Flatrate[]? Flatrate { get; set; }
    public Flatrate[]? Buy { get; set; }
    public Flatrate[]? Rent { get; set; }
    public Flatrate[]? Free { get; set; }
    public Flatrate[]? Ads { get; set; }
}

public class Flatrate
{
    public string? LogoPath { get; set; }
    public int? ProviderId { get; set; }
    public string? ProviderName { get; set; }
    public int? DisplayPriority { get; set; }
}