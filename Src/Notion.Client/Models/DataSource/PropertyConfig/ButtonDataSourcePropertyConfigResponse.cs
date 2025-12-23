using System.Collections.Generic;
using Newtonsoft.Json;

namespace Notion.Client
{
    public class ButtonDataSourcePropertyConfigResponse : DataSourcePropertyConfigResponse
    {
        public override string Type => DataSourcePropertyType.Button;

        [JsonProperty("button")]
        public Dictionary<string, object> Button { get; set; }
    }
}
