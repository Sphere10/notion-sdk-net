using System.Collections.Generic;
using Newtonsoft.Json;

namespace Notion.Client
{
    public class ExternalPageIconResponse : IPageIconResponse
    {
        public string Type { get; set; } = PageIconTypes.External;

        [JsonProperty(PageIconTypes.External)]
        public ExternalFileResponse External { get; set; }

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalData { get; set; }
    }
}
