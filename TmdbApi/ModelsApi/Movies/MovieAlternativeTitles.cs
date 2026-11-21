using TmdbApi.Models.Common;

namespace TmdbApi.Models.Movies;

/// <summary>
/// GET /3/movie/{movie_id}/alternative_titles — Alternative Titles<br/>
/// </summary>
public class MovieAlternativeTitles
{
    public int Id { get; set; }
    public AlternativeTitle[]? Titles { get; set; }
}
