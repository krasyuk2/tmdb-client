using System.Net.Http.Json;
using TmdbApi.Exceptions;
using TmdbApi.JsonSettings;
using TmdbApi.Models.Search;
using TmdbApi.Models.Search.DTOs;

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

    public async Task<GetRequestSearchDto<GetRequestMultiDto>> GetRequestMultiSearchAsync(string name,
        bool includeAdult = false, string language = "en-US", int page = 1)
    {
        string query = "https://api.themoviedb.org/3/search/multi?query=m&include_adult=false&language=en-US&page=1";
        return await GetAsync<GetRequestSearchDto<GetRequestMultiDto>>(query);
    }

    private async Task<TResult> GetAsync<TResult>(string query)
    {
        var result = await _httpClient.GetAsync(query);
        var httpContent = result.Content;

        if (!result.IsSuccessStatusCode)
            throw await ParseAnswer<TmdbException>(httpContent) ?? new TmdbException("Lol") ;

        return await ParseAnswer<TResult>(httpContent) ?? throw new TmdbException("Lol");
    }

    private async Task<TResult?> ParseAnswer<TResult>(HttpContent content)
    {
        TResult? result;
        try
        {
            result = await content.ReadFromJsonAsync<TResult>(JsonSerializeOptions.GetJsonSerializeOptionsSnakeCase());
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
        
        return result;   
    }
}