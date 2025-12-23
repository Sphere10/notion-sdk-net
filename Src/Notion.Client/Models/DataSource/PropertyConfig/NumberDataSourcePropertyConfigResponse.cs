using System.Collections.Generic;
using Newtonsoft.Json;

namespace Notion.Client
{
    public class NumberDataSourcePropertyConfigResponse : DataSourcePropertyConfigResponse
    {
        public override string Type => DataSourcePropertyType.Number;

        [JsonProperty("number")]
        public NumberResponse Number { get; set; }
    }

    public class NumberResponse
    {
        [JsonProperty("format")]
        public string Format { get; set; }

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalData { get; set; }
    }
}
