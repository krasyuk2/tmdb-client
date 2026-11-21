using TmdbApi.Models.Common;

namespace TmdbApi.Models.Movies;

/// <summary>
/// GET /3/movie/{movie_id}/videos — Videos<br/>
/// </summary>
public class MovieVideos
{
    public int Id { get; set; }
    public Video[]? Results { get; set; }
}
