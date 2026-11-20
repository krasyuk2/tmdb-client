namespace TmdbApi.Exceptions;

public class TmdbException : Exception
{
    public bool Success { get; set; }
    public int StatusCode { get; set; }
    public TmdbException(string message) : base(message) { }
}