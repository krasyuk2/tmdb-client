namespace TmdbApi.Models.Common;

public class AggregateCast
{
    public bool? Adult { get; set; }
    public int? Gender { get; set; }
    public int Id { get; set; }
    public string? KnownForDepartment { get; set; }
    public string? Name { get; set; }
    public string? OriginalName { get; set; }
    public double? Popularity { get; set; }
    public string? ProfilePath { get; set; }
    public AggregateRole[]? Roles { get; set; }
    public int? TotalEpisodeCount { get; set; }
    public int? Order { get; set; }
}
