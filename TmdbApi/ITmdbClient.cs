using TmdbApi.Models.Search;
using TmdbApi.Models.Search.DTOs;

namespace TmdbApi;

/// <summary>
/// Defines a client for working with The Movie Database (TMDB) API.
/// </summary>
public interface ITmdbClient
{
    Task<GetRequestSearchDto<GetRequestMultiDto>> GetRequestSearchAsync(string name,
        bool includeAdult = false, string language = "en-US", int page = 1);
}