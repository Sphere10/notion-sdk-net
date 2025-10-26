using Newtonsoft.Json;

namespace Notion.Client
{
    public interface IPageCoverResponse
    {
        [JsonProperty("type")]
        string Type { get; set; }
    }
}
