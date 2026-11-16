namespace TmdbApi.Models;

public class Tv
{
    public string? BackdropPath { get; set; }
    public int[]? GenreIds { get; set; }
    public int Id { get; set; }
    public string[]? OriginCountry { get; set; }
    public string? OriginLanguage { get; set; }
    public string? OriginalName { get; set; }
    public string? Overview { get; set; }

    //TODO: Сериализатор под это
    public double? Popularity { get; set; }
    public string? PosterPath { get; set; }

    //TODO: сериализатор написать под это
    public DateTime? FirstAirDate { get; set; }
    public string? Name { get; set; }
    public double? VoteAverage { get; set; }
    public double? VoteCount { get; set; }
}