using System.Collections.Generic;
using Newtonsoft.Json;

namespace Notion.Client
{
    public class EmojiPageIconResponse : IPageIconResponse
    {
        public string Type { get; set; } = "emoji";

        [JsonProperty("emoji")]
        public string Emoji { get; set; }

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalData { get; set; }
    }
}
