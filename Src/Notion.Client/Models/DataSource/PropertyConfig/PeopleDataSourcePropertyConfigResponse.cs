using System.Collections.Generic;
using Newtonsoft.Json;

namespace Notion.Client
{
    public class PeopleDataSourcePropertyConfigResponse : DataSourcePropertyConfigResponse
    {
        public override string Type => DataSourcePropertyType.People;

        [JsonProperty("people")]
        public Dictionary<string, object> People { get; set; }
    }
}
