using System.Text.Json;

namespace TmdbApi.JsonSettings;

public static class JsonSerializeOptions
{
    public static JsonSerializerOptions GetJsonSerializeOptionsSnakeCase() =>
        new JsonSerializerOptions(new JsonSerializerOptions
        {
            PropertyNamingPolicy = JsonNamingPolicy.SnakeCaseLower,
        });
}