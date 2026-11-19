namespace TmdbApi.Models.Authentication;

public class AuthenticationCreateRequestToken
{
    public bool? Success { get; set; }
    public string? ExpiresAt { get; set; }
    public string? RequestToken { get; set; }
}
