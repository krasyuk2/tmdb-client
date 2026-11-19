using TmdbApi.Models.Common;

namespace TmdbApi.Models.Movies;

public class MovieKeywords
{
    public int Id { get; set; }
    public Keyword[]? Keywords { get; set; }
}
