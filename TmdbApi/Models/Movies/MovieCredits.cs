using TmdbApi.Models.Common;

namespace TmdbApi.Models.Movies;

public class MovieCredits
{
    public int Id { get; set; }
    public Cast[]? Cast { get; set; }
    public Crew[]? Crew { get; set; }
}
