using System.Collections.Generic;
using Newtonsoft.Json;

namespace Notion.Client
{
    public class DatabaseParentResponse : IParentOfDataSourceResponse, IParentOfDatabaseResponse
    {
        public string Type { get; set; } = "database_id";

        [JsonProperty("database_id")]
        public string DatabaseId { get; set; }

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalData { get; set; }
    }
}
