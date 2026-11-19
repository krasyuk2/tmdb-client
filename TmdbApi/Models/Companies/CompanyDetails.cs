using System.Text.Json;

namespace TmdbApi.Models.Companies;

public class CompanyDetails
{
    public string? Description { get; set; }
    public string? Headquarters { get; set; }
    public string? Homepage { get; set; }
    public int Id { get; set; }
    public string? LogoPath { get; set; }
    public string? Name { get; set; }
    public string? OriginCountry { get; set; }
    // В примере TMDB null, структура не описана
    public JsonElement? ParentCompany { get; set; }
}
