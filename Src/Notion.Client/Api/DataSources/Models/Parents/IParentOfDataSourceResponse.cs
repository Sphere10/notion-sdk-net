using JsonSubTypes;
using Newtonsoft.Json;

namespace Notion.Client
{
    [JsonConverter(typeof(JsonSubtypes), "type")]
    [JsonSubtypes.KnownSubTypeAttribute(typeof(DatabaseParentResponse), "database_id")]
    [JsonSubtypes.KnownSubTypeAttribute(typeof(DataSourceParentResponse), "data_source_id")]
    public interface IParentOfDataSourceResponse
    {
        [JsonProperty("type")]
        string Type { get; set; }
    }
}
