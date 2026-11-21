using TmdbApi.Models.Common;

namespace TmdbApi.Models.TvSeries;

public class EpisodeGroup
{
    public string? Description { get; set; }
    public int? EpisodeCount { get; set; }
    public int? GroupCount { get; set; }
    public string? Id { get; set; }
    public string? Name { get; set; }
    public Network? Network { get; set; }
    public int? Type { get; set; }
}
