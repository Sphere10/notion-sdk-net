using JsonSubTypes;
using Newtonsoft.Json;

namespace Notion.Client
{
    [JsonConverter(typeof(JsonSubtypes), "type")]
    [JsonSubtypes.KnownSubType(typeof(EmojiPageIconResponse), PageIconTypes.Emoji)]
    [JsonSubtypes.KnownSubType(typeof(CustomEmojiPageIconResponse), PageIconTypes.CustomEmoji)]
    [JsonSubtypes.KnownSubType(typeof(FilePageIconResponse), PageIconTypes.File)]
    [JsonSubtypes.KnownSubType(typeof(ExternalPageIconResponse), PageIconTypes.External)]
    public interface IPageIconResponse
    {
        [JsonProperty("type")]
        string Type { get; set; }
    }
}
