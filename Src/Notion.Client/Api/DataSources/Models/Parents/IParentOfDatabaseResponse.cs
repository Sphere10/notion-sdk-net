using JsonSubTypes;
using Newtonsoft.Json;

namespace Notion.Client
{
    [JsonConverter(typeof(JsonSubtypes), "type")]
    [JsonSubtypes.KnownSubTypeAttribute(typeof(DatabaseParentResponse), "database_id")]
    [JsonSubtypes.KnownSubTypeAttribute(typeof(PageParentResponse), "page_id")]
    [JsonSubtypes.KnownSubTypeAttribute(typeof(WorkspaceParentResponse), "workspace")]
    [JsonSubtypes.KnownSubTypeAttribute(typeof(BlockParentResponse), "block_id")]
    public interface IParentOfDatabaseResponse
    {
        [JsonProperty("type")]
        string Type { get; set; }
    }
}
