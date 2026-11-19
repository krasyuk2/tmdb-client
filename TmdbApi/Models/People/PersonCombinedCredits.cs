namespace TmdbApi.Models.People;

public class PersonCombinedCredits
{
    public PersonCombinedCast[]? Cast { get; set; }
    public PersonCombinedCrew[]? Crew { get; set; }
    public int Id { get; set; }
}
