namespace TmdbApi;

/// <summary>
/// 
/// </summary>
public class TmdbClient : ITmdbClient
{
    private HttpClient _httpClient;
    public TmdbClient(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }
}