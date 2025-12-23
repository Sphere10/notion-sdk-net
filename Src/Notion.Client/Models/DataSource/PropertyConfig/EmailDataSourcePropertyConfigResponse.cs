using System.Collections.Generic;
using Newtonsoft.Json;

namespace Notion.Client
{
    public class EmailDataSourcePropertyConfigResponse : DataSourcePropertyConfigResponse
    {
        public override string Type => DataSourcePropertyType.Email;

        [JsonProperty("email")]
        public Dictionary<string, object> Email { get; set; }
    }
}
