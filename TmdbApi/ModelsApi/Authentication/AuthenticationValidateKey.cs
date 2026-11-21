namespace TmdbApi.Models.Authentication;

public class AuthenticationValidateKey
{
    public bool? Success { get; set; }
    public int? StatusCode { get; set; }
    public string? StatusMessage { get; set; }
}
