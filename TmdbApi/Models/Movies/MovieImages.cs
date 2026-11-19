using TmdbApi.Models.Common;

namespace TmdbApi.Models.Movies;

public class MovieImages
{
    public Image[]? Backdrops { get; set; }
    public int Id { get; set; }
    public Image[]? Logos { get; set; }
    public Image[]? Posters { get; set; }
}
