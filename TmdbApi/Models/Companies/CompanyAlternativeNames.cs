using TmdbApi.Models.Common;

namespace TmdbApi.Models.Companies;

public class CompanyAlternativeNames
{
    public int Id { get; set; }
    public AlternativeName[]? Results { get; set; }
}
