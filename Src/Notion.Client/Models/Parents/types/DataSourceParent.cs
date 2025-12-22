using System.Collections.Generic;
using Newtonsoft.Json;

namespace Notion.Client
{
    public class DataSourceParent : IParentOfDataSourceResponse, IParentOfBlock, IParentOfPage
    {
        public string Type { get; set; } = ParentTypes.Datasource;

        [JsonProperty(ParentTypes.Datasource)]
        public string DataSourceId { get; set; }

        [JsonProperty(ParentTypes.Database)]
        public string DatabaseId { get; set; }

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalData { get; set; }
    }
}
