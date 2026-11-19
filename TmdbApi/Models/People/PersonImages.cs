using TmdbApi.Models.Common;

namespace TmdbApi.Models.People;

public class PersonImages
{
    public int Id { get; set; }
    public Image[]? Profiles { get; set; }
}
