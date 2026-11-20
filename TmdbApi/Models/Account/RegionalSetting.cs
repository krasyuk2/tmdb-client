namespace TmdbApi.Models.Account;

public class RegionalSetting
{
    public string? Language { get; set; }
    public string? FallbackLanguage { get; set; }
    public string? Country  { get; set; }
    public string? TimeZone {get; set;}
}