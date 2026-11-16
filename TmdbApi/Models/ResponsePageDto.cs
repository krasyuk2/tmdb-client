namespace TmdbApi.Models;

public class ResponsePageDto<TypeDto>
{
    public int Page { get; set; }
    public TypeDto[]? Results { get; set; }
    public int TotalPages { get; set; }
    public int TotalResults { get; set; }
}