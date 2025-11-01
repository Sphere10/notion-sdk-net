using Newtonsoft.Json;

namespace Notion.Client
{
    public class RelationPropertyConfigurationRequest : PropertyConfigurationRequest
    {
        [JsonProperty("type")]
        public override string Type => "relation";

        [JsonProperty("relation")]
        public IRelationDataRequest Relation { get; set; }
    }
}