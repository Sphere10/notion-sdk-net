using System.Collections.Generic;
using Newtonsoft.Json;

namespace Notion.Client
{
    public class DateDataSourcePropertyConfigResponse : DataSourcePropertyConfigResponse
    {
        public override string Type => DataSourcePropertyType.Date;

        [JsonProperty("date")]
        public Dictionary<string, object> Date { get; set; }
    }
}
