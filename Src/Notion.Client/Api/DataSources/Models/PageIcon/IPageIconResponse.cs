using JsonSubTypes;
using Newtonsoft.Json;

namespace Notion.Client
{
    [JsonConverter(typeof(JsonSubtypes), "type")]
    [JsonSubtypes.KnownSubTypeAttribute(typeof(EmojiPageIconResponse), "emoji]")]
    [JsonSubtypes.KnownSubTypeAttribute(typeof(CustomEmojiPageIconResponse), "custom_emoji")]
    [JsonSubtypes.KnownSubTypeAttribute(typeof(FilePageIconResponse), "file")]
    [JsonSubtypes.KnownSubTypeAttribute(typeof(ExternalPageIconResponse), "external")]
    public interface IPageIconResponse
    {
        [JsonProperty("type")]
        string Type { get; set; }
    }
}
