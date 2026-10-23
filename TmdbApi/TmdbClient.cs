using System.Net.Http.Json;

namespace TmdbApi;

/// <summary>
/// Default implementation of <see cref="ITmdbClient"/> that sends requests to the TMDB API over HTTP.
/// </summary>
public class TmdbClient : ITmdbClient
{
    /// <summary>
    /// The HTTP client used to send requests to the TMDB API.
    /// </summary>
    private readonly HttpClient _httpClient;

    /// <summary>
    /// Initializes a new instance of the <see cref="TmdbClient"/> class.
    /// </summary>
    /// <param name="httpClient">The HTTP client used to send requests to the TMDB API.</param>
    public TmdbClient(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    private async Task<TResult> GetAsync<TResult>(string query)
    {
        var result = await _httpClient.GetAsync("");
        if(!result.IsSuccessStatusCode)
            throw new HttpRequestException(result.ReasonPhrase);
        
        TResult? content;
        try
        {
            content = await result.Content.ReadFromJsonAsync<TResult>();
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
        
        return content!;
    }
}