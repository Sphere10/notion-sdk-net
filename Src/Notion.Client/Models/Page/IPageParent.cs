using JsonSubTypes;
using Newtonsoft.Json;

namespace Notion.Client
{
    [JsonConverter(typeof(JsonSubtypes), "type")]
    [JsonSubtypes.KnownSubTypeAttribute(typeof(DatabaseParent), ParentTypes.Database)]
    [JsonSubtypes.KnownSubTypeAttribute(typeof(PageParent), ParentTypes.Page)]
    [JsonSubtypes.KnownSubTypeAttribute(typeof(WorkspaceParent), ParentTypes.Workspace)]
    [JsonSubtypes.KnownSubTypeAttribute(typeof(BlockParent), ParentTypes.Block)]
    [JsonSubtypes.KnownSubTypeAttribute(typeof(DataSourceParent), ParentTypes.Datasource)]
    public interface IPageParent : IParent
    {
    }
}
