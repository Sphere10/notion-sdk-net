using System.Collections.Generic;
using Newtonsoft.Json;

namespace Notion.Client
{
    public class FilesPropertyConfigurationRequest : PropertyConfigurationRequest
    {
        [JsonProperty("type")]
        public override string Type => "files";

        [JsonProperty("files")]
        public IDictionary<string, object> Files { get; set; }
    }
}