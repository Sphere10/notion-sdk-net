using System.Collections.Generic;
using JsonSubTypes;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Notion.Client
{
    [JsonConverter(typeof(JsonSubtypes), "type")]
    [JsonSubtypes.KnownSubTypeAttribute(typeof(SinglePropertyRelationResponse), "single_property")]
    [JsonSubtypes.KnownSubTypeAttribute(typeof(DualPropertyRelationResponse), "dual_property")]
    public abstract class RelationDataResponse
    {
        [JsonProperty("database_id")]
        public string DatabaseId { get; set; }

        [JsonProperty("type")]
        [JsonConverter(typeof(StringEnumConverter))]
        public virtual string Type { get; set; }

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalData { get; set; }
    }
}
