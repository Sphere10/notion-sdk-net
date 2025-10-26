using Newtonsoft.Json;

namespace Notion.Client
{
    public class MultiSelectDataSourcePropertyConfigResponse : DataSourcePropertyConfigResponse
    {
        public override string Type => DataSourcePropertyType.MultiSelect;

        [JsonProperty("multi_select")]
        public OptionWrapper<SelectOptionResponse> MultiSelect { get; set; }
    }
}
