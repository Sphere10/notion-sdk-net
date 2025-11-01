using System.Collections.Generic;
using Newtonsoft.Json;

namespace Notion.Client
{
    public class DualPropertyRelationDataRequest : IRelationDataRequest
    {
        public string DataSourceId { get; set; }

        [JsonProperty("type")]
        public string Type => "dual_property";

        [JsonProperty("dual_property")]
        public IDictionary<string, object> DualProperty { get; set; }

        /// <summary>
        /// Additional data for future compatibility
        /// If you encounter properties that are not yet supported, please open an issue on GitHub.
        /// </summary>
        [JsonExtensionData]
        public IDictionary<string, object> AdditionalData { get; set; }
    }
}