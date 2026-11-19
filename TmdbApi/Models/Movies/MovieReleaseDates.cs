namespace TmdbApi.Models.Movies;

public class MovieReleaseDates
{
    public int Id { get; set; }
    public ReleaseDatesByCountry[]? Results { get; set; }
}
