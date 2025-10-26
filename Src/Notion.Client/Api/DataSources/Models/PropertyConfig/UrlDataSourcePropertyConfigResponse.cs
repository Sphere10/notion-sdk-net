using System.Collections.Generic;
using Newtonsoft.Json;

namespace Notion.Client
{
    public class UrlDataSourcePropertyConfigResponse : DataSourcePropertyConfigResponse
    {
        public override string Type => DataSourcePropertyType.Url;

        [JsonProperty("url")]
        public Dictionary<string, object> Url { get; set; }
    }
}
