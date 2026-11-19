namespace TmdbApi.Models.People;

public class PersonTvCredits
{
    public PersonTvCast[]? Cast { get; set; }
    public PersonTvCrew[]? Crew { get; set; }
    public int Id { get; set; }
}
