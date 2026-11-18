using System.Text.Json.Serialization;

namespace TmdbApi.Models.TvSeries.DTOs;

public class GetResponseChangesDto
{
    public string? Key {get; set;}
    public ChangeItem[]? Items {get; set;}
}

public class ChangeItem
{
    public string? Id {get; set;}
    public string? Action {get; set;}
    public string? Time {get; set;}
    
    [JsonPropertyName("iso_639_1")]
    public string? ISO_639_1 {get; set;}
       
    [JsonPropertyName("iso_3166_1")]
    public string? ISO_3166_1 {get; set;}
    public ValueChange? Value {get; set;}
    public ValueChange? OriginalValue {get; set;}
    
}

public class ValueChange
{
    public ImageInfo? Poster {get; set;}
    public ImageInfo? Backdrop { get; set; }
}

public class ImageInfo
{
    public string? FilePath {get; set;}
    
    [JsonPropertyName("iso_639_1")]
    public string? ISO_639_1 {get; set;}
}