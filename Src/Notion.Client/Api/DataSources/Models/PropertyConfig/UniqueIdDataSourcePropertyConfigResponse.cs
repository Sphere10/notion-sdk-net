using System.Collections.Generic;
using Newtonsoft.Json;

namespace Notion.Client
{
    public class UniqueIdDataSourcePropertyConfigResponse : DataSourcePropertyConfigResponse
    {
        public override string Type => DataSourcePropertyType.UniqueId;

        [JsonProperty("unique_id")]
        public Dictionary<string, object> UniqueId { get; set; }
    }
}
