using System.Text.Json;

namespace TmdbApi.Models.Account;

public class ContentSetting
{
    public bool? AdultContent {get; set;}
    public bool? FilterProfanity {get; set;}
    public JsonElement? EmojiTone {get; set;}
}