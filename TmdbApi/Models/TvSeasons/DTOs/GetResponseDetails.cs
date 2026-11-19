namespace TmdbApi.Models.TvSeasons.DTOs;

public class GetResponseDetails
{
    public DateTime? AirDate { get; set; }
    public int? EpisodeNumber { get; set; }
    public string? EpisodeType { get; set; }
    public int Id { get; set; }
    public string? Name { get; set; }
    public string? Overview { get; set; }
    public string? ProductionCode { get; set; }
    public int? Runtime { get; set; }
    public int? SeasonNumber { get; set; }
    public int? ShowId { get; set; }
    public string? StillPath { get; set; }
    public double ? VoteAverage { get; set; }
    public double? VoteCount { get; set; }
    public CrewSeason[]? Crew { get; set; }
    public GuestStars[]? GuestStars { get; set; }
}

public class CrewSeason
{
    public string? Department { get; set; }
    public string? Job { get; set; }
    public string? CreditId { get; set; }
    public bool? Adult  { get; set; }
    public int? Gender {get; set;}
    public int Id {get; set;}
    public string? KnownForDepartment { get; set; }
    public string? Name { get; set; }
    public string? OriginalName { get; set; }
    public double? Popularity { get; set; }
    public string? ProfilePath { get; set; }
}

public class GuestStars
{
    public bool? Adult { get; set; }
    public int? Gender { get; set; }
    public int Id { get; set; }
    public string? KnownForDepartment { get; set; }
    public string? Name { get; set; }
    public string? OriginalName { get; set; }
    public double? Popularity { get; set; }
    public string? ProfilePath { get; set; }
    public string? Character { get; set; }
    public string? CreditId { get; set; }
    public int? Order { get; set; }
}