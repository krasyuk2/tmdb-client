using TmdbApi.Models.Common;

namespace TmdbApi.Models.TvSeasons;

public class TvSeasonCredits
{
    public Cast[]? Cast { get; set; }
    public Crew[]? Crew { get; set; }
    public int Id { get; set; }
}
