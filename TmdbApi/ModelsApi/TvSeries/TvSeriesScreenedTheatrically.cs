namespace TmdbApi.Models.TvSeries;

public class TvSeriesScreenedTheatrically
{
    public int Id { get; set; }
    public ScreenedTheatricallyEpisode[]? Results { get; set; }
}
