using System.Collections.Generic;
using Newtonsoft.Json;

namespace Notion.Client
{
    public class VerificationPropertyConfigurationRequest : PropertyConfigurationRequest
    {
        [JsonProperty("type")]
        public override string Type => "verification";

        [JsonProperty("verification")]
        public IDictionary<string, object> Verification { get; set; }
    }
}