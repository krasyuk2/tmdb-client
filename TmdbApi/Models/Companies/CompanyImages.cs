using TmdbApi.Models.Common;

namespace TmdbApi.Models.Companies;

public class CompanyImages
{
    public int Id { get; set; }
    public LogoImage[]? Logos { get; set; }
}
