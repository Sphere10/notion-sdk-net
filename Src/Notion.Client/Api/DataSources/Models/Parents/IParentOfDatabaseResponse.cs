using Newtonsoft.Json;

namespace Notion.Client
{
    public interface IParentOfDatabaseResponse
    {
        [JsonProperty("type")]
        string Type { get; set; }
    }
}
