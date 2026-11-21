namespace TmdbApi.Models;

public class Query
{
    private readonly List<string> _parts = new();
    public string Add(string key, object value)
    {
        ArgumentNullException.ThrowIfNull(key);
        ArgumentNullException.ThrowIfNull(value);

        return "";
    }

    private string? ParseValue(object value) => value switch
    {
        null => "",
        int i => i.ToString(),
        string s => s.ToString(),
        bool b => b ? "true" : "false",
        _ => value.ToString()
    };
}