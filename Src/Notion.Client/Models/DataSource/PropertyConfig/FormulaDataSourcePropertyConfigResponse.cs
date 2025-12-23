using System.Collections.Generic;
using Newtonsoft.Json;

namespace Notion.Client
{
    public class FormulaDataSourcePropertyConfigResponse : DataSourcePropertyConfigResponse
    {
        public override string Type => DataSourcePropertyType.Formula;

        [JsonProperty("formula")]
        public FormulaResponse Formula { get; set; }
    }

    public class FormulaResponse
    {
        [JsonProperty("expression")]
        public string Expression { get; set; }

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalData { get; set; }
    }
}
