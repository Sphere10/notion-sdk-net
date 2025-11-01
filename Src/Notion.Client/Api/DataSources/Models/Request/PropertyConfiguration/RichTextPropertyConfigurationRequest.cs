using System.Collections.Generic;
using Newtonsoft.Json;

namespace Notion.Client
{
    public class RichTextPropertyConfigurationRequest : PropertyConfigurationRequest
    {
        [JsonProperty("type")]
        public override string Type => "rich_text";

        [JsonProperty("rich_text")]
        public IDictionary<string, object> RichText { get; set; }
    }
}