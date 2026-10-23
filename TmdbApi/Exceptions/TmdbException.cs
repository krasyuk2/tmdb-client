namespace TmdbApi.Exceptions;

public class TmdbException : Exception
{
    public TmdbException(string message) : base(message) { }
}