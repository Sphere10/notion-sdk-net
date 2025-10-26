using Newtonsoft.Json;

namespace Notion.Client
{
    public class RelationDataSourcePropertyConfigResponse : DataSourcePropertyConfigResponse
    {
        public override string Type => DataSourcePropertyType.Relation;

        [JsonProperty("relation")]
        public RelationDataResponse Relation { get; set; }
    }
}
