using System.Collections.Generic;
using Newtonsoft.Json;

namespace Notion.Client
{
    public class BlockParent : IParentOfDatabaseResponse, IParentOfBlock, IParentOfPage, IParentOfComment
    {
        public string Type { get; set; } = ParentTypes.Block;

        [JsonProperty(ParentTypes.Block)]
        public string BlockId { get; set; }

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalData { get; set; }
    }
}
