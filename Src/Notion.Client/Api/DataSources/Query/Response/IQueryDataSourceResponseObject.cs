using JsonSubTypes;
using Newtonsoft.Json;

namespace Notion.Client
{
    [JsonConverter(typeof(JsonSubtypes), "type")]
    [JsonSubtypes.KnownSubTypeAttribute(typeof(Page), ObjectType.Page)]
    [JsonSubtypes.KnownSubTypeAttribute(typeof(DataSource), ObjectType.DataSource)]
    public interface IQueryDataSourceResponseObject : IObject
    {
    }
}
