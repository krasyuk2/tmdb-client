using System.Text.Json.Serialization;

namespace TmdbApi.Models.TvSeries.DTOs;

public class GetResponseDetailsDto
{
    public bool? Adult { get; set; }
    public string? BackdropPath { get; set; }
    public Person[]? CreatedBy { get; set; }
    public int[]? EpisodeRunTime { get; set; }
    public DateTime? FirstAirDate { get; set; }
    public Genre[]? Genres { get; set; }
    public string? Homepage { get; set; }
    public string? Id { get; set; }
    public bool? InProduction { get; set; }
    public string[]? Languages { get; set; }
    public DateTime? LastAirDate { get; set; }
    public Episode? LastEpisodeToAir { get; set; }
    public string? Name { get; set; }
    public Episode? NextEpisodeToAir { get; set; }
    public Network[]? Networks { get; set; }
    public int? NumberOfEpisodes { get; set; }
    public int? NumberOfSeasons { get; set; }
    public string[]? OriginCountry { get; set; }
    public string? OriginalLanguage { get; set; }
    public string? OriginalName { get; set; }
    public string? Overview { get; set; }
    public double? Popularity { get; set; }
    public string? PosterPath { get; set; }
    public Network[]? ProductionCompanies { get; set; }
    public ProductionCountry[]? ProductionCountries { get; set; }
    public Season[]? Seasons { get; set; }
    public SpokenLanguage[]? SpokenLanguages { get; set; }
    public string? Status { get; set; }
    public string? Tagline { get; set; }
    public string? Type { get; set; }
    public double? VoteAverage { get; set; }
    public int? VoteCount { get; set; }
}

public class Genre
{
    public int  Id { get; set; }
    public string? Name { get; set; }
}

public class Person
{
    public int Id { get; set; }
    public string? CreditId { get; set; }
    public string? Name { get; set; }
    public int? Gender { get; set; }
    public string? ProfilePath { get; set; }
}

public class Episode
{
    public int Id { get; set; }
    public string? Name { get; set; }
    public string? Overview { get; set; }
    public double? VoteAverage { get; set; }
    public int? VoteCount { get; set; }
    public DateTime? AirDate { get; set; }
    public int? EpisodeNumber { get; set; }
    public string? ProductionCode  { get; set; }
    public int? Runtime { get; set; }
    public int? SeasonNumber { get; set; }
    public int? ShowId { get; set; }
    public string? StillPath { get; set; }
}

public class Network
{
    public int Id { get; set; }
    public string? LogoPath { get; set; }
    public string? Name { get; set; }
    public string? OriginCountry  { get; set; }
}

public class ProductionCountry
{
    [JsonPropertyName("iso_3166_1")]
    public string? ISO_3166_1 { get; set; }
    public string? Name { get; set; }
}

public class SpokenLanguage
{
    public string? EnglishName { get; set; }
    
    [JsonPropertyName("iso_3166_1")]
    public string? ISO_639_1 { get; set; }
    public string? Name { get; set; }
}

public class Season
{
    public DateTime? AirDate { get; set; }
    public int? EpisodeCount { get; set; }
    public int Id { get; set; }
    public string? Name { get; set; }
    public string? Overview { get; set; }
    public string? PosterPath { get; set; }
    public int? SeasonNumber { get; set; }
    public double? VoteAverage { get; set; }
}

