using System.Text.Json;

namespace TmdbApi.Models.People;

public class PersonDetails
{
    public bool? Adult { get; set; }
    public string[]? AlsoKnownAs { get; set; }
    public string? Biography { get; set; }
    public string? Birthday { get; set; }
    public JsonElement? Deathday { get; set; }
    public int? Gender { get; set; }
    public string? Homepage { get; set; }
    public int Id { get; set; }
    public string? ImdbId { get; set; }
    public string? KnownForDepartment { get; set; }
    public string? Name { get; set; }
    public string? PlaceOfBirth { get; set; }
    public double? Popularity { get; set; }
    public string? ProfilePath { get; set; }
}
