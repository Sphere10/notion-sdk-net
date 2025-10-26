using System.Collections.Generic;
using Newtonsoft.Json;

namespace Notion.Client
{
    public class DataSourceParentResponse : IParentOfDataSourceResponse
    {
        public string Type { get; set; } = "data_source_id";

        [JsonProperty("data_source_id")]
        public string DataSourceId { get; set; }

        [JsonProperty("database_id")]
        public string DatabaseId { get; set; }

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalData { get; set; }
    }
}
