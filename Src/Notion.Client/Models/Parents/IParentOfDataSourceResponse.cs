using JsonSubTypes;
using Newtonsoft.Json;

namespace Notion.Client
{
    [JsonConverter(typeof(JsonSubtypes), "type")]
    [JsonSubtypes.KnownSubTypeAttribute(typeof(DatabaseParent), "database_id")]
    [JsonSubtypes.KnownSubTypeAttribute(typeof(DataSourceParent), "data_source_id")]
    public interface IParentOfDataSourceResponse
    {
        [JsonProperty("type")]
        string Type { get; set; }
    }
}
