namespace TmdbApi.Models.Search;

public class GetRequestSearchDto<TypeDto>
{
    public int Page { get; set; }
    public TypeDto[]? Results { get; set; }
    public int TotalPages { get; set; }
    public int TotalResults { get; set; }
}