using System.Collections.Generic;
using Newtonsoft.Json;

namespace Notion.Client
{
    public class StatusDataSourcePropertyConfigResponse : DataSourcePropertyConfigResponse
    {
        public override string Type => DataSourcePropertyType.Status;

        [JsonProperty("status")]
        public Dictionary<string, object> Status { get; set; }
    }
}
