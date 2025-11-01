using System.Collections.Generic;
using Newtonsoft.Json;

namespace Notion.Client
{
    public class StatusPropertyConfigurationRequest : PropertyConfigurationRequest
    {
        [JsonProperty("type")]
        public override string Type => "status";

        [JsonProperty("status")]
        public IDictionary<string, object> Status { get; set; }
    }
}