using System.Collections.Generic;
using Newtonsoft.Json;

namespace Notion.Client
{
    public class CheckboxPropertyConfigurationRequest : PropertyConfigurationRequest
    {
        [JsonProperty("type")]
        public override string Type => "checkbox";

        [JsonProperty("checkbox")]
        public IDictionary<string, object> Checkbox { get; set; }
    }
}