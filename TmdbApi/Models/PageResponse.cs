namespace TmdbApi.Models;

public class PageResponse<TResult> 
{
    public int Page { get; set; }
    public TResult[]? Results { get; set; }
    public int TotalPages { get; set; }
    public int TotalResults { get; set; }
}