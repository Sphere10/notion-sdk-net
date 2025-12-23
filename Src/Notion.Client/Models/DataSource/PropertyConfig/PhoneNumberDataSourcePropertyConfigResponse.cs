using System.Collections.Generic;
using Newtonsoft.Json;

namespace Notion.Client
{
    public class PhoneNumberDataSourcePropertyConfigResponse : DataSourcePropertyConfigResponse
    {
        public override string Type => DataSourcePropertyType.PhoneNumber;

        [JsonProperty("phone_number")]
        public Dictionary<string, object> PhoneNumber { get; set; }
    }
}
