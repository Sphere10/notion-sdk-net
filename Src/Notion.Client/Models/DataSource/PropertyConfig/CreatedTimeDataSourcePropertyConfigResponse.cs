using System.Collections.Generic;
using Newtonsoft.Json;

namespace Notion.Client
{
    public class CreatedTimeDataSourcePropertyConfigResponse : DataSourcePropertyConfigResponse
    {
        public override string Type => DataSourcePropertyType.CreatedTime;

        [JsonProperty("created_time")]
        public Dictionary<string, object> CreatedTime { get; set; }
    }
}
