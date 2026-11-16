namespace TmdbApi.Models.Search.DTOs;

public class GetResponseCompanyDto
{
    public int Id { get; set; }
    public string? LogoPath { get; set; }
    public string? Name { get; set; }
    public string? OriginalCountry { get; set; }
}
