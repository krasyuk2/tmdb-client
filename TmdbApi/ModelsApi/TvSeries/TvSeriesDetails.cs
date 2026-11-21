using TmdbApi.Models.Common;

namespace TmdbApi.Models.TvSeries;


public class TvSeriesDetails
{
    public bool? Adult { get; set; }
    public string? BackdropPath { get; set; }
    public Creator[]? CreatedBy { get; set; }
    public int[]? EpisodeRunTime { get; set; }
    public string? FirstAirDate { get; set; }
    public Genre[]? Genres { get; set; }
    public string? Homepage { get; set; }
    public int Id { get; set; }
    public bool? InProduction { get; set; }
    public string[]? Languages { get; set; }
    public string? LastAirDate { get; set; }
    public EpisodeToAir? LastEpisodeToAir { get; set; }
    public string? Name { get; set; }
    public EpisodeToAir? NextEpisodeToAir { get; set; }
    public Network[]? Networks { get; set; }
    public int? NumberOfEpisodes { get; set; }
    public int? NumberOfSeasons { get; set; }
    public string[]? OriginCountry { get; set; }
    public string? OriginalLanguage { get; set; }
    public string? OriginalName { get; set; }
    public string? Overview { get; set; }
    public double? Popularity { get; set; }
    public string? PosterPath { get; set; }
    public ProductionCompany[]? ProductionCompanies { get; set; }
    public ProductionCountry[]? ProductionCountries { get; set; }
    public Season[]? Seasons { get; set; }
    public SpokenLanguage[]? SpokenLanguages { get; set; }
    public string? Status { get; set; }
    public string? Tagline { get; set; }
    public string? Type { get; set; }
    public double? VoteAverage { get; set; }
    public int? VoteCount { get; set; }
}
