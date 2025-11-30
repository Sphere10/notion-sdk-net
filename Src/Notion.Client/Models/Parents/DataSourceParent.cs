using Newtonsoft.Json;

namespace Notion.Client
{
    public class DataSourceParent : IPageParent
    {
        public ParentType Type { get; set; }

        [JsonProperty("data_source_id")]
        public string DataSourceId { get; set; }
    }
}