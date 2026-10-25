namespace TmdbApi.Models.Search.DTOs;

public class GetRequestMultiDto
{
    public bool Adult { get; set; }
    public string? BackgroundPath { get; set; }
    public int Id { get; set; }
    public string? Title { get; set; }
    public string? OriginalLanguage { get; set; }
    public string? OriginalTitle { get; set; }
    public string? Overview { get; set; }
    public string? PosterPath { get; set; }
    public string? MediaType { get; set; }
    public int[]? GenreIds { get; set; }
    public double? Popularity { get; set; }
    public string? ReleaseDate { get; set; }
    public bool Video { get; set; }
    public double VoteAverage { get; set; }
    public double VoteCount { get; set; }
    public string? Name { get; set; }
    public string? OriginalName { get; set; }
}