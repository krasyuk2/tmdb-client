using TmdbApi.Models.Common;

namespace TmdbApi.Models.Networks;

public class NetworkAlternativeNames
{
    public int Id { get; set; }
    public AlternativeName[]? Results { get; set; }
}
