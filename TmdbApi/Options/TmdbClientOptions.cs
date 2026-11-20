namespace TmdbApi.Options;

public class TmdbClientOptions
{
    public string AccessToken { get; set; } = "";
    public string BaseUrl { get; set; } = "https://api.themoviedb.org/3/";
    public string Language { get; set; } = "en-US";
}