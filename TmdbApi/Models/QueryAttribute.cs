namespace TmdbApi.Models;

public class QueryAttribute(string query) : Attribute
{
    public string Query { get; set; } = query;
}