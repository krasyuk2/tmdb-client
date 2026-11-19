namespace TmdbApi.Models.Configuration;

public class ImagesConfiguration
{
    public string? BaseUrl { get; set; }
    public string? SecureBaseUrl { get; set; }
    public string[]? BackdropSizes { get; set; }
    public string[]? LogoSizes { get; set; }
    public string[]? PosterSizes { get; set; }
    public string[]? ProfileSizes { get; set; }
    public string[]? StillSizes { get; set; }
}
