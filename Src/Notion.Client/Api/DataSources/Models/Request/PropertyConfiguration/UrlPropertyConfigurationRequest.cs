using System.Collections.Generic;
using Newtonsoft.Json;

namespace Notion.Client
{
    public class UrlPropertyConfigurationRequest : PropertyConfigurationRequest
    {
        [JsonProperty("type")]
        public override string Type => "url";

        [JsonProperty("url")]
        public IDictionary<string, object> Url { get; set; }
    }
}