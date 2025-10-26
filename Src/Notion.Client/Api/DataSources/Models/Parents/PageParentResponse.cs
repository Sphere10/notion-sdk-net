using System.Collections.Generic;
using Newtonsoft.Json;

namespace Notion.Client
{
    public class PageParentResponse : IParentOfDatabaseResponse
    {
        public string Type { get; set; } = "page_id";

        [JsonProperty("page_id")]
        public string PageId { get; set; }

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalData { get; set; }
    }
}
