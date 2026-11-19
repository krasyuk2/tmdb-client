namespace TmdbApi.Models.People;

public class PersonMovieCredits
{
    public PersonMovieCast[]? Cast { get; set; }
    public PersonMovieCrew[]? Crew { get; set; }
    public int Id { get; set; }
}
