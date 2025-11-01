using System.Collections.Generic;
using Newtonsoft.Json;

namespace Notion.Client
{
    public class LocationPropertyConfigurationRequest : PropertyConfigurationRequest
    {
        [JsonProperty("type")]
        public override string Type => "location";

        [JsonProperty("location")]
        public IDictionary<string, object> Location { get; set; }
    }
}