using System.Collections.Generic;
using Newtonsoft.Json;

namespace Notion.Client
{
    public class PhoneNumberPropertyConfigurationRequest : PropertyConfigurationRequest
    {
        [JsonProperty("type")]
        public override string Type => "phone_number";

        [JsonProperty("phone_number")]
        public IDictionary<string, object> PhoneNumber { get; set; }
    }
}