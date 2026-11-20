using System.Net.Http.Json;
using System.Text.Json;
using Microsoft.Extensions.Options;
using TmdbApi.Exceptions;
using TmdbApi.JsonSettings;
using TmdbApi.Models;
using TmdbApi.Models.Account;
using TmdbApi.Models.Common;
using TmdbApi.Models.Enums;
using TmdbApi.Options;

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
    private readonly TmdbClientOptions _options;

    /// <summary>
    /// Initializes a new instance of the <see cref="TmdbClient"/> class.
    /// </summary>
    /// <param name="httpClient">The HTTP client used to send requests to the TMDB API.</param>
    /// <param name="options">Settings tmdb client.</param>
    public TmdbClient(HttpClient httpClient, IOptions<TmdbClientOptions> options)
    {
        _httpClient = httpClient;
        _options = options.Value;
    }

    /// <inheritdoc/>
    public Task<AccountDetails> GetAccountDetailsAsync(int accountId, CancellationToken cancellationToken = default) =>
        GetAsync<AccountDetails>($"{_options.BaseUrl}account/{accountId}", cancellationToken);

    /// <inheritdoc/>
    public Task<PageResponse<MovieListItem>> GetAccountFavoriteMovies(int accountId, string sessionId,
        string? language = null, int page = 1, SortByCreate? sortBy = null,
        CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(sessionId);

        return GetAsync<PageResponse<MovieListItem>>(
            $"account/{accountId}/favorite/movies{query}", cancellationToken);
    }

    private async Task<TResult> GetAsync<TResult>(string query, CancellationToken cancellationToken)
    {
        var result = await _httpClient.GetAsync(query, cancellationToken);
        var httpContent = result.Content;

        if (!result.IsSuccessStatusCode)
            throw await ParseAnswer<TmdbException>(httpContent) ?? throw new JsonException();

        return await ParseAnswer<TResult>(httpContent) ?? throw new JsonException();
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