using TmdbApi.Models.Common;

namespace TmdbApi.Models.Networks;

public class NetworkImages
{
    public int Id { get; set; }
    public LogoImage[]? Logos { get; set; }
}
