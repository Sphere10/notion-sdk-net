using System.Collections.Generic;
using Newtonsoft.Json;

namespace Notion.Client
{
    public class WorkspaceParentResponse : IParentOfDatabaseResponse
    {
        public string Type { get; set; } = "workspace";

        [JsonProperty("workspace")]
        public bool Workspace { get; set; } = true;

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalData { get; set; }
    }
}
