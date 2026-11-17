namespace TmdbApi.Models.TvSeries.DTOs;

public class GetResponseAccountStatesDto
{
    public int Id { get; set; }
    public bool? Favorite { get; set; }
    public Rate? Rated { get; set; }
    public bool? WatchList { get; set; }
}

public class Rate
{
    public int Value { get; set; }
}