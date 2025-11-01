using System.Collections.Generic;
using Newtonsoft.Json;

namespace Notion.Client
{
    public class PlacePropertyConfigurationRequest : PropertyConfigurationRequest
    {
        [JsonProperty("type")]
        public override string Type => "place";

        [JsonProperty("place")]
        public IDictionary<string, object> Place { get; set; }
    }
}