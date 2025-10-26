using System.Collections.Generic;
using Newtonsoft.Json;

namespace Notion.Client
{
    public class BlockParentResponse : IParentOfDatabaseResponse
    {
        public string Type { get; set; } = "block_id";

        [JsonProperty("block_id")]
        public string BlockId { get; set; }

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalData { get; set; }
    }
}
