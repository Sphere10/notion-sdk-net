using System.Collections.Generic;
using Newtonsoft.Json;

namespace Notion.Client
{
    public class CustomEmojiPageIconResponse : IPageIconResponse
    {
        public string Type { get; set; } = PageIconTypes.CustomEmoji;

        [JsonProperty(PageIconTypes.CustomEmoji)]
        public CustomEmojiResponse CustomEmoji { get; set; }

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalData { get; set; }
    }
}
