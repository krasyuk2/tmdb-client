namespace TmdbApi.Models.Search.DTOs;

public class GetRequestCollectionDto
{
    public bool? Adult { get; set; }
    public string? BackdropPath { get; set; }
    public int Id { get; set; }
    public string? Name { get; set; }
    public string? OriginalLanguage { get; set; }
    public string? OriginalName { get; set; }
    public string? Overview { get; set; }
    public string? PosterPath { get; set; }
}
