using System.Collections.Generic;
using Newtonsoft.Json;

namespace Notion.Client
{
    public class RichTextDataSourcePropertyConfigResponse : DataSourcePropertyConfigResponse
    {
        public override string Type => DataSourcePropertyType.RichText;

        [JsonProperty("rich_text")]
        public Dictionary<string, object> RichText { get; set; }
    }
}
