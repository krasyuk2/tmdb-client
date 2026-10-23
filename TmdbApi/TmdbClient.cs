using System.Net.Http.Json;
using TmdbApi.Exceptions;

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
        var result = await _httpClient.GetAsync(query);
        var httpContent = result.Content;

        if (!result.IsSuccessStatusCode)
            await ParseAnswer<TmdbException>(httpContent);

        var content = await ParseAnswer<TResult>(httpContent);

        return content!;
    }

    private async Task<TResult?> ParseAnswer<TResult>(HttpContent content)
    {
        TResult? result;
        try
        {
            result = await content.ReadFromJsonAsync<TResult>();
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
        
        return result;   
    }
}