using System.Collections.Generic;
using Newtonsoft.Json;

namespace Notion.Client
{
    public class LastEditedTimePropertyConfigurationRequest : PropertyConfigurationRequest
    {
        [JsonProperty("type")]
        public override string Type => "last_edited_time";

        [JsonProperty("last_edited_time")]
        public IDictionary<string, object> LastEditedTime { get; set; }
    }
}