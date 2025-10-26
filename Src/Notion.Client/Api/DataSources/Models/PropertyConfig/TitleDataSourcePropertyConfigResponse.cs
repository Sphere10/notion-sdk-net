using System.Collections.Generic;
using Newtonsoft.Json;

namespace Notion.Client
{
    public class TitleDataSourcePropertyConfigResponse : DataSourcePropertyConfigResponse
    {
        public override string Type => DataSourcePropertyType.Title;

        [JsonProperty("title")]
        public Dictionary<string, object> Title { get; set; }
    }
}
