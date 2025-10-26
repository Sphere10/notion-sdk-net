using System.Collections.Generic;
using Newtonsoft.Json;

namespace Notion.Client
{
    public class FilePageIconResponse : IPageIconResponse
    {
        public string Type { get; set; } = "file";

        [JsonProperty("file")]
        public InternalFileResponse File { get; set; }

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalData { get; set; }
    }
}
