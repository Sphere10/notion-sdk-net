using System.Collections.Generic;
using Newtonsoft.Json;

namespace Notion.Client
{
    public class CreatedByDataSourcePropertyConfigResponse : DataSourcePropertyConfigResponse
    {
        public override string Type => DataSourcePropertyType.CreatedBy;

        [JsonProperty("created_by")]
        public Dictionary<string, object> CreatedBy { get; set; }
    }
}
