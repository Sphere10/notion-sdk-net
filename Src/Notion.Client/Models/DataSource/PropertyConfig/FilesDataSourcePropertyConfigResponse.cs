using System.Collections.Generic;
using Newtonsoft.Json;

namespace Notion.Client
{
    public class FilesDataSourcePropertyConfigResponse : DataSourcePropertyConfigResponse
    {
        public override string Type => DataSourcePropertyType.Files;

        [JsonProperty("files")]
        public Dictionary<string, object> Files { get; set; }
    }
}
