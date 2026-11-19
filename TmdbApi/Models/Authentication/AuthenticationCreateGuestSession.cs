namespace TmdbApi.Models.Authentication;


public class AuthenticationCreateGuestSession
{
    public bool? Success { get; set; }
    public string? GuestSessionId { get; set; }
    public string? ExpiresAt { get; set; }
}
